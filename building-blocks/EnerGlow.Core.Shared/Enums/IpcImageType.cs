using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 图片类型（0: 普通图  1: 热力图）
    /// </summary>
    public enum IpcImageType
    {

        /// <summary>
        /// 普通图
        /// </summary>
        [Description("普通图")]
        Normal = 0,

        /// <summary>
        /// 热力图
        /// </summary>
        [Description("热力图")]
        Thermodynamic = 1

    }
}
