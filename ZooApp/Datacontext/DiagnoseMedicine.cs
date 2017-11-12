using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp.Datacontext
{
    public class DiagnoseMedicine
    {
        public int DiagnoseMedicineId { get; set; }
        public int? MedicineId { get; set; }
        public int? DiagnoseId { get; set; }

        public virtual Medicine Medicine { get; set; }
        public virtual Diagnose Diagnose { get; set; }
    }
}
