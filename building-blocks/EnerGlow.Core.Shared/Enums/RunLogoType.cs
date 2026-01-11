using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnerGlow.Core.Shared
{
    public enum RunLogoType
    {
        /// <summary>
        /// 启动
        /// </summary>
        [Description("启动")]
        Start = 1,

        /// <summary>
        /// 停止
        /// </summary>
        [Description("停止")]
        Stop = 0,
    }
}
