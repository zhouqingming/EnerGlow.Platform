using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 区域页面类型（0：能源看板  1：单线图  2：鸟瞰图
    /// </summary>
    public enum AreaWebType
    {
        /// <summary>
        /// 能源看板
        /// </summary>
        [Description("能源看板")]
        Board = 0,

        /// <summary>
        /// 单线图
        /// </summary>
        [Description("单线图")]
        SingleDiagram = 1,

        /// <summary>
        /// 鸟瞰图
        /// </summary>
        [Description("鸟瞰图")]
        AerialView = 2,

        /// <summary>
        /// 环控图
        /// </summary>
        [Description("环控图")]
        Mcc = 3
    }
}
