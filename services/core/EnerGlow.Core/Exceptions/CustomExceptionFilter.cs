using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Volo.Abp;
using Volo.Abp.DependencyInjection;

namespace EnerGlow.Core.Exceptions
{
    /// <summary>
    /// 1、自定义异常
    /// </summary>
    [Dependency(ReplaceServices=true)]
    public class CustomExceptionFilter : IAsyncExceptionFilter, ITransientDependency
    {
        public Task OnExceptionAsync(ExceptionContext context)
        {
            // 1、捕获异常
            if (context.Exception is UserFriendlyException)
            {
                context.Result = new ObjectResult(new
                {
                    code = "1", // 自定义错误代码
                    message = context.Exception.Message,
                    details = context.Exception.StackTrace.ToString()
                })
                {
                    StatusCode = StatusCodes.Status500InternalServerError
                };

                // 2、标记已处理
                context.ExceptionHandled = true; // 标记异常已处理
            }

            return Task.CompletedTask;  
        }
    }
}
