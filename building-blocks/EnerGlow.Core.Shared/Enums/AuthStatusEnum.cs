using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnerGlow.Core.Shared
{
    public enum AuthStatusEnum
    {
        /// <summary>
        /// 申请授权
        /// </summary>
        [Description("申请授权")]
        Pending = 0,

        /// <summary>
        /// 授权过期
        /// </summary>
        [Description("授权过期")]
        Unauthorized=1,

        /// <summary>
        /// 已授权
        /// </summary>
        [Description("已授权")]
        Authorized=2,

        /// <summary>
        /// 拒绝授权
        /// </summary>
        [Description("拒绝授权")]
        Rejected = 3,
    }
}
