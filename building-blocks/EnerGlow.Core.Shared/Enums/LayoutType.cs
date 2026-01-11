using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 布局类型（0：横向 1：纵向）
    /// </summary>
    public enum LayoutType
    {

        /// <summary>
        /// 横向
        /// </summary>
        [Description("横向")]
        Horizontal = 0,

        /// <summary>
        /// 纵向
        /// </summary>
        [Description("纵向")]
        Vertical = 1

    }
}
