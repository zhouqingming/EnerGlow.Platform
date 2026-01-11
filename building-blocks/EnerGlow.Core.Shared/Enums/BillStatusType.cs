using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 账单状态类型（1:运营审核 2:财务审核 3:财务退回 4:发送账单 5:本期未结清 6:逾期未结清 7:归档 8:作废 9:未发送账单）
    /// 此处加多一个特性来标志调用的方法名
    /// </summary>
    public enum BillStatusType
    {

        /// <summary>
        /// 运营审核
        /// </summary>
        //[Description("运营审核")]
        [Description("客户经理审核")]
        OperationalAudi = 1,

        /// <summary>
        /// 财务审核
        /// </summary>
        [Description("财务审核")]
        FinancialAudit = 2,

        /// <summary>
        /// 退回
        /// </summary>
        [Description("退回")]
        FinancialReturn = 3,

        /// <summary>
        /// 已发送账单
        /// </summary>
        [Description("发送账单")]
        HasSendBill = 4,

        /// <summary>
        /// 本期未结清
        /// </summary>
        [Description("本期未结清")]
        Unsettle = 5,

        /// <summary>
        /// 逾期未结清
        /// </summary>
        [Description("逾期未结清")]
        OverdueUnsettle = 6,

        /// <summary>
        /// 归档
        /// </summary>
        [Description("归档")]
        Archive = 7,

        /// <summary>
        /// 作废
        /// </summary>
        [Description("作废")]
        Invalid = 8,

        /// <summary>
        /// 未发送账单
        /// </summary>
        [Description("未发送账单")]
        HasNotSendBill = 9,

        /// <summary>
        /// 运营决策审核
        /// </summary>
        [Description("运营部长审核")]
        OperationalDecAudi = 10,

    }
}
