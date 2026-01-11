using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 工单类型种类 1巡检单2工单3报警工单
    /// </summary>
    public enum OrderManageKindTypeEnum
    {
        /// <summary>
        /// 1巡检单
        /// </summary>
        [Description("巡检单")]
        InspecteOrder = 1,
        /// <summary>
        ///2工单
        /// </summary>
        [Description("工单管理")]
        OrderManage = 2,
        /// <summary>
        ///3报警工单
        /// </summary>
        [Description("报警工单")]
        AlarmOrder = 3,
        /// <summary>
        /// 4日常保养工单
        /// </summary>
        [Description("日常保养")]
        DailyMaintenanceOrder = 4,
        /// <summary>
        /// 5设备维修工单
        /// </summary>
        [Description("设备维修")]
        DeviceOrder = 5,
        /// <summary>
        /// 6定期维护工单
        /// </summary>
        [Description("定期维护")]
        RegularMaintenanceOrder = 6

    }
}
