using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    ///  类型 1分段2不分段
    /// </summary>
    public enum EnergykindTypeEnum
    {

        /// <summary>
        /// 分段
        /// </summary>
        [Description("分段")]
        Subsection = 1,

        /// <summary>
        /// 不分段
        /// </summary>
        [Description("不分段")]
        NoSubsection = 2
    }
}
