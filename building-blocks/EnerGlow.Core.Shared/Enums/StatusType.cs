using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 状态类型(0:启用  1:停用   2:删除)
    /// </summary>
    public enum StatusType
    {
        /// <summary>
        /// 启用
        /// </summary>
        [Description("启用")]
        Enabled = 0,

        /// <summary>
        /// 停用
        /// </summary>
        [Description("停用")]
        Disable = 1,

        /// <summary>
        /// 删除
        /// </summary>
        [Description("删除")]
        Deleted = 2,

        /// <summary>
        /// 隐藏
        /// </summary>
        [Description("隐藏")]
        Hided = 3,
    }
}
