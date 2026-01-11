using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 电柜回路类型(0:进线 1:出线)
    /// </summary>
    public enum CabinetLoopType
    {

        /// <summary>
        /// 进线
        /// </summary>
        [Description("进线")]
        Income = 0,

        /// <summary>
        /// 出线
        /// </summary>
        [Description("出线")]
        Outlet = 1

    }
}
