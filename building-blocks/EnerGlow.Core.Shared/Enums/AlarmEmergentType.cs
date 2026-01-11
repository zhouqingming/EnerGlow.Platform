using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 报警/应急类型(0: 报警  1：应急)
    /// </summary>
    public enum AlarmEmergentType
    {

        /// <summary>
        /// 报警
        /// </summary>
        [Description("报警")]
        Alarm = 0,

        /// <summary>
        /// 应急
        /// </summary>
        [Description("应急")]
        Emergent = 1,
    }
}
