using EnerGlow.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace EnerGlow.Core.Domain.Repositorys
{
    public interface IConfigDictRepository:IRepository<ConfigDict, string>
    {
         Task<List<ConfigDict>> GetListAll();
    }
}
