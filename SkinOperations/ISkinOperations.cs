using KRModels.Models;

namespace Operations
{
    public interface ISkinOperations
    {
        List<MSkin> Get();
        MSkin Get(Guid id);
        bool Post(MSkin mSkin);
        bool Put(Guid id, MSkin mSkin);
    }
}