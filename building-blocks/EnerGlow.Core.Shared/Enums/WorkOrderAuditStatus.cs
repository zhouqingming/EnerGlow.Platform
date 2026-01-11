using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 工单审核状态(0:未审核 1:未通过 2: 通过)
    /// </summary>
    public enum WorkOrderAuditStatus
    {

        /// <summary>
        /// 未审核
        /// </summary>
        [Description("未审核")]
        Wait = 0,

        /// <summary>
        /// 未通过
        /// </summary>
        [Description("未通过")]
        Fail = 1,

        /// <summary>
        /// 通过
        /// </summary>
        [Description("通过")]
        Pass = 2

    }
}
