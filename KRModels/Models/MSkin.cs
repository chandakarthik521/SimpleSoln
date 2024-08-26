using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRModels.Models
{
    public class MSkin
    {
        public Guid SkinID { get; set; } = Guid.NewGuid();
        public string SkinColour { get; set; } = null!;
        public string URL { get; set; }
        public bool IsActive { get; set; } = false;
        public int Createdby { get; set; }
    }
}
