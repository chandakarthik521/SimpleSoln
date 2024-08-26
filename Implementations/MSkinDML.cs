using Interfaces;
using KRModels.Context;
using KRModels.Models;

namespace Implementations
{
    public class MSkinDML : IMSkinDML
    {
        private readonly KRContext _kRContext;
        public MSkinDML(KRContext kRContext)
        {
            _kRContext = kRContext;
        }
        public List<MSkin> Get()
        {
            return _kRContext.MSkinColours.ToList();
        }

        public MSkin Get(Guid id)
        {
            return _kRContext.MSkinColours.FirstOrDefault(x => x.SkinID == id);
        }

        public bool Post(MSkin mSkin)
        {
            _kRContext.MSkinColours.Add(mSkin);
            return _kRContext.SaveChanges() > 0;
        }

        public bool Put(Guid id, MSkin mSkin)
        {
            var skincolour = Get(id);
            skincolour.SkinColour = skincolour.SkinColour;
            skincolour.Createdby = skincolour.Createdby;
            skincolour.URL = skincolour.URL;
            return (_kRContext.SaveChanges() > 0 ? true : false);
        }
    }
}