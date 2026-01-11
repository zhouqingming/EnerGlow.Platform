using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 字典类别
    /// </summary>
   public enum DicTypeEnum
    {
        /// <summary>
        /// 字典类别 1、类别
        /// </summary>
        [Description("类别")]
        DicType = 1,
        /// <summary>
        /// 字典类别 2、字典值
        /// </summary>
        [Description("字典值")]
        DicVal =2,
    }
}
