using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnerGlow.Core.Shared
{
    public enum LevelEnum
    {
        [Description("不启用")]
        NoEnable =0,
        /// <summary>
        /// 设备故障
        /// </summary>
        [Description("设备故障")]
        DevFault =5,

        /// <summary>
        /// 设备报警
        /// </summary>
        [Description("设备报警")]
        DevAlarm =6,

        /// <summary>
        /// 模拟量报警
        /// </summary>
        [Description("模拟量报警")]
        AnalogQuantity =7,

        /// <summary>
        /// 通讯故障
        /// </summary>
        [Description("通讯故障")]
        ComFault =8,

        /// <summary>
        /// 操作事件
        /// </summary>
        [Description("操作事件")]
        OperateEvent =9,

        /// <summary>
        /// 普通变位
        /// </summary>
        [Description("普通变位")]
        Displacement =10
    }
}
