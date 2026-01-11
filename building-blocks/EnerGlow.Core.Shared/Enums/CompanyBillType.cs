using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 账单类型（0：退租单 1：月账单）
    /// </summary>
    public enum CompanyBillType
    {

        /// <summary>
        /// 退租单
        /// </summary>
        [Description("退租单")]
        Surrender = 0,

        /// <summary>
        /// 月账单
        /// </summary>
        [Description("月账单")]
        MonthlyBill = 1,
    }
}
