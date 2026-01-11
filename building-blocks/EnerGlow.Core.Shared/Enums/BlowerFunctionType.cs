using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 风机控制功能类型（1:启动设定 2:停止设定 3:频率读取 4:频率设定 5:就地远方读取 6:故障状态读取 7;运行状态读取）
    /// </summary>
    public enum BlowerFunctionType
    {

        /// <summary>
        /// 启动设定
        /// </summary>
        [Description("启动设定")]
        StartSet = 1,

        /// <summary>
        /// 停止设定
        /// </summary>
        [Description("停止设定")]
        StopSet = 2,

        /// <summary>
        /// 频率读取
        /// </summary>
        [Description("频率读取")]
        FrequencyGet = 3,

        /// <summary>
        ///  频率设定
        /// </summary>
        [Description("频率设定")]
        FrequencySet = 4,

        /// <summary>
        /// 就地远方读取
        /// </summary>
        [Description("就地远方读取")]
        LocalFarGet = 5,

        /// <summary>
        /// 故障状态读取
        /// </summary>
        [Description("故障状态读取")]
        FaultStatusGet = 6,

        /// <summary>
        /// 运行状态读取
        /// </summary>
        [Description("运行状态读取")]
        RunStatusGet = 7

    }
}
