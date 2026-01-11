using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// Rdb实时库 WebSockete协议命令枚举 
    /// </summary>
    public enum RdbCommandType
    {
        /// <summary>
        /// 登录命令
        /// </summary>
        [Description("rdb_login")]
        Login = 0,

        /// <summary>
        /// 登录验证命令
        /// </summary>
        [Description("rdb_auth")]
        Auth = 1,

        /// <summary>
        /// 事件订阅命令
        /// </summary>
        [Description("rdb_soessc")]
        SoeSSC = 2,

        /// <summary>
        /// 事件推送命令
        /// </summary>
        [Description("put_soe")]
        PutSoe = 3,

        /// <summary>
        /// 事件写入命令
        /// </summary>
        [Description("rdb_soewrite")]
        SoeWrite = 4

    }
}
