using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 操作类型
    /// 0：查看   1：新增     2：编辑   3：删除   4：登录   5：注销
    /// </summary>
    public enum OperateType
    {
        /// <summary>
        /// 查看
        /// </summary>
        [Description("查看")]
        Browse = 0,

        /// <summary>
        /// 新增
        /// </summary>
        [Description("新增")]
        Add = 1,

        /// <summary>
        /// 编辑
        /// </summary>
        [Description("编辑")]
        Edit = 2,

        /// <summary>
        /// 删除
        /// </summary>
        [Description("删除")]
        Delete = 3,

        /// <summary>
        /// 登录
        /// </summary>
        [Description("登录")]
        Login = 4,

        /// <summary>
        /// 注销
        /// </summary>
        [Description("注销")]
        Logout = 5,

        /// <summary>
        /// 控制
        /// </summary>
        [Description("控制")]
        Ctrl = 6
    }
}
