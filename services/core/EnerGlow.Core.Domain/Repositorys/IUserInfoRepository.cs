using EnerGlow.Core.Domain.Models;
using EnerGlow.Core.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace EnerGlow.Core.Domain.Repositorys
{
    public interface IUserInfoRepository : IRepository<UserInfo, string>
    {
        /// <summary>根据ID获取用户</summary>
        Task<UserInfo?> GetByIdAsync(string id);
        /// <summary>根据用户名获取用户</summary>
        Task<UserInfo?> GetByUserNameAsync(string userName);
        /// <summary>根据手机号获取用户</summary>
        Task<UserInfo?> GetByPhoneAsync(string phone);
        /// <summary>获取所有用户</summary>
        Task<List<UserInfo>> GetAllAsync();
        /// <summary>根据状态获取用户</summary>
        Task<List<UserInfo>> GetByStatusAsync(StatusType status);
        /// <summary>分页获取用户</summary>
        Task<(List<UserInfo> Users, int TotalCount)> GetPagedAsync(int pageIndex, int pageSize);
        /// <summary>检查用户名是否存在</summary>
        Task<bool> UserNameExistsAsync(string userName);
        /// <summary>检查手机号是否存在</summary>
        Task<bool> PhoneExistsAsync(string phone);
    }
}
