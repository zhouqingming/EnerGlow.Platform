using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnerGlow.Core.Application.Dtos
{
    public class LoginDto
    {
        /// <summary>用户名</summary>
        public string UserName { get; set; } = string.Empty;
        /// <summary>密码</summary>
        public string Password { get; set; } = string.Empty;
    }
}
