using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRModels.Models
{
    public class MLevel
    {
        public Guid LevelID { get; set; } = Guid.NewGuid();
        public string LevelName { get; set; } = null!;
        public string URL { get; set; }
        public bool IsActive { get; set; } = false;
        public int Createdby { get; set; }
    }
}
