using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 摄像机类型
    /// </summary>
    public enum CameraType
    {
        /// <summary>
        /// 海康威视
        /// </summary>
        [Description("海康威视")]
        HikVision = 0,

        /// <summary>
        /// 浙江宇视
        /// </summary>
        [Description("宇视")]
        Uniview = 1,

        /// <summary>
        /// 机器人可见光摄像头
        /// </summary>
        [Description("机器人可见光摄像头")]
        RobotLight = 2,

        /// <summary>
        /// 巡检机器人红外摄像头
        /// </summary>
        [Description("巡检机器人红外摄像头")]
        RobotRed = 3,
    }
}
