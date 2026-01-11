using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 电能参数 A相电压波动 Ua B相电压波动 Ub C相电压波动 Uc 功率因数 PF 频率 F A相电压谐波含有率 THD_Ua B相电压谐波含有率 THD_Ub C相电压谐波含有率 THD_Uc A相电流谐波含有率 THD_Ia B相电流谐波含有率 THD_Ib C相电流谐波含有率 THD_Ic 
    /// </summary>
    public enum ElectricParEnum
    {
        /// <summary>
        /// A相电压波动 Ua
        /// </summary>
        [Description("A相电压波动")]
        Ua = 1,
        /// <summary>
        /// B相电压波动 Ub
        /// </summary>
        [Description("B相电压波动")]
        Ub= 2,
        /// <summary>
        /// C相电压波动 Uc
        /// </summary>
        [Description("C相电压波动")]
        Uc =3,
        /// <summary>
        /// 功率因数 PF
        /// </summary>
        [Description("功率因数")]
        PF = 4,
        /// <summary>
        /// 频率 F
        /// </summary>
        [Description("频率")]
        F =5,
        /// <summary>
        /// A相电压谐波含有率 THD_Ua
        /// </summary>
        [Description("A相电压谐波含有率")]
        THD_Ua = 6,
        /// <summary>
        /// B相电压谐波含有率 THD_Ub
        /// </summary>
        [Description("B相电压谐波含有率")]
        THD_Ub = 7,
        /// <summary>
        /// C相电压谐波含有率 THD_Uc 
        /// </summary>
        [Description("C相电压谐波含有率")]
        THD_Uc = 8,
        /// <summary>
        /// A相电流谐波含有率 THD_Ia
        /// </summary>
        [Description("A相电流谐波含有率")]
        THD_Ia = 9,
        /// <summary>
        /// B相电流谐波含有率 THD_Ib
        /// </summary>
        [Description("B相电流谐波含有率")]
        THD_Ib = 10,
        /// <summary>
        ///  C相电流谐波含有率  THD_Ic
        /// </summary>
        [Description("C相电流谐波含有率")]
        THD_Ic = 11,

        /// <summary>
        ///  A相失压告警  Lou_AlmA
        /// </summary>
        [Description("失压告警")]
        LoU_AlmA =12,

        /// <summary>
        ///  A相断相告警  BrkPh_AlmA
        /// </summary>
        [Description("断相告警")]
        BrkPh_AlmA =13,
        /// <summary>
        /// AB线电压波动 Uab
        /// </summary>
        [Description("AB线电压波动")]
        Uab = 14,
        /// <summary>
        /// BC线电压波动 Ubc
        /// </summary>
        [Description("BC线电压波动")]
        Ubc= 15,
        /// <summary>
        /// CA线电压波动 Uca
        /// </summary>
        [Description("CA线电压波动")]
        Uca = 16,
        /// <summary>
        /// 温度 T
        /// </summary>
        [Description("温度")]
        T = 17,
        /// <summary>
        /// 湿度 H
        /// </summary>
        [Description("湿度")]
        H = 18,
        /// <summary>
        /// 水浸 WI
        /// </summary>
        [Description("水浸")]
        WI = 19,
        /// <summary>
        /// 烟感 Alram
        /// </summary>
        [Description("烟感")]
        Alram = 20,
        /// <summary>
        /// 水浸 water_B 
        /// </summary>
        [Description("水浸")]
        water_B = 21,
        /// <summary>
        /// 烟感 YW_P
        /// </summary>
        [Description("烟感")]
        YW_P = 22,
    }
}
