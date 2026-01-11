using EnerGlow.Core.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnerGlow.Core.Application.Dtos
{
    public class UpdateUserDto
    {
        public string realName { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public YesOrNo isReceiveSms { get; set; }
        public YesOrNo? isVoiceAlarm { get; set; }
    }
}
