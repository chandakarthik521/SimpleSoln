using Interfaces;
using KRModels.Context;
using KRModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementations
{
    public class MLevelDML : IMLevelDML
    {
        private readonly KRContext _kRContext;

        public MLevelDML(KRContext kRContext)
        {
            _kRContext = kRContext;
        }

        public List<MLevel> Get()
        {
            return _kRContext.MLevels.ToList();
        }

        public MLevel GetLevelById(Guid id)
        {
            return _kRContext.MLevels.FirstOrDefault(x => x.LevelID == id);
        }

        public bool PostLevelData(MLevel mLevel)
        {
            _kRContext.MLevels.Add(mLevel);
            return _kRContext.SaveChanges() > 0;
        }

        public bool PutLevelData(Guid id, MLevel mLevel)
        {
            var level = GetLevelById(id);
            level.LevelName = level.LevelName;
            level.Createdby = level.Createdby;
            level.URL = level.URL;
            level.IsActive = level.IsActive;
            return (_kRContext.SaveChanges() > 0 ? true : false);
        }

    }
}
