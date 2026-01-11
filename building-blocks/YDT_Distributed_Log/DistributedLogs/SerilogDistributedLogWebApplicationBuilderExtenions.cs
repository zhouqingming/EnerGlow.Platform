using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog.Events;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog.Sinks.RabbitMQ;

namespace EnerGlow.LogHelper.DistributedLogs
{
    /// <summary>
    /// 分布式日志封装
    /// </summary>
    public static class SerilogDistributedLogWebApplicationBuilderExtenions
    {
        public static WebApplicationBuilder AddDistributedLog(this WebApplicationBuilder builder) 
        {
           var Configuration = builder.Configuration;

            // 1、配置Serilog
            Log.Logger = new LoggerConfiguration()
                // 日志写到控制器
                .MinimumLevel.Error() // 日志级别
                .MinimumLevel.Override(Configuration["DistributedLog:LogLevel:Name"], LogEventLevel.Information) // 减少框架日志【日志过滤】
                .WriteTo.Console()
                // 日志写到RabbitMQ
                .WriteTo.RabbitMQ((clientConfig, sinkConfig) => {
                    clientConfig.Hostnames = new List<string>() { Configuration["DistributedLog:RabbitMQ:Hostname"] };
                    clientConfig.Port = int.Parse(Configuration["DistributedLog:RabbitMQ:Port"]);
                    clientConfig.Username = Configuration["DistributedLog:RabbitMQ:Username"];
                    clientConfig.Password = Configuration["DistributedLog:RabbitMQ:Password"];
                    clientConfig.Exchange = Configuration["DistributedLog:RabbitMQ:Exchange"];
                    clientConfig.ExchangeType = Configuration["DistributedLog:RabbitMQ:ExchangeType"];
                    clientConfig.RouteKey = Configuration["DistributedLog:RabbitMQ:RoutingKey"];

                    // 自动创建交换机
                    clientConfig.AutoCreateExchange = true;
                    clientConfig.DeliveryMode = RabbitMQDeliveryMode.Durable;
                })
                .CreateLogger();


            // 2、使用Serilog
            builder.Host.UseSerilog();

            return builder;
        }
    }
}
