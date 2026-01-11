using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 空调总览看板模块类型
    /// 1:概况 2:各机房等级(当天) 3:各机房能效数据 4:每月节能数据
    /// </summary>
    public enum VrvAllBoardModuleType
    {

        /// <summary>
        /// 概况数据
        /// </summary>
        [Description("概况")]
        Overview = 1,

        /// <summary>
        /// 各机房等级(当天)
        /// </summary>
        [Description("各机房等级")]
        AreaRank = 2,

        /// <summary>
        /// 各机房能效数据
        /// </summary>
        [Description("各机房能效数据")]
        AreaCopData = 3,

        /// <summary>
        /// 每月节能数据
        /// </summary>
        [Description("每月节能数据")]
        MonthSpare = 4,

        /// <summary>
        /// 即时制冷量之和
        /// </summary>
        [Description("即时制冷量")]
        CoolCapacityPoint = 5
    }
}
