using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared.Pro
{
    /// <summary>
    /// 峰平谷 1峰2平3谷
    /// </summary>
    public enum EnergyTypeEnum
    {

        /// <summary>
        /// 峰
        /// </summary>
        [Description("峰")]
        Peak = 1,
        /// <summary>
        /// 平
        /// </summary>
        [Description("平")]
        Flat = 2,
        /// <summary>
        /// 谷
        /// </summary>
        [Description("谷")]
        Valley = 3
    }
}
