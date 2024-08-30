using KRModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    public interface ILevelOperations
    {
        List<MLevel> Get();
        MLevel GetLevelById(Guid id);
        bool PostLevelData(MLevel mLevel);
        bool PutLevelData(Guid id, MLevel mLevel);
    }
}
