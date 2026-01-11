using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 巡检/保养工单生成类型(0: 计划生成 1：人工下发 2:点检上报)
    /// </summary>
    public enum PatrolUpkeepOrderCreateType
    {

        /// <summary>
        /// 计划生成
        /// </summary>
        [Description("计划生成")]
        Plan = 0,

        /// <summary>
        /// 人工下发
        /// </summary>
        [Description("人工下发")]
        Manual = 1,

        /// <summary>
        /// 点检上报
        /// </summary>
        [Description("点检上报")]
        SpotCheck = 2,

        /// <summary>
        /// 审核退回
        /// </summary>
        [Description("审核退回")]
        AuditBack = 3

    }
}
