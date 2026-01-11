using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    ///  峰平谷
    /// </summary>
    public enum PeakFlatValley
    {
        /// <summary>
        /// 尖峰
        /// </summary>
        [Description("尖峰")]
        TopPeak = 0,

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
