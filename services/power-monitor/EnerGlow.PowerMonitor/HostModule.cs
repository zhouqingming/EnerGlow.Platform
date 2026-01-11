using EnerGlow.PowerMonitor.Exceptions;
using EnerGlow.PowerMonitor.HttpAPI;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Volo.Abp;
using Volo.Abp.AspNetCore.ExceptionHandling;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Autofac;
using Volo.Abp.FluentValidation;
using Volo.Abp.Modularity;
using Volo.Abp.Swashbuckle;

namespace EnerGlow.PowerMonitor.Host
{
    /// <summary>
    /// 领域HttpAPI
    /// </summary>
    [DependsOn(typeof(AbpAspNetCoreMvcModule),
               typeof(AbpAutofacModule),
               typeof(AbpSwashbuckleModule),
               typeof(AbpFluentValidationModule) // 未使用

        )]
    public class HostModule : AbpModule
    {
        public override void ConfigureServices(
            ServiceConfigurationContext context)
        {
            

            context.Services.AddControllers(options => {
                // 1、添加自定义过滤器
                options.Filters.Add<CustomExceptionFilter>();
                // 取消默认的xss攻击
                options.Filters.Add(new IgnoreAntiforgeryTokenAttribute());
            });

            context.Services.AddEndpointsApiExplorer();
            // 4、使用abp接口
            context.Services.AddAbpSwaggerGen(options => {
                // 4.1、显示自动控制器 API列表
                options.DocInclusionPredicate((doname, api) => true);
            });

            // 4、配置AbpAspNetCoreMvc模块
            Configure<AbpAspNetCoreMvcOptions>(options =>
            {
                // 4.1、配置自动API控制器             
                options.ConventionalControllers.Create(typeof(HostModule).Assembly,
                    options => {
                        options.RootPath = "Projects";
                    });


            });

            // 5、配置API控制器异常
            Configure<AbpExceptionHandlingOptions>(options => {
                // 5.1、显示具体异常信息
                options.SendExceptionsDetailsToClients = true;
                // 5.2、不显示异常堆栈
                options.SendStackTraceToClients = false;
            });

            // 6、配置异常响应状态码
            Configure<AbpExceptionHttpStatusCodeOptions>(
                options =>
                {
                    // 6.1、异常编码 和 异常响应码异常
                    options.Map("YDT0001", HttpStatusCode.OK);
                });

            // 7、设置身份认证
            context.Services.AddAuthentication().AddCookie();
            // 8、设置权限
            context.Services.AddAuthorization();

        }

        public override void OnApplicationInitialization(
            ApplicationInitializationContext context)
        {
            var app = context.GetApplicationBuilder();
            var Environment = context.GetEnvironment();

            // Configure the HTTP request pipeline.
            /*if (Environment.IsDevelopment())
            {*/
            app.UseSwagger();
            //app.UseSwaggerUI();
            //4.2、配置abp SwaggerUI中间件
            app.UseAbpSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "api API");
            });
            /* }*/

            // 8、开启多租户
           // app.UseMultiTenancy();

            // 4.3、增加静态资源中间件
            app.UseStaticFiles();

            // 3.1、配置abp的路由
            app.UseRouting();

            app.UseHttpsRedirection();

            // 7、配置身份认证和权限中间件
            app.UseAuthentication();
            app.UseAuthorization();

            // 3.2、配置abp的中间件
            app.UseConfiguredEndpoints();
        }
    }
}
