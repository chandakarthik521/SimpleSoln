using Interfaces;
using KRModels.Context;
using KRModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Implementations
{
    public class MModuleDML:IModuleDML
    {
        private readonly KRContext _kRContext;
        public MModuleDML(KRContext kRContext)
        {
            _kRContext = kRContext;
        }

        public List<MModule> Get()
        {
            return _kRContext.MModules.ToList();
        }

        public MModule GetModuleById(Guid id)
        {
            return _kRContext.MModules.FirstOrDefault(x => x.ModuleID == id);
        }

        public bool PostModuleData(MModule mModule)
        {
            _kRContext.MModules.Add(mModule);
            return _kRContext.SaveChanges() > 0;
        }

        public bool PutModuleData(Guid id, MModule mModule)
        {
            var Module = GetModuleById(id);
            Module.ModuleName = Module.ModuleName;
            Module.Createdby = Module.Createdby;
            Module.URL = Module.URL;
            Module.IsActive = Module.IsActive;
            return (_kRContext.SaveChanges() > 0 ? true : false);
        }
    }
}
