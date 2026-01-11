using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 关系库的报警类型（1：通信故障  2：越限报警  3：设备故障  4：变压器超载）
    /// </summary>
    public enum AlarmTypeForSQL
    {
        /// <summary>
        /// 通信故障
        /// </summary>
        [Description("通信故障")]
        CommunicationFail = 1,

        /// <summary>
        /// 越线报警
        /// </summary>
        [Description("越限报警")]
        LimitAlarm = 2,

        /// <summary>
        ///设备故障
        /// </summary>
        [Description("设备故障")]
        DeviceFail = 3,

        /// <summary>
        ///变压器超载
        /// </summary>
        [Description("变压器超载")]
        TransformerOverLoad = 4,

        /// <summary>
        ///鹰眼报警
        /// </summary>
        [Description("鹰眼报警")]
        EagleyeAlarm = 5,

        /// <summary>
        ///继保报警
        /// </summary>
        [Description("继保报警")]
        RelayAlarm = 6,

        /// <summary>
        ///额定值超载
        /// </summary>
        [Description("额定值超载")]
        RatingOverLoad = 7,

        ///// <summary>
        /////部件故障
        ///// </summary>
        //[Description("部件故障")]
        //ComponentFail = 4,
    }
}
