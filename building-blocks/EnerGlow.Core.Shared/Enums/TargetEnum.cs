using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 指标枚举
    /// </summary>
    public enum TargetEnum
    {
        /// <summary>
        /// 车站单位建筑面积电耗
        /// </summary>
        [Description("车站单位建筑面积电耗")]
        CarUnitAreaEnergy = 1,

        /// <summary>
        /// 车站每万人次电耗
        /// </summary>
        [Description("车站每万人次电耗")]
        CarPeoPleEnergy = 2,

        /// <summary>
        /// 车站照明系统每平方米电耗
        /// </summary>
        [Description("车站照明系统每平方米电耗")]
        CarLightSquareMeter = 3,

        /// <summary>
        /// 车站通风与空调系统每平方米电耗
        /// </summary>
        [Description("车站通风与空调系统每平方米电耗")]
        CarAirSquareMeter = 4,

        /// <summary>
        /// 车站通风与空调系统每万人次电耗
        /// </summary>
        [Description("车站通风与空调系统每万人次电耗")]
        CarAirPeoPleEnergy = 5,

        /// <summary>
        /// 车站其他系统每平方米电耗
        /// </summary>
        [Description("车站其他系统每平方米电耗")]
        CarOtherEnergy = 6,
    }
}
