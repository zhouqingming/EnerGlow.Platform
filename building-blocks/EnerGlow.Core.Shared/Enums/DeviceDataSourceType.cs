using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 设备数据来源
    /// </summary>
    public enum DeviceDataSourceType
    {
        /// <summary>
        /// 区域中绑定的设备或统计标签
        /// </summary>
        [Description("区域中绑定的设备或统计标签")]
        AreaBoundDevice = 0,

        /// <summary>
        /// 新版本能耗模型绑定设备
        /// </summary>
        [Description("新版本能耗模型中绑定的设备或统计标签")]
        EnergyModelBoundDevice = 1,

    }
}
