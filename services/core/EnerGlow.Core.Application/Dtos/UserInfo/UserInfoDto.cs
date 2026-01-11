using EnerGlow.Core.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace EnerGlow.Core.Application.Dtos
{
    public class UserInfoDto:EntityDto<string>
    {
        /// <summary>
        /// 用户编号
        /// </summary>
        public int UserNum { get; set; }
        ///<summary>
        ///用户名
        ///</summary>
        public string UserName { get; set; }

        ///<summary>
		///密码
		///</summary>
        public string Password { get; set; }

        ///<summary>
		///角色Id
		///</summary>
        public string RoleId { get; set; }

        ///<summary>
		///真实姓名
		///</summary>
        public string RealName { get; set; }

        ///<summary>
		///邮箱
		///</summary>
        public string Email { get; set; }

        ///<summary>
		///手机号
		///</summary>
        public string Mobile { get; set; }

        ///<summary>
		///部门Id
		///</summary>
        public string DepartmentId { get; set; }

        ///<summary>
		///状态(0:启用  1:停用   2:删除)
		///</summary>
        public StatusType Status { get; set; }



        ///<summary>
		///登录次数
		///</summary>
        public int LoginCount { get; set; }

        ///<summary>
		///最后登录时间
		///</summary>
        public DateTime? LastLoginTime { get; set; }

        ///<summary>
		///创建时间
		///</summary>
        public DateTime CreateTime { get; set; }

        ///<summary>
		///创建人Id
		///</summary>
        public string CreateUserId { get; set; }

        ///<summary>
		///用户来源（0：系统用户    1：注册用户   2：创建用户）
		///</summary>
        public UserSourceType Source { get; set; }

        ///<summary>
		///UnionId
		///</summary>
        public string UnionId { get; set; }

        /// <summary>
        /// 是否接收短信通知
        /// </summary>
        public YesOrNo IsReceiveSms { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        public string HeadPortrait { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime? UpdateTime { get; set; } = DateTime.Now;

        /// <summary>
        /// 是否声光报警
        /// </summary>
        public YesOrNo? IsVoiceAlarm { get; set; }

        /// <summary>
        /// 修改密码时间
        /// </summary>
        public DateTime? PwdUpdateTime { get; set; }

        /// <summary>
        /// 被锁定时的时间
        /// </summary>
        public DateTime? LockTime { get; set; }
    }
}
