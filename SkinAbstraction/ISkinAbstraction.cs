using KRModels.Models;

namespace SkinAbstraction
{
    public interface ISkinAbstraction
    {
        List<MSkin> Get();
        MSkin Get(Guid id);
        bool Post(MSkin mSkin);
        bool Put(Guid id, MSkin mSkin);
    }
}