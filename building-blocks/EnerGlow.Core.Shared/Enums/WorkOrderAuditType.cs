using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 审核类型(0:手动审核 1:系统审核)
    /// </summary>
    public enum WorkOrderAuditType
    {

        /// <summary>
        /// 手动审核
        /// </summary>
        [Description("手动审核")]
        Manual = 0,

        /// <summary>
        /// 系统审核
        /// </summary>
        [Description("系统审核")]
        System = 1

    }
}
