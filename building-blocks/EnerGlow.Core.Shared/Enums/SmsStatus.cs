using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnerGlow.Core.Shared
{
    public enum SmsStatus
    {
        /// <summary>
        /// 未发送
        /// </summary>
        [Description("未发送")]
        NotSend = 0,

        /// <summary>
        /// 已发送
        /// </summary>
        [Description("已发送")]
        BeenSend = 1,

        /// <summary>
        /// 发送失败
        /// </summary>
        [Description("发送失败")]
        SendFail = 2,

        /// <summary>
        /// 删除
        /// </summary>
        [Description("删除")]
        DeleteStatus = 3,
    }

    public enum SmsType
    {
        /// <summary>
        /// 阿里云
        /// </summary>
        [Description("阿里云")]
        Aliyun = 0,

        /// <summary>
        /// 广本
        /// </summary>
        [Description("广本")]
        GB = 1,

        /// <summary>
        /// 企业微信
        /// </summary>
        [Description("企业微信")]
        Pyweixin = 4,

        /// <summary>
        /// 华为云
        /// </summary>
        [Description("华为云")]
        Hweiyun = 3,
    }
}
