using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 报表绑定标签类型(0：设备  1：测点)
    /// </summary>
    public enum ReportTagType
    {
        /// <summary>
        /// 设备
        /// </summary>
        [Description("设备")]
        Device = 0,

        /// <summary>
        /// 测点
        /// </summary>
        [Description("测点")]
        Point = 1
    }
}
