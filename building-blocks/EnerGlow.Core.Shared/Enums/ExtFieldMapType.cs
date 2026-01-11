using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 扩展字段表名映射(1: componet_info 2：cabinet_info 3：elec_dev)
    /// 1: 元器件 2：电柜 3：电力设备
    /// </summary>
    public enum ExtFieldMapType
    {

        /// <summary>
        /// 元器件(componet_info)
        /// </summary>
        [Description("componet_info")]
        Componet = 1,

        /// <summary>
        /// 电柜(cabinet_info)
        /// </summary>
        [Description("cabinet_info")]
        Cabinet = 2,

        /// <summary>
        /// 电力设备(elec_dev)
        /// </summary>
        [Description("elec_dev")]
        ElecDev = 3

    }
}
