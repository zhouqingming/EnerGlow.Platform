using System;
using System.Collections.Generic;
using System.Text;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 海康威视设备枚举
    /// </summary>
    public enum HikVisionType
    {
        /// <summary>
        /// 门禁设备
        /// </summary>
        ACS = 0,

        /// <summary>
        /// IPC 网络摄像机
        /// </summary>
        IPCamera = 1,

        /// <summary>
        /// NVR网络刻录机
        /// </summary>
        NVR = 2,
    }
}
