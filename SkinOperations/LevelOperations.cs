using Interfaces;
using KRModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    public class LevelOperations : ILevelOperations
    {
        private readonly IMLevelDML _mLevelDML;
        public LevelOperations(IMLevelDML mLevelDML)
        {
            _mLevelDML = mLevelDML;
        }

        public List<MLevel> Get()
        {
            return _mLevelDML.Get();
        }

        public MLevel GetLevelById(Guid id)
        {
            return _mLevelDML.GetLevelById(id);
        }

        public bool PostLevelData(MLevel mLevel)
        {
            return _mLevelDML.PostLevelData(mLevel);
        }

        public bool PutLevelData(Guid id, MLevel mLevel)
        {
            return _mLevelDML.PutLevelData(id, mLevel);
        }
    }
}
