using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 分析方法(0:标准  1:越限  2:关联分析  3:聚类分析)
    /// </summary>
    public enum AnalysisWay
    {

        /// <summary>
        /// 标准
        /// </summary>
        [Description("标准")]
        Standard = 0,

        /// <summary>
        /// 越限
        /// </summary>
        [Description("越限")]
        OutLimit = 0,

        /// <summary>
        /// 关联分析
        /// </summary>
        [Description("关联分析")]
        Correlation = 0,

        /// <summary>
        /// 聚类分析
        /// </summary>
        [Description("聚类分析")]
        Cluster = 0,
    }
}
