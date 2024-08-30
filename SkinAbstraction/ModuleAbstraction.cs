using Interfaces;
using KRModels.Models;
using Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkinAbstraction
{
    public class ModuleAbstraction:IModuleAbstraction
    {
        private readonly IModuleOperations _moduleOperations;
        public ModuleAbstraction(IModuleOperations moduleOperations)
        {
            _moduleOperations = moduleOperations;   
        }

        public List<MModule> Get()
        {
            return _moduleOperations.Get();
        }

        public MModule GetModuleById(Guid id)
        {
            return _moduleOperations.GetModuleById(id);
        }

        public bool PostModuleData(MModule mModule)
        {
            return _moduleOperations.PostModuleData(mModule);
        }

        public bool PutModuleData(Guid id, MModule mModule)
        {
            return _moduleOperations.PutModuleData(id, mModule);
        }
    }
}
