using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared.ACS
{
    /// <summary>
    /// ACS门禁 门状态枚举
    /// </summary>
    public enum DoorStatusType
    {
        /// <summary>
        /// 关门
        /// </summary>
        [Description("关门")]
        Close = 0,

        /// <summary>
        /// 开门
        /// </summary>
        [Description("开门")]
        Open = 1,

        /// <summary>
        /// 常开
        /// </summary>
        [Description("常开")]
        AlwaysOpen = 2,

        /// <summary>
        /// 常闭
        /// </summary>
        [Description("常闭")]
        AlwaysClose = 3,

        /// <summary>
        /// 恢复(恢复为普通状态)
        /// </summary>
        [Description("恢复")]
        Recover = 4

    }
}
