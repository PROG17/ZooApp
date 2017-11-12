using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp.Datacontext
{
    public class Medicine
    {
        public Medicine()
        {
            this.DiagnoseMedicines = new HashSet<DiagnoseMedicine>();
        }

        public int MedicineId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<DiagnoseMedicine> DiagnoseMedicines { get; set; }
    }
}
