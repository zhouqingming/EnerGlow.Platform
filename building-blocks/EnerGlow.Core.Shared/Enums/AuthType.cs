using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 认证类型(0:身份证  1:营业执照)
    /// </summary>
    public enum AuthType
    {

        /// <summary>
        /// 身份证
        /// </summary>
        [Description("身份证")]
        IdCard = 0,

        /// <summary>
        /// 营业执照
        /// </summary>
        [Description("营业执照")]
        BusinessLicense = 1,
    }
}
