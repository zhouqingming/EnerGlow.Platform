using System;
using System.Collections.Generic;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 看板数据模块类型
    /// </summary>
    public enum BoardDataModuleType
    {

        /// <summary>
        /// 本日能耗
        /// </summary>
        CurrentDay = 0,

        /// <summary>
        /// 本月能耗
        /// </summary>
        CurrentMonth = 1,

        /// <summary>
        /// 本年能耗
        /// </summary>
        CurrentYear = 2,

        /// <summary>
        /// 上月能耗
        /// </summary>
        LastMonth = 3,

        /// <summary>
        /// 昨天能耗
        /// </summary>
        Yesterday = 4,

        /// <summary>
        /// 本日每小时能耗
        /// </summary>
        TodayHour = 5,

        /// <summary>
        /// 昨天每小时能耗
        /// </summary>
        YesterdayHour = 6,

        /// <summary>
        /// 本月每天能耗
        /// </summary>
        CurrentMonthDay = 7,

        /// <summary>
        /// 本年每月能耗
        /// </summary>
        CurrentYearMonth = 8
    }
}
