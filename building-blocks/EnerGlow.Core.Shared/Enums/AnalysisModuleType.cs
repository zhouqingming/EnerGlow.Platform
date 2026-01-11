using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 分析模块类型(0:电能质量  1:中央空调  2:负荷预测)
    /// </summary>
    public enum AnalysisModuleType
    {
        /// <summary>
        /// 电能质量
        /// </summary>
        [Description("电能质量")]
        PowerQuality = 0,

        /// <summary>
        /// 中央空调
        /// </summary>
        [Description("中央空调")]
        AirConditioner = 1,

        /// <summary>
        /// 负荷预测
        /// </summary>
        [Description("负荷预测")]
        LoadPrediction = 2,
    }
}
