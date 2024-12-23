namespace SonarCommunication.WebHost;

public class StartUp
{
    public IConfiguration Configuration { get; set; }

    public StartUp(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        //TODO: Сделать подготовку сервисной части
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        //TODO: Сделать напонение конфигурации
    }
}