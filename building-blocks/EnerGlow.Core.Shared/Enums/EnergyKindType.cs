using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{
    public enum EnergyKindType
    {
        /// <summary>
        /// 电
        /// </summary>
        [Description("电")]
        Electricity,

        /// <summary>
        /// 水
        /// </summary>
        [Description("水")]
        Water,

        /// <summary>
        /// 油
        /// </summary>
        [Description("油")]
        Oil,

        /// <summary>
        /// 煤
        /// </summary>
        [Description("煤")]
        Coal,

        /// <summary>
        /// 天然气
        /// </summary>
        [Description("天然气")]
        NaturalGas,


        /// <summary>
        /// 压缩空气
        /// </summary>
        [Description("压缩空气")]
        CompressedAir,


        /// <summary>
        /// 暖气
        /// </summary>
        [Description("暖气")]
        CentralHeating,

        /// <summary>
        /// 冷冻水
        /// </summary>
        [Description("冷冻水")]
        ChilledWater,

        /// <summary>
        /// 制冷量
        /// </summary>
        [Description("制冷量")]
        Refrigerating,
    }
}
