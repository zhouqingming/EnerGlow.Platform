using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared.ACS
{
    public enum AcsUserType
    {
        /// <summary>
        /// 普通人（主人）
        /// </summary>
        [Description("normal")]
        Normal = 0,

        /// <summary>
        /// 访客
        /// </summary>
        [Description("visitor")]
        Visitor = 1,

        /// <summary>
        /// 黑名单列表
        /// </summary>
        [Description("blackList")]
        BlackList = 2,
    }
}
