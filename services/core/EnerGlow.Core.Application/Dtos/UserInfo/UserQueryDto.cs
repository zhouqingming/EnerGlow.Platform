using EnerGlow.Core.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnerGlow.Core.Application.Dtos
{
    public class UserQueryDto
    {
        /// <summary>页码</summary>
        public int PageIndex { get; set; } = 1;
        /// <summary>每页大小</summary>
        public int PageSize { get; set; } = 10;
        /// <summary>用户状态</summary>
        public StatusType? Status { get; set; }
        /// <summary>搜索关键词</summary>
        public string? SearchTerm { get; set; }
    }
}
