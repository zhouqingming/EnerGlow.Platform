using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 终端类型（0：所有  1：PC端  2：移动端）
    /// </summary>
    public enum TerminalType
    {
        /// <summary>
        /// 所有
        /// </summary>
        [Description("所有")]
        All = 0,

        /// <summary>
        /// PC端
        /// </summary>
        [Description("PC端")]
        Computer = 1,

        /// <summary>
        /// 移动端
        /// </summary>
        [Description("移动端")]
        Mobile = 2,
    }
}
