using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 计算类型
    /// </summary>
    public enum CalcType
    {
        /// <summary>
        /// 样本值
        /// </summary>
        [Description("样本值")]
        Sample =0,

        /// <summary>
        /// 插值
        /// </summary>
        [Description("插值")]
        Interpolation =1,

        /// <summary>
        /// 最大值
        /// </summary>
        [Description("最大值")]
        MaxVal =2,

        /// <summary>
        /// 最小值
        /// </summary>
        [Description("最小值")]
        MinVal =3,

        /// <summary>
        /// 平均值
        /// </summary>
        [Description("平均值")]
        AvgVal=4,

        /// <summary>
        /// 汇总值
        /// </summary>
        [Description("汇总值")]
        SumVal =5,

        /// <summary>
        /// 差值
        /// </summary>
        [Description("差值")]
        Difference =6,

        /// <summary>
        /// 序号
        /// </summary>
        [Description("序号")]
        SerialNumber =7,

        /// <summary>
        /// 设备名称
        /// </summary>
        [Description("设备名称")]
        DevName =8,

        /// <summary>
        /// 时间
        /// </summary>
        [Description("时间")]
        DateType = 9,

        /// <summary>
        /// 公式
        /// </summary>
        [Description("公式")]
        Formula =10,

        /// <summary>
        /// 额定值公式
        /// </summary>
        [Description("额定值公式")]
        RatedFormula =11,

        /// <summary>
        /// 额定值公式和公式
        /// </summary>
        [Description("额定值公式和公式")]
        RatedAndFormula = 12,

        /// <summary>
        /// 自定义脚本
        /// </summary>
        [Description("自定义脚本")]
        CustomSql = 13,
    }
}
