using EnerGlow.Core.Application.Dtos;
using EnerGlow.Core.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace EnerGlow.Core.Application.Services
{
    public interface IUserInfoService:ICrudAppService<UserInfoDto,string>
    {
        /// <summary>根据ID获取用户</summary>
        Task<UserInfoDto?> GetUserByIdAsync(string id);
        /// <summary>根据用户名获取用户</summary>
        Task<UserInfoDto?> GetUserByUserNameAsync(string userName);
        /// <summary>获取所有用户</summary>
        Task<List<UserInfoDto>> GetAllUsersAsync();
        /// <summary>根据状态获取用户</summary>
        Task<List<UserInfoDto>> GetUsersByStatusAsync(StatusType status);
        /// <summary>分页查询用户</summary>
        Task<(List<UserInfoDto> Users, int TotalCount)> GetPagedUsersAsync(UserQueryDto query);
        /// <summary>创建用户</summary>
        Task<UserInfoDto> CreateUserAsync(CreateUserDto createUserDto);
        /// <summary>更新用户</summary>
        Task<UserInfoDto?> UpdateUserAsync(string id, UpdateUserDto updateUserDto);
        /// <summary>删除用户</summary>
        Task<bool> DeleteUserAsync(string id);
        /// <summary>修改密码</summary>
        Task<bool> ChangePasswordAsync(string id, ChangePasswordDto changePasswordDto);
        /// <summary>用户登录</summary>
        Task<UserInfoDto?> LoginAsync(LoginDto loginDto);
        /// <summary>激活用户</summary>
        Task<UserInfoDto?> ActivateUserAsync(string id);
        /// <summary>禁用用户</summary>
        Task<UserInfoDto?> DeactivateUserAsync(string id);
    }
}
