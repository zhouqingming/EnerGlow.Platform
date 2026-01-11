using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 配置设备类型（1：进线  2：看板电参量）
    /// </summary>
    public enum ConfigDevType
    {

        /// <summary>
        /// 进线
        /// </summary>
        [Description("进线")]
        Income = 1,

        /// <summary>
        /// 看板电参量
        /// </summary>
        [Description("看板电参量")]
        BoardElecParam = 2

    }
}
