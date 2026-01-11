

namespace EnerGlow.PowerMonitor.Host
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // 2、加载ProjectModule
            builder.Services.AddApplication<HostModule>();

            // 4、加载Autofac
            builder.Host.UseAutofac();

            var app = builder.Build();

            // 3、加载中间件
            app.InitializeApplication();

            app.Run();
        }
    }
}
