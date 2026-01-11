using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 区域设备绑定类型（0：总设备  1：进线 2;配电房设备）
    /// </summary>
    public enum AreaDevType
    {
        /// <summary>
        /// 总设备
        /// </summary>
        [Description("总设备")]
        All = 0,

        /// <summary>
        /// 进线
        /// </summary>
        [Description("进线设备")]
        Income = 1,

        /// <summary>
        /// 配电房设备
        /// </summary>
        [Description("配电房设备")]
        Distribution =2,
    }
}
