using KRModels.Models;
using System;

namespace Interfaces
{
    public class IMHairDML
    {
        public List<MHair> Get();

        public MHair Get(Guid id);

        public bool post(MHair mHair);

        public bool put(Guid id, MHair mHair);
    }
}
