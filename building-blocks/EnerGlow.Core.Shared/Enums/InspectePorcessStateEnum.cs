using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 巡检单处理状态
    /// </summary>
    public enum InspectePorcessStateEnum
    {
        /// <summary>
        /// 待处理
        /// </summary>
        [Description("待处理")]
        StayPorcess = 1,
        /// <summary>
        /// 处理中
        /// </summary>
        [Description("处理中")]
        InPorcess = 2,
        /// <summary>
        /// 已处理
        /// </summary>
        [Description("已处理")]
        AlreadyPorcess = 3,
        /// <summary>
        /// 已回收
        /// </summary>
        [Description("已回收")]
        AlreadyRecovery = 4

    }
}
