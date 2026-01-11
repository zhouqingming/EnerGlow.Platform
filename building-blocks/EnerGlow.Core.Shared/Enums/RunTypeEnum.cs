using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 运行状态
    /// </summary>
    public enum RunTypeEnum
    {
        /// <summary>
        /// 停止
        /// </summary>
        [Description("停止")]
        Stop = 0,

        /// <summary>
        /// 启动
        /// </summary>
        [Description("启动")]
        Start = 1,
    }
}
