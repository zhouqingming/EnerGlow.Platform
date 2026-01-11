using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 巡检/保养(0: 巡检  1：保养  2：视频)
    /// </summary>
    public enum PatrolUpkeepType
    {

        /// <summary>
        /// 巡检
        /// </summary>
        [Description("巡检")]
        Patrol = 0,

        /// <summary>
        /// 保养
        /// </summary>
        [Description("保养")]
        Upkeep = 1,

        /// <summary>
        /// 视频
        /// </summary>
        [Description("视频")]
        Video = 2
    }
}
