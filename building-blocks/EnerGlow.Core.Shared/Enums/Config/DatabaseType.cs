using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 数据库类型(1:关系库   2:实时库)
    /// </summary>
    public enum DatabaseType
    {
        /// <summary>
        /// 关系库
        /// </summary>
        [Description("关系库")]
        Relation = 1,

        /// <summary>
        /// 实时库
        /// </summary>
        [Description("实时库")]
        RealTime = 2
    }
}
