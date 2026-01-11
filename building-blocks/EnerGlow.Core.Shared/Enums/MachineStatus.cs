using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 电器状态(0:启用  1:停用)
    /// </summary>
    public enum MachineStatus
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
        Disable = 1

    }
}
