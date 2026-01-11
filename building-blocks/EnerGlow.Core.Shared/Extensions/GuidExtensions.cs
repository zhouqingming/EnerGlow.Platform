using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnerGlow.Core.Shared.Extensions
{
    /// <summary>
    /// Guid的扩展类
    /// </summary>
    public static class GuidExtensions
    {
        /// <summary>
        /// 转换成Id形式
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public static string ToId(this Guid guid)
        {
            return guid.ToString().Replace("-", "");
        }
    }
}
