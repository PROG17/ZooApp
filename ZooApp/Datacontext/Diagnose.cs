using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp.Datacontext
{
    public class Diagnose
    {
        public Diagnose()
        {
            this.Appointments = new HashSet<Appointment>();
            this.DiagnoseMedicines = new HashSet<DiagnoseMedicine>();
        }

        public int DiagnoseId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<DiagnoseMedicine> DiagnoseMedicines { get; set; }

    }
}
