using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 用户来源（0：系统用户    1：注册用户   2：创建用户）
    /// </summary>
    public enum UserSourceType
    {
        /// <summary>
        /// 系统用户
        /// </summary>
        [Description("系统用户")]
        System = 0,

        /// <summary>
        /// 注册用户
        /// </summary>
        [Description("注册用户")]
        Register = 1,

        /// <summary>
        /// 创建用户
        /// </summary>
        [Description("创建用户")]
        Create = 2
    }
}
