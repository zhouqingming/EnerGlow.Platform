using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 电器设备类型（1：灯光  2：空调）
    /// </summary>
    public enum EquipementType
    {

        /// <summary>
        /// 灯光
        /// </summary>
        [Description("灯光")]
        Light = 1,

        /// <summary>
        /// 空调
        /// </summary>
        [Description("空调")]
        AirCondition = 2,

        /// <summary>
        /// 风机
        /// </summary>
        [Description("风机")]
        Blower = 3,

        /// <summary>
        /// 窗帘
        /// </summary>
        [Description("窗帘")]
        Curtain = 4
    }
}
