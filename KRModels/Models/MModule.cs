using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRModels.Models
{
    public class MModule
    {
        public Guid ModuleID { get; set; } = Guid.NewGuid();
        public string ModuleName { get; set; } = null!;
        public string URL { get; set; }
        public bool IsActive { get; set; } = false;
        public int Createdby { get; set; }
    }
}
