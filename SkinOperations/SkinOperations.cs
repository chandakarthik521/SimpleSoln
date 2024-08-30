using Interfaces;
using KRModels.Models;

namespace Operations
{
    public class SkinOperations : ISkinOperations
    {
        private readonly IMSkinDML _mSkinDML;
        public SkinOperations(IMSkinDML mSkinDML)
        {

            _mSkinDML = mSkinDML;
        }
        public List<MSkin> Get()
        {
            return _mSkinDML.Get();
        }

        public MSkin Get(Guid id)
        {
            return _mSkinDML.Get(id);
        }

        public bool Post(MSkin mSkin)
        {
            return _mSkinDML.Post(mSkin);
        }

        public bool Put(Guid id, MSkin mSkin)
        {
            return _mSkinDML.Put(id, mSkin);
        }
    }
}