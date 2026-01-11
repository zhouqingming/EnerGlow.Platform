using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 中央空调属性名称
    /// </summary>
    public enum VrvPropertyName
    {

        /// <summary>
        /// 型号
        /// </summary>
        [Description("型号")]
        ModelNum,

        /// <summary>
        /// 制造日期
        /// </summary>
        [Description("制造日期")]
        MakeDate,

        /// <summary>
        /// 重量
        /// </summary>
        [Description("重量")]
        Weight,

        /// <summary>
        /// 电源
        /// </summary>
        [Description("电源")]
        Power,

        /// <summary>
        /// 额定频率
        /// </summary>
        [Description("额定频率")]
        RatedFrequency,

        /// <summary>
        /// 输入功率
        /// </summary>
        [Description("输入功率")]
        InputPower,

        /// <summary>
        /// 制冷量
        /// </summary>
        [Description("制冷量")]
        RefrigeratingCapacity,

        /// <summary>
        /// 转换效率 
        /// </summary>
        [Description("转换效率")]
        TransferEfficiency,

        /// <summary>
        /// 出口温度
        /// </summary>
        [Description("出口温度")]
        OutletTemperature,

        /// <summary>
        /// 进口温度
        /// </summary>
        [Description("进口温度")]
        InletTemperature,

        /// <summary>
        /// 流量
        /// </summary>
        [Description("流量")]
        Flow,

        /// <summary>
        /// 压降
        /// </summary>
        [Description("压降")]
        PressureDrop,

        /// <summary>
        /// 额定功率
        /// </summary>
        [Description("额定功率")]
        RatedPower,

        /// <summary>
        /// 机外静压
        /// </summary>
        [Description("机外静压")]
        StaticPressure,

        /// <summary>
        /// 风量
        /// </summary>
        [Description("风量")]
        AirVolume,

        /// <summary>
        /// 冷量
        /// </summary>
        [Description("冷量")]
        CoolingCapacity,

        /// <summary>
        /// 热量
        /// </summary>
        [Description("热量")]
        QuantityOfHeat,

        /// <summary>
        /// 水流量
        /// </summary>
        [Description("水流量")]
        WaterFlowRate

    }
}
