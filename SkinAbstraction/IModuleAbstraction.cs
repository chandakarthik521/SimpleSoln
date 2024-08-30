using KRModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkinAbstraction
{
    public interface IModuleAbstraction
    {
        List<MModule> Get();
        MModule GetModuleById(Guid id);
        bool PostModuleData(MModule mModule);
        bool PutModuleData(Guid id, MModule mModule);
    }
}
