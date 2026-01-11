using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 存档方式（1：手动 2：自动）
    /// </summary>
    public enum ArchivingModeType
    {

        /// <summary>
        /// 手动
        /// </summary>
        [Description("手动")]
        Manual = 1,

        /// <summary>
        /// 自动
        /// </summary>
        [Description("自动")]
        Auto = 2

    }
}
