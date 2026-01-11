using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 空调控制功能类型（1:温度读取 2:温度设定 3:模式读取 4:模式设定 5:风速读取 6:风速设定 7:最低温度读取 8:最低温度设定 9:最高温度读取 10:最高温度设定）
    /// </summary>
    public enum AirConditionFunctionType
    {

        /// <summary>
        /// 温度读取
        /// </summary>
        [Description("温度读取")]
        TempGet = 1,

        /// <summary>
        /// 温度设定
        /// </summary>
        [Description("温度设定")]
        TempSet = 2,

        /// <summary>
        /// 模式读取
        /// </summary>
        [Description("模式读取")]
        SchemaGet = 3,

        /// <summary>
        /// 模式设定
        /// </summary>
        [Description("模式设定")]
        SchemaSet = 4,

        /// <summary>
        /// 风速读取
        /// </summary>
        [Description("风速读取")]
        WindSpeedGet = 5,

        /// <summary>
        /// 风速设定
        /// </summary>
        [Description("风速设定")]
        WindSpeedSet = 6,

        /// <summary>
        /// 最低温度读取
        /// </summary>
        [Description("最低温度读取")]
        MinTempGet = 7,

        /// <summary>
        /// 最低温度设定
        /// </summary>
        [Description("最低温度设定")]
        MinTempSet = 8,

        /// <summary>
        /// 最高温度读取
        /// </summary>
        [Description("最高温度读取")]
        MaxTempGet = 9,

        /// <summary>
        /// 最高温度设定
        /// </summary>
        [Description("最高温度设定")]
        MaxTempSet = 10,

        /// <summary>
        /// 启停读取
        /// </summary>
        [Description("启停读取")]
        StartStopGet = 11,

        /// <summary>
        /// 启停设定
        /// </summary>
        [Description("启停设定")]
        StartStopSet = 12,

    }
}
