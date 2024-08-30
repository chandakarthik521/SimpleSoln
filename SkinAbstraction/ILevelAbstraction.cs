using KRModels.Models;
using System;

namespace SkinAbstraction
{
    public interface ILevelAbstraction
    {
        List<MLevel> Get();
        MLevel GetLevelById(Guid id);
        bool PostLevelData(MLevel mLevel);
        bool PutLevelData(Guid id, MLevel mLevel);
    }
}
