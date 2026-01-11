using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 设备类型（1:能源设备   2:环境设备  3:监控设备 4:其他
    /// </summary>
    public enum DevType
    {
        /// <summary>
        /// 能源设备
        /// </summary>
        [Description("能源设备")]
        Energy = 1,

        /// <summary>
        /// 环境设备
        /// </summary>
        [Description("环境设备")]
        Environment = 2,

        /// <summary>
        /// 监控设备
        /// </summary>
        [Description("监控设备")]
        Monitoring = 3,

        /// <summary>
        /// 其他
        /// </summary>
        [Description("其他")]
        Other = 4,
    }
}
