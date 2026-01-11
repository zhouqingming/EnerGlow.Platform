using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnerGlow.Core.Shared
{
    public enum SmsAlarmItem
    {
        /// <summary>
        /// 参数告警
        /// </summary>
        [Description("参数告警")]
        Argument = 1,

        /// <summary>
        /// 指标告警
        /// </summary>
        [Description("指标告警")]
        Index = 2,

        /// <summary>
        /// 表达式告警
        /// </summary>
        [Description("表达式告警")]
        Expression = 3,

        /// <summary>
        /// SOE告警
        /// </summary>
        [Description("SOE告警")]
        Soe = 4,
    }
}
