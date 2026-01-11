using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 区域场景状态(0:关闭  1:开启)
    /// </summary>
    public enum SceneStatus
    {

        /// <summary>
        /// 关闭
        /// </summary>
        [Description("关闭")]
        Close = 0,

        /// <summary>
        /// 开启
        /// </summary>
        [Description("开启")]
        Open = 1
    }
}
