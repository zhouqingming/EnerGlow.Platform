using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 电器设备控制应用类型（0：单点[手动]  1：时间表[自动]）
    /// </summary>
    public enum EquipmentCtrlUseType
    {

        /// <summary>
        /// 单点
        /// </summary>
        [Description("单点")]
        Single = 0,

        /// <summary>
        /// 时间表
        /// </summary>
        [Description("时间表")]
        Timer = 1

    }
}
