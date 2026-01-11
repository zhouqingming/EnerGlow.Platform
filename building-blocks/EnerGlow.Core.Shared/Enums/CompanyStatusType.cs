using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 公司状态类型（0：合同期 1：合同到期 2：中途退租）
    /// </summary>
    public enum CompanyStatusType
    {

        /// <summary>
        /// 合同期
        /// </summary>
        [Description("合同期")]
        Contract = 0,

        /// <summary>
        /// 合同到期
        /// </summary>
        [Description("合同到期")]
        NonContract = 1,

        /// <summary>
        /// 中途退租
        /// </summary>
        [Description("中途退租")]
        BreachContract = 2,
    }
}
