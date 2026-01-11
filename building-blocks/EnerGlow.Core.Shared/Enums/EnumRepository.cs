using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnerGlow.Core.Shared
{
    public class EnumRepository
    {
        /// <summary>
        /// 错误代码枚举
        /// </summary>
        public enum Error
        {
            #region 系统错误 error 1000~1099

            /// <summary>
            /// 网络异常
            /// </summary>
            [Description("网络异常")]
            error_network = 1000,

            /// <summary>
            /// 序列化错误
            /// </summary>
            [Description("序列化错误")]
            error_serialization = 1001,

            /// <summary>
            /// 程序异常
            /// </summary>
            [Description("程序异常")]
            error_program = 1002,

            /// <summary>
            /// 没有找到数据
            /// </summary>
            [Description("没有找到数据")]
            error_nodata = 1003,

            /// <summary>
            /// 数据库的数据错误
            /// </summary>
            [Description("数据库的数据错误")]
            error_sqldata = 1004,

            /// <summary>
            /// 系统缓存错误
            /// </summary>
            [Description("设置系统缓存错误")]
            error_setcache = 1005,

            /// <summary>
            /// 反序列化错误
            /// </summary>
            [Description("反序列化错误")]
            error_deserialization = 1006,


            [Description("无效的链接")]
            error_URL = 1007,

            [Description("添加错误")]
            error_Add = 1008,

            [Description("修改错误")]
            error_Update = 1009,

            [Description("删除错误")]
            error_Delete = 1010,

            /// <summary>
            /// 缺少必选参数
            /// </summary>
            [Description("缺少必选参数")]
            error_MissParam = 1011,
            /// <summary>
            /// 签名验证失败
            /// </summary>
            [Description("签名验证失败")]
            error_Sign = 1012,
            #endregion

            #region 权限 2000-2099
            /// <summary>
            /// 没有权限
            /// </summary>
            [Description("没有数据权限")]
            noPower = 2000,
            #endregion

            #region 验证提示 3000-3999
            /// <summary>
            /// 验证码错误
            /// </summary>
            [Description("验证码错误")]
            error_ValidateCode = 3000,
            /// <summary>
            /// 验证码错误
            /// </summary>
            [Description("验证码已失效,请重新获取")]
            error_ValidateNum = 3001,
            #endregion
        }
    }
}
