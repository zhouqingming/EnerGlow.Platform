using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 星期（0：每天 1：星期一 2：星期二 3：星期三 4：星期四 5：星期五 6：星期六 7：星期七）
    /// </summary>
    public enum WeekType
    {

        /// <summary>
        /// 每天
        /// </summary>
        [Description("每天")]
        Everyday = 0,

        /// <summary>
        /// 星期一
        /// </summary>
        [Description("星期一")]
        Mon = 1,

        /// <summary>
        /// 星期二
        /// </summary>
        [Description("星期二")]
        Tue = 2,

        /// <summary>
        /// 星期三
        /// </summary>
        [Description("星期三")]
        Wed = 3,

        /// <summary>
        /// 星期四
        /// </summary>
        [Description("星期四")]
        Thu = 4,

        /// <summary>
        /// 星期五
        /// </summary>
        [Description("星期五")]
        Fri = 5,

        /// <summary>
        /// 星期六
        /// </summary>
        [Description("星期六")]
        Sat = 6,

        /// <summary>
        /// 星期日
        /// </summary>
        [Description("星期日")]
        Sun = 7

    }
}
