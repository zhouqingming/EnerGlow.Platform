using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 首页模块类型
    /// (0: 3D模型模块  1:能耗KPI模块  2:用电量模块  3:报警模块)
    /// </summary>
    public enum HomePageModuleType
    {
        /// <summary>
        /// 3D模型模块
        /// </summary>
        [Description("3D模型模块")]
        ThreeDModel = 0,

        /// <summary>
        /// 能耗KPI模块
        /// </summary>
        [Description("能耗KPI模块")]
        EnergyKpi = 1,

        /// <summary>
        /// 用电量模块
        /// </summary>
        [Description("用电量模块")]
        KwhModule = 2,

        /// <summary>
        /// 报警模块
        /// </summary>
        [Description("报警模块")]
        AlarmModule = 3,

    }
}
