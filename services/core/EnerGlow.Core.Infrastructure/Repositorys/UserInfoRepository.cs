using EnerGlow.Core.Domain.Models;
using EnerGlow.Core.Domain.Repositorys;
using EnerGlow.Core.Infrastructure.Contexts;
using EnerGlow.Core.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace EnerGlow.Core.Infrastructure.Repositorys
{
    [Dependency(ServiceLifetime.Singleton)]
    public class UserInfoRepository : EfCoreRepository<CoreContext, UserInfo, string>, IUserInfoRepository
    {
        public CoreContext coreContext { get; set; }
        public UserInfoRepository(IDbContextProvider<CoreContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<List<UserInfo>> GetAllAsync()
        {
            return await coreContext.userInfos.ToListAsync();
        }

        public async Task<UserInfo?> GetByIdAsync(string id)
        {
           return await coreContext.userInfos.FindAsync(id);
        }

        public async Task<UserInfo?> GetByPhoneAsync(string phone)
        {
          return await  coreContext.userInfos.FirstOrDefaultAsync(u => u.Mobile == phone);
        }

        public Task<List<UserInfo>> GetByStatusAsync(StatusType status)
        {
           return coreContext.userInfos.Where(u => u.Status == status).ToListAsync();
        }

        public async Task<UserInfo?> GetByUserNameAsync(string userName)
        {
            return await coreContext.userInfos.FirstOrDefaultAsync(u => u.UserName == userName);
        }

        public async Task<(List<UserInfo> Users, int TotalCount)> GetPagedAsync(int pageIndex, int pageSize)
        {
            var query = coreContext.userInfos
              .OrderBy(u => u.CreateTime);

            var totalCount = await query.CountAsync();
            var users = await query
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .AsNoTracking() // 只读查询，不跟踪变更
                .ToListAsync();

            return (users, totalCount);
        }

        public async Task<bool> PhoneExistsAsync(string phone)
        {
            return await coreContext.userInfos.AnyAsync(u => u.Mobile == phone);
        }

        public async Task<bool> UserNameExistsAsync(string userName)
        {
            return await coreContext.userInfos.AnyAsync(u => u.UserName == userName);
        }

       
    }
}
