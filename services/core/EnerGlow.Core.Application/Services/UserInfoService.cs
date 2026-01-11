using EnerGlow.Core.Application.Dtos;
using EnerGlow.Core.Domain.Models;
using EnerGlow.Core.Domain.Repositorys;
using EnerGlow.Core.Shared;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace EnerGlow.Core.Application.Services
{
    [Dependency(ServiceLifetime.Singleton)]
    public class UserInfoService : CrudAppService<UserInfo, UserInfoDto, string>, IUserInfoService
    {
        public IUserInfoRepository userInfoRepository { get; set; }
        public UserInfoService(IUserInfoRepository repository) : base(repository)
        {
        }

        public async Task<UserInfoDto?> ActivateUserAsync(string id)
        {
           UserInfo userInfo=await userInfoRepository.GetByIdAsync(id);
            if(userInfo==null)
                return null;
            userInfo.Activate();
            await userInfoRepository.UpdateAsync(userInfo);
            return ObjectMapper.Map<UserInfo, UserInfoDto>(userInfo);
        }

        public async Task<bool> ChangePasswordAsync(string id, ChangePasswordDto changePasswordDto)
        {
            var user = await userInfoRepository.GetByIdAsync(id);
            if (user == null) return false;

            // 验证当前密码
            if (!changePasswordDto.Equals(changePasswordDto.CurrentPassword))
            {
                throw new ArgumentException("新旧密码不能一样");
            }

            // 设置新密码
            user.ChangePassword(changePasswordDto.NewPassword);

            // 保存到数据库
            await userInfoRepository.UpdateAsync(user);
            return true;
        }

        public async Task<UserInfoDto> CreateUserAsync(CreateUserDto createUserDto)
        {
            UserInfo userInfo=new UserInfo(
                createUserDto.userName,
                createUserDto.password,
                createUserDto.roleId,
                createUserDto.realName,
                createUserDto.email,
                createUserDto.mobile,
                createUserDto.departmentId,
                createUserDto.userId,
                createUserDto.source,
                createUserDto.unionId,createUserDto.isReceiveSms,createUserDto.headPortrait,createUserDto.isVoiceAlarm
                );
            UserInfo userInfo1=await userInfoRepository.InsertAsync(userInfo);
            return ObjectMapper.Map<UserInfo, UserInfoDto>(userInfo1);
        }

        public async Task<UserInfoDto?> DeactivateUserAsync(string id)
        {
            UserInfo userInfo = await userInfoRepository.GetByIdAsync(id);
            if (userInfo == null)
                return null;
            userInfo.Deactivate();
            await userInfoRepository.UpdateAsync(userInfo);
            return ObjectMapper.Map<UserInfo, UserInfoDto>(userInfo);
        }

        public async Task<bool> DeleteUserAsync(string id)
        {
            UserInfo userInfo = await userInfoRepository.GetByIdAsync(id);
            if (userInfo == null)
                return false;
            userInfo.Delete();
            await userInfoRepository.UpdateAsync(userInfo);
            return true;
        }

        public async Task<List<UserInfoDto>> GetAllUsersAsync()
        {
           List<UserInfo> userInfos= await userInfoRepository.GetAllAsync();
           return ObjectMapper.Map<List<UserInfo>, List<UserInfoDto>>(userInfos);
        }

        public async Task<(List<UserInfoDto> Users, int TotalCount)> GetPagedUsersAsync(UserQueryDto query)
        {
            (List<UserInfo> Users, int TotalCount)= await userInfoRepository.GetPagedAsync(query.PageIndex, query.PageSize);
            List<UserInfoDto> userInfoDtos= ObjectMapper.Map<List<UserInfo>, List<UserInfoDto>>(Users);
            return (userInfoDtos, TotalCount);
        }

        public async Task<UserInfoDto?> GetUserByIdAsync(string id)
        {
            UserInfo userInfo=await userInfoRepository.GetByIdAsync(id);
            if(userInfo==null)
                return null;
            return ObjectMapper.Map<UserInfo, UserInfoDto>(userInfo);
        }

        public async Task<UserInfoDto?> GetUserByUserNameAsync(string userName)
        {
            UserInfo userInfo = await userInfoRepository.GetByUserNameAsync(userName);
            if (userInfo == null)
                return null;
            return ObjectMapper.Map<UserInfo, UserInfoDto>(userInfo);
        }

        public async Task<List<UserInfoDto>> GetUsersByStatusAsync(StatusType status)
        {
            List<UserInfo> userInfos= await userInfoRepository.GetByStatusAsync(status);
            return ObjectMapper.Map<List<UserInfo>, List<UserInfoDto>>(userInfos);
        }

        public async Task<UserInfoDto?> LoginAsync(LoginDto loginDto)
        {
            var user = await userInfoRepository.GetByUserNameAsync(loginDto.UserName);
            if (user == null) return null;

          

            // 检查用户状态
            if (user.Status != StatusType.Enabled)
            {
                throw new InvalidOperationException("用户已被禁用，无法登录");
            }

            // 记录登录时间
            user.RecordLogin();
            await userInfoRepository.UpdateAsync(user);
            return ObjectMapper.Map<UserInfo, UserInfoDto>(user);
        }

        public async Task<UserInfoDto?> UpdateUserAsync(string id, UpdateUserDto updateUserDto)
        {
            UserInfo userInfo = await userInfoRepository.GetByIdAsync(id);
            if (userInfo == null)
                return null;
            userInfo.UpdateBasicInfo(
                updateUserDto.realName,
                updateUserDto.email,
                updateUserDto.mobile,
                updateUserDto.isReceiveSms,
                updateUserDto.isVoiceAlarm
                );
            await userInfoRepository.UpdateAsync(userInfo);
            return ObjectMapper.Map<UserInfo, UserInfoDto>(userInfo);

        }
    }
}
