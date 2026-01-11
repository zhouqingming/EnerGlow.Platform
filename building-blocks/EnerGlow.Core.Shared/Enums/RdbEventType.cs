using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 实时库越限事件类型
    /// </summary>
    public enum RdbEventType
    {
        /// <summary>
        /// 低低限报警产生
        /// </summary>
        [Description("低低限报警产生")]
        AlarmllvSet = 11,

        /// <summary>
        /// 低低限报警恢复
        /// </summary>
        [Description("低低限报警恢复")]
        AlarmllvRestore = 10,

        /// <summary>
        /// 低限报警产生
        /// </summary>
        [Description("低限报警产生")]
        AlarmlvSet = 21,

        /// <summary>
        /// 低限报警恢复
        /// </summary>
        [Description("低限报警恢复")]
        AlarmlvRestore = 20,

        /// <summary>
        /// 高限报警产生
        /// </summary>
        [Description("高限报警产生")]
        AlarmhvSet = 31,

        /// <summary>
        /// 高限报警恢复
        /// </summary>
        [Description("高限报警恢复")]
        AlarmhvRestore = 30,


        /// <summary>
        /// 高高限报警产生
        /// </summary>
        [Description("高高限报警产生")]
        AlarmhhvSet = 41,

        /// <summary>
        /// 高高限报警恢复
        /// </summary>
        [Description("高高限报警恢复")]
        AlarmhhvRestore = 40,






    }
}
