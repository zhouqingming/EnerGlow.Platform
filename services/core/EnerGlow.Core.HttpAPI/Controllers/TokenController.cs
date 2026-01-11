using EnerGlow.Core.Application.Dtos;
using EnerGlow.Core.Application.Services;
using EnerGlow.Core.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using OpenIddict.Abstractions;
using OpenIddict.Server.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc;

namespace EnerGlow.Core.HttpAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TokenController : AbpController
    {
        /// <summary>
        /// UserInfoService
        /// </summary>
        public IUserInfoService UserInfoService { get; set; }

        [HttpPost("token")]
        public async Task<IActionResult> Exchange(LoginDto loginDto)
        {
           
              return await HandlePasswordGrantType(loginDto);
        }

        private async Task<IActionResult> HandlePasswordGrantType(LoginDto request)
        {
            //Console.WriteLine($"密码授权请求 - 用户名: {request.Username}, Scope: {request.Scope}");

            

            #region 2、自定义模块提供
            // 1、验证用户名
            var user =await UserInfoService.GetUserByUserNameAsync(request.UserName);
            if (user == null)
            {
                Console.WriteLine($"用户不存在: {request.UserName}");
                return Unauthorized(new { error = "invalid_username" });
            }
            // 2、验证用户密码
        
            if (user.Password == request.Password)
            {
                Console.WriteLine($"密码错误: {request.UserName}");
                return Unauthorized(new { error = "invalid_password" });
            }
            // 3、创建用户身份
            Console.WriteLine($"用户验证成功: {user.UserName}");
            var claimsPrincipal = await CreateClaimsPrincipalAsync(user, request.UserName);

            #endregion

            // 4、生成Token
            return SignIn(claimsPrincipal, OpenIddictServerAspNetCoreDefaults.AuthenticationScheme);
        }

        /// <summary>
        /// 创建身份 ClaimsPrincipal
        /// </summary>
        /// <param name="user"></param>
        /// <param name="scope"></param>
        /// <returns></returns>
        private async Task<ClaimsPrincipal> CreateClaimsPrincipalAsync(UserInfoDto user, string scope)
        {
            // 1、创建身份
            var identity = new ClaimsIdentity(OpenIddictServerAspNetCoreDefaults.AuthenticationScheme);

            // 2、创建声明
            identity.AddClaim(OpenIddictConstants.Claims.Subject, user.Id.ToString());
            identity.AddClaim(OpenIddictConstants.Claims.Username, user.UserName);
            identity.AddClaim(OpenIddictConstants.Claims.Scope, scope);

            // 添加电话
            if (!string.IsNullOrEmpty(user.Mobile))
            {
                identity.AddClaim(OpenIddictConstants.Claims.PhoneNumber, user.Mobile);
            }


            // 3、创建身份人
            var claimsPrincipal = new ClaimsPrincipal(identity);

            // 4、设置作用域
            var scopes = scope?.Split(' ');
            claimsPrincipal.SetScopes(scopes);

            // 5、关键：设置受众（资源）
            claimsPrincipal.SetResources("ProductService", "OrderService", "PaymentService", "SeckillService"); // 添加这行

            // 设置声明的目标（重要！）[方便再微服务中获取声明中的信息]
            foreach (var claim in claimsPrincipal.Claims)
            {
                claim.SetDestinations(GetDestinations(claim, claimsPrincipal));
            }

            return claimsPrincipal;
        }

        // 添加这个方法来确定声明应该出现在哪里
        private static IEnumerable<string> GetDestinations(Claim claim, ClaimsPrincipal principal)
        {
            switch (claim.Type)
            {
                case OpenIddictConstants.Claims.Name:
                case ClaimTypes.Name:
                    yield return OpenIddictConstants.Destinations.AccessToken;
                    if (principal.HasScope(OpenIddictConstants.Scopes.Profile))
                        yield return OpenIddictConstants.Destinations.IdentityToken;
                    break;

                case OpenIddictConstants.Claims.Email:
                case ClaimTypes.Email:
                    yield return OpenIddictConstants.Destinations.AccessToken;
                    if (principal.HasScope(OpenIddictConstants.Scopes.Email))
                        yield return OpenIddictConstants.Destinations.IdentityToken;
                    break;

                case OpenIddictConstants.Claims.Role:
                case ClaimTypes.Role:
                    yield return OpenIddictConstants.Destinations.AccessToken;
                    if (principal.HasScope(OpenIddictConstants.Scopes.Roles))
                        yield return OpenIddictConstants.Destinations.IdentityToken;
                    break;

                case OpenIddictConstants.Claims.Username:
                    yield return OpenIddictConstants.Destinations.AccessToken;
                    break;

                default:
                    yield return OpenIddictConstants.Destinations.AccessToken;
                    break;
            }
        }
    }
}
