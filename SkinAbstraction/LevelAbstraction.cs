using KRModels.Models;
using Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkinAbstraction
{
    public class LevelAbstraction:ILevelAbstraction
    {
        private readonly ILevelOperations _levelOperations;

        public LevelAbstraction(ILevelOperations levelOperations)
        {
            _levelOperations = levelOperations;
        }

        public List<MLevel> Get()
        {
            return _levelOperations.Get();
        }

        public MLevel GetLevelById(Guid id)
        {
            return _levelOperations.GetLevelById(id);
        }

        public bool PostLevelData(MLevel mLevel)
        {
            return _levelOperations.PostLevelData(mLevel);
        }

        public bool PutLevelData(Guid id, MLevel mLevel)
        {
            return _levelOperations.PutLevelData(id, mLevel);
        }

    }
}
