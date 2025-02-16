using Microsoft.EntityFrameworkCore;
using SonarCommunication.Core.Abstraction.Repositories;
using SonarCommunication.Core.Domain.SearchGroups;
using SonarCommunication.Core.Domain.Statements;
using SonarCommunication.Core.Domain.VolontersManagment;
using SonarCommunication.DataAccess.Data;
using SonarCommunication.DataAccess.Repositories;

namespace SonarCommunication.WebHost;

public class StartUp
{
    public IConfiguration Configuration { get; }

    public StartUp(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        //services.AddControllers().AddMvcOptions(x=>x.SuppressAsyncSuffixInActionNames = false);
        //Цепляемся к БД
        services.AddDbContext<DataContext>(o => 
            o.UseNpgsql(Configuration.GetConnectionString("PostgreConn"),
            o => o.MigrationsAssembly("")));

        services.AddOpenApiDocument(o =>
        {
            o.Title = "SonarCommunication API Doc";
            o.Version = "0.1";
        });

        services.AddScoped(typeof(IBaseRepositories<Statment>), typeof(EFBaseRepository<Statment>));
        services.AddScoped(typeof(IMailingAll<Volunteer>),typeof(EFMailingRepository<Volunteer>));

        services.AddScoped(typeof(IRepository<SearchGroup>), typeof(SearchGroupRepository));
        services.AddScoped(typeof(IRepository<GroupMember>), typeof(GroupMemberRepository));
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseHsts();
        }

        app.UseOpenApi();
        app.UseSwaggerUI(x =>
        {            
            //x.DocExpansion = "list";
        });

        app.UseHttpsRedirection();

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });    
    }
}