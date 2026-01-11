using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Core.Enums.Base
{
    public enum PowerKindEnum
    {
        /// <summary>
        /// 直流-12V
        /// </summary>
        [Description("直流-12V")]
        直流12V = 1,
        /// <summary>
        /// 直流-24V
        /// </summary>
        [Description("直流-24V")]
        直流24V = 2,
        /// <summary>
        /// 直流-36V
        /// </summary>
        [Description("直流-36V")]
        直流36V = 3,
        /// <summary>
        /// 直流-220V
        /// </summary>
        [Description("直流-220V")]
        直流220V = 4,
        /// <summary>
        /// 交流-220V
        /// </summary>
        [Description("交流-380V")]
        交流220V = 5,
        /// <summary>
        /// 交流-380V
        /// </summary>
        [Description("交流-380V")]
        交流380V = 6,
        /// <summary>
        /// 交流-10000V
        /// </summary>
        [Description("交流-10000V")]
        交流10000V = 7,
        /// <summary>
        /// 交流-35000V
        /// </summary>
        [Description("交流-35000V")]
        交流35000V = 8,
    }
}
