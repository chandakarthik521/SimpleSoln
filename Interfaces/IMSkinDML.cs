using KRModels.Models;

namespace Interfaces
{
    public interface IMSkinDML
    {
        public List<MSkin> Get();
        public MSkin Get(Guid id);
        public bool Post(MSkin mSkin);
        public bool Put(Guid id, MSkin mSkin);

    }
}