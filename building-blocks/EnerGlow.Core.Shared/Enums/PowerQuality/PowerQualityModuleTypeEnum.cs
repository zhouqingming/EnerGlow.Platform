using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 电能质量模块类型
    /// (1:本日每小时电流  2:本日每小时电压 3:本日每小时功率因数)
    /// </summary>
    public enum PowerQualityModuleTypeEnum
    {
        /// <summary>
        /// 电流
        /// </summary>
        [Description("电流")]
        PowerQualityI = 1,

        /// <summary>
        /// 电压
        /// </summary>
        [Description("电压")]
        PowerQualityU = 2, 
        /// <summary>
        /// 功率因数
        /// </summary>
        [Description("功率因数")]
        PowerQualityPF = 3,
        /// <summary>
        /// 总谐波畸变率
        /// </summary>
        [Description("总谐波畸变率")]
        PowerQualityTHD = 4,
        /// <summary>
        /// 电压-奇次谐波畸变率
        /// </summary>
        [Description("电压-奇次谐波畸变率")]
        PowerQualityHwUa = 5, 
        /// <summary>
        /// 电流-奇次谐波畸变率
        /// </summary>
        [Description("电流-奇次谐波畸变率")]
        PowerQualityHwIa = 6,
        /// <summary>
        /// 电能质量综合报告
        /// </summary>
        [Description("电能质量综合报告")]
        PowerQualityReport= 7,
        /// <summary>
        /// 相位偏差
        /// </summary>
        [Description("相位偏差")]
        PhaseDeviation =8,
    }
}
