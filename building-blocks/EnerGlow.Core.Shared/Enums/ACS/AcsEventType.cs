using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared.ACS
{
    /// <summary>
    /// Acs 门禁事件枚举
    /// </summary>
    public enum AcsEventType
    {
        /// <summary>
        /// 开门
        /// </summary>
        [Description("LOCK_OPEN")]
        LOCK_OPEN = 0,

        /// <summary>
        /// 关门
        /// </summary>
        [Description("LOCK_CLOSE")]
        LOCK_CLOSE = 1,

        /// <summary>
        /// 人脸验证通过
        /// </summary>
        [Description("FACE_VERIFY_PASS")]
        FACE_VERIFY_PASS = 2,

        /// <summary>
        /// 人脸验证失败
        /// </summary>
        [Description("FACE_VERIFY_FAIL")]
        FACE_VERIFY_FAIL = 3
    }
}
