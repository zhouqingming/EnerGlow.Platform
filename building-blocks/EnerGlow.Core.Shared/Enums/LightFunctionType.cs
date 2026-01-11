using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 灯光控制功能类型（1：开关状态  2：亮度读取  3：亮度设定）
    /// </summary>
    public enum LightFunctionType
    {

        /// <summary>
        /// 开关状态读取
        /// </summary>
        [Description("开关状态读取")]
        SwitchStatusGet = 0,

        /// <summary>
        /// 开关状态设定
        /// </summary>
        [Description("开关状态设定")]
        SwitchStatusSet = 1,

        /// <summary>
        /// 亮度读取
        /// </summary>
        [Description("亮度读取")]
        LuminanceGet = 2,

        /// <summary>
        /// 亮度设定
        /// </summary>
        [Description("亮度设定")]
        LuminanceSet = 3

    }
}
