using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 能耗模型的设备应用类型(0:设备 1:进线)
    /// </summary>
    public enum EnergyModelDevUseType
    {

        /// <summary>
        /// 设备
        /// </summary>
        [Description("设备")]
        Device = 0,

        /// <summary>
        /// 进线
        /// </summary>
        [Description("进线")]
        Income = 1
    }
}
