using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 设备控制操作类型（1:读数 2:设置 3:读写）
    /// </summary>
    public enum EquipmentCtrlOperateType
    {

        /// <summary>
        /// 读数
        /// </summary>
        [Description("读数")]
        Read = 1,

        /// <summary>
        /// 设置
        /// </summary>
        [Description("设置")]
        Set = 2,

        /// <summary>
        /// 读写
        /// </summary>
        [Description("读写")]
        ReadAndSet = 3

    }
}
