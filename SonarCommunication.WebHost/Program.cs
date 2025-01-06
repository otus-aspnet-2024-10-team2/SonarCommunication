namespace SonarCommunication.WebHost;

public class Program
{
    public static void Main(string[] args)
    {
        //var builder = WebApplication.CreateBuilder(args);
        //var app = builder.Build();

        //app.MapGet("/", () => "Hello World!");

        //app.Run();
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args)
    {
        return Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<StartUp>(); });
    }
}