using Interfaces;
using KRModels.Models;
using SkinAbstraction;

namespace SkinAbstraction
{
    public class SkinAbstraction : ISkinAbstraction
    {
        private readonly ISkinOperations _skinOperations;
        public SkinAbstraction(ISkinOperations skinOperations)
        {
            _skinOperations = skinOperations;
        }
        public List<MSkin> Get()
        {
            return _skinOperations.Get();
        }

        public MSkin Get(Guid id)
        {
            return _skinOperations.Get(id);
        }

        public bool Post(MSkin mSkin)
        {
            return _skinOperations.Post(mSkin);
        }

        public bool Put(Guid id, MSkin mSkin)
        {
            return _skinOperations.Put(id, mSkin);
        }
    }
}