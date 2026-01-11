using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 场景控制范围类型（1：区域  2：电器设备）
    /// </summary>
    public enum SceneScopeType
    {

        /// <summary>
        /// 区域
        /// </summary>
        [Description("区域")]
        Area = 1,

        /// <summary>
        /// 电器设备
        /// </summary>
        [Description("电器设备")]
        Equipement = 2

    }
}
