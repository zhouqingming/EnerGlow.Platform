using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;

namespace EnerGlow.Core.Infrastructure.Contexts
{
    /// <summary>
    /// 动态连接字符串解析
    /// </summary>
    [Dependency(ReplaceServices = true)]
    public class CoreConnectionStringResolver : IConnectionStringResolver, ITransientDependency
    {
        /// <summary>
        ///  连接字符串的配置选项
        /// </summary>
        protected AbpDbConnectionOptions Options { get; }

        /// <summary>
        ///  环境变量接口
        /// </summary>
        public IHostEnvironment Environment { get; set; }

        /// <summary>
        /// 请求上下文 执行器依赖
        /// </summary>
        public IHttpContextAccessor HttpContextAccessor { get; set; }

        public CoreConnectionStringResolver(
            IOptionsMonitor<AbpDbConnectionOptions> options)
        {
            Options = options.CurrentValue;
        }

        public string Resolve(string? connectionStringName = null)
        {
            string conStr= HttpContextAccessor.HttpContext.Request.Headers["conStr"];
            if(string.IsNullOrEmpty(conStr))
            {
                conStr = connectionStringName;
            }
            string connectionString = Options.ConnectionStrings.GetOrDefault(conStr);
            if (string.IsNullOrEmpty(connectionString))
            {
                connectionString = Options.ConnectionStrings.GetOrDefault("Default");
            }
            return connectionString;
        }

        public Task<string> ResolveAsync(string? connectionStringName = null)
        {
            return Task.FromResult(Resolve(connectionStringName));
        }
    }
}
