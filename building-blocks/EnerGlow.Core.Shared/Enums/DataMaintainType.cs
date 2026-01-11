using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 数据维护类型（1：备品类型  2：资料类型）
    /// </summary>
    public enum DataMaintainType
    {

        /// <summary>
        /// 备品类型
        /// </summary>
        [Description("备品类型")]
        SparesType = 1,

        /// <summary>
        /// 资料类型
        /// </summary>
        [Description("资料类型")]
        DataFileType = 2,

        /// <summary>
        /// 巡检步骤类型
        /// </summary>
        [Description("运维步骤类型")]
        PatrolStepType = 3,

        /// <summary>
        /// 保养步骤类型
        /// </summary>
        [Description("运维步骤类型")]
        UpkeepStepType = 4,

        /// <summary>
        /// 日期天气温度类型
        /// </summary>
        [Description("日期温度类型")]
        DailyTemperatureType = 5


    }
}
