using Interfaces;
using KRModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    public class ModuleOperations: IModuleOperations
    {
        private readonly IModuleDML _moduleDML;
        public ModuleOperations(IModuleDML moduleDML)
        {
            _moduleDML = moduleDML;
        }

        public List<MModule> Get()
        {
            return _moduleDML.Get();
        }

        public MModule GetModuleById(Guid id)
        {
            return _moduleDML.GetModuleById(id);
        }

        public bool PostModuleData(MModule mModule)
        {
            return _moduleDML.PostModuleData(mModule);
        }

        public bool PutModuleData(Guid id, MModule mModule)
        {
            return _moduleDML.PutModuleData(id, mModule);
        }

    }
}
