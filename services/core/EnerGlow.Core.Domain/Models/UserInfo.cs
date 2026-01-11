using EnerGlow.Core.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace EnerGlow.Core.Domain.Models
{
    [Table("user_info")]
    public class UserInfo :Entity<string>
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

        protected UserInfo() { }

        public UserInfo(string userName,string password,string roleId,string realName,string email,string mobile,string departmentId,string userId, UserSourceType source, string unionId, YesOrNo isReceiveSms, string headPortrait, YesOrNo? isVoiceAlarm)
        {
            Id = Guid.NewGuid().ToString().Replace("-", "");
            this.UserName = userName;
            this.Password = password;
            this.RoleId = roleId;
            this.RealName = realName;
            this.Email = email;
            this.Mobile = mobile;
            this.DepartmentId = departmentId;
            this.Status = StatusType.Enabled;
            LoginCount = 0;
            CreateUserId = userId;
            Source=source; UnionId=unionId;IsReceiveSms=isReceiveSms;HeadPortrait=headPortrait;IsVoiceAlarm=isVoiceAlarm;
            this.CreateTime = DateTime.Now;
            this.UpdateTime = DateTime.Now;
        }

       /// <summary>
       /// 更新用户信息
       /// </summary>
       /// <param name="realName"></param>
       /// <param name="email"></param>
       /// <param name="mobile"></param>
       /// <param name="isReceiveSms"></param>
       /// <param name="isVoiceAlarm"></param>
        public void UpdateBasicInfo(string realName, string email, string mobile, YesOrNo isReceiveSms, YesOrNo? isVoiceAlarm)
        {
            this.RealName = realName;
            this.Email = email;
            this.Mobile = mobile;
            this.IsReceiveSms = isReceiveSms;
            this.IsVoiceAlarm = isVoiceAlarm;
        }

        public void ChangePassword(string newPassword)
        {
            if(string.IsNullOrWhiteSpace(newPassword))
                throw new ArgumentException("新密码不能为空");
            if(newPassword == this.Password)
                throw new ArgumentException("新密码不能与旧密码相同");
            this.Password = newPassword;
            this.PwdUpdateTime = DateTime.Now;
        }
        public void LockUser()
        {
            this.LockTime = DateTime.Now;
        }

        /// <summary>
        /// 禁用用户
        /// </summary>
        public void Deactivate()
        {
            Status = StatusType.Disable;
            UpdateTime = DateTime.UtcNow;
        }

        /// <summary>
        /// 启用
        /// </summary>
        public void Activate()
        {
            Status = StatusType.Enabled;
            UpdateTime = DateTime.UtcNow;
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        public void Delete()
        {
            Status = StatusType.Deleted;
            UpdateTime = DateTime.UtcNow;
        }

        public void RecordLogin()
        {
            LoginCount += 1;
            LastLoginTime = DateTime.UtcNow;
        }
    }
}
