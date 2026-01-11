using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnerGlow.Core.Shared
{
    public enum PointTypeEnum
    {
        /// <summary>
        /// 开关量,4字节整数
        /// </summary>
        [Description("digital")]
        DT_DIGITAL = 1,

        /// <summary>
        /// 4字节整数
        /// </summary>
        [Description("int32")]
        DT_INT32 = 2,

        /// <summary>
        /// 4字节浮点数
        /// </summary>
        [Description("float32")]
        DT_FLOAT32 = 3,

        /// <summary>
        /// 8字节整数
        /// </summary>
        [Description("int64")]
        DT_INT64 = 4,

        /// <summary>
        /// 8字节浮点数
        /// </summary>
        [Description("float64")]
        DT_FLOAT64 = 5,
    }

    public enum CompTypeEnum
    {
        /// <summary>
        /// no
        /// </summary>
        [Description("no")]
        NO = 0,

        /// <summary>
        /// percent
        /// </summary>
        [Description("percent")]
        Percent = 1,

        /// <summary>
        /// abs
        /// </summary>
        [Description("abs")]
        Abs = 2,

        /// <summary>
        /// timer
        /// </summary>
        [Description("timer")]
        Timer = 3,

        /// <summary>
        /// extimer
        /// </summary>
        [Description("extimer")]
        Extimer = 3,
    }

    public enum ClassEnum
    {
        /// <summary>
        /// DEC
        /// </summary>
        [Description("DEC")]
        DEC = 0,

        /// <summary>
        /// DEFINE
        /// </summary>
        [Description("DEFINE")]
        DEFINE = 1,

        /// <summary>
        /// PRESET
        /// </summary>
        [Description("PRESET")]
        PRESET = 2,

        /// <summary>
        /// CURVE
        /// </summary>
        [Description("CURVE")]
        CURVE = 3,
    }

    public enum StepEnum
    {
        /// <summary>
        /// ON
        /// </summary>
        [Description("ON")]
        ON = 0,

        /// <summary>
        /// OFF
        /// </summary>
        [Description("OFF")]
        OFF = 1,
    }

    public enum ArchivingEnum
    {
        /// <summary>
        /// ON
        /// </summary>
        [Description("ON")]
        ON = 0,

        /// <summary>
        /// OFF
        /// </summary>
        [Description("OFF")]
        OFF = 1,
    }
}
