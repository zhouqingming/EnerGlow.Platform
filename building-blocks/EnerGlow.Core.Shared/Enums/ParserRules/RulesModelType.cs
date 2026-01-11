using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnerGlow.Core.Shared.ParserRules
{
    public enum RulesModelType
    {
        /// <summary>
        /// 实时值分析
        /// </summary>
        [Description("实时值分析")]
        RealTimeValueAnalysis = 0,

        /// <summary>
        /// 阶段值分析
        /// </summary>
        [Description("阶段值分析")]
        StageValueAnalysis = 1,

    }
}
