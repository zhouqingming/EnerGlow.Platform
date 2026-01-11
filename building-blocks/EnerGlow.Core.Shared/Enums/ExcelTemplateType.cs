using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{
    public enum ExcelTemplateType
    {
        /// <summary>
        /// 广本能耗模型Excel模板
        /// </summary>
        [Description("广本能耗模型模板")]
        EnergyConsumptionTemplate = 0,

        /// <summary>
        /// 广本巡检工单配置模板
        /// </summary>
        [Description("广本巡检工单配置模板")]
        PatrolUpKeepConfigTemplate = 1,

        /// <summary>
        /// 广本巡检工单报表模板
        /// </summary>
        [Description("广本巡检工单报表模板")]
        PatrolUpKeepTemplate = 2,
    }
}
