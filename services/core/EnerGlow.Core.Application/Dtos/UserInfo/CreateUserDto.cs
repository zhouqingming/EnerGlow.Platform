using EnerGlow.Core.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnerGlow.Core.Application.Dtos
{
    public class CreateUserDto
    {
        public string userName { get; set; }
        public string password { get; set; }
        public string roleId { get; set; }
        public string realName { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public string departmentId { get; set; }
        public string userId { get; set; }
        public UserSourceType source { get; set; }
        public string unionId { get; set; }
        public YesOrNo isReceiveSms { get; set; }
        public string headPortrait { get; set; }
        public YesOrNo? isVoiceAlarm { get; set; }
    }
}
