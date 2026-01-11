using EnerGlow.Core.Application.Dtos;
using EnerGlow.Core.Application.Services;
using EnerGlow.Core.Domain.Models;
using EnerGlow.Core.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc;

namespace EnerGlow.Core.HttpAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : AbpController
    {
        public IUserInfoService UserInfoService { get; set; }

        [HttpGet]
        [Description("获取用户列表接口")]
        public List<UserInfoDto> List(string searchUserName, string searchRealName, string searchRoleId, StatusType? searchStatus,
          int pageIndex = 1, int pageSize = int.MaxValue)
        {

            return null;
        }
    }
}
