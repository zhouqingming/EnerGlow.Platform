using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 运维信息
    /// </summary>
   public enum DevOpsEnum
    {
        /// <summary>
        /// 设备信息
        /// </summary>
        [Description("设备信息")]
        DeviceInfo=1,
        /// <summary>
        /// 维保信息
        /// </summary>
        [Description("维保记录")]
        Maintenance=2,
        /// <summary>
        /// 元器件信息
        /// </summary>
        [Description("元器件信息")]
        Compon = 3,
        /// <summary>
        /// 报警记录
        /// </summary>
        [Description("报警记录")]
        Alarm =4,

    }
}
