using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 空调能效(Cop)等级(1:一级 2:二级 3:三级 9:待改进)
    /// </summary>
    public enum VrvCopRank
    {

        /// <summary>
        /// 一级
        /// </summary>
        [Description("一级")]
        First = 1,

        /// <summary>
        /// 二级
        /// </summary>
        [Description("二级")]
        Second = 2,

        /// <summary>
        /// 三级
        /// </summary>
        [Description("三级")]
        Third = 3,

        /// <summary>
        /// 待改进
        /// </summary>
        [Description("待改进")]
        WaitImprove = 9

    }
}
