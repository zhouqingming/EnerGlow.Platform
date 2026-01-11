using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 工单对象类型(0: 区域 1：电房 2：设备类型 3：设备)
    /// </summary>
    public enum WorkOrderTargetType
    {

        /// <summary>
        /// 区域
        /// </summary>
        [Description("区域")]
        Area = 0,

        /// <summary>
        /// 电房
        /// </summary>
        [Description("电房")]
        ElecRoom = 1,

        /// <summary>
        /// 设备类型
        /// </summary>
        [Description("设备类型")]
        DeviceType = 2,

        /// <summary>
        /// 设备
        /// </summary>
        [Description("设备")]
        Device = 3
    }
}
