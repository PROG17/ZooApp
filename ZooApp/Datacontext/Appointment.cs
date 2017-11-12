using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp.Datacontext
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public int? AnimalId { get; set; }
        public int VetId { get; set; }
        public int DiagnoseId { get; set; }

        public virtual Vet Vet { get; set; }
        public virtual Animal Animal { get; set; }
        public virtual Diagnose Diagnose { get; set; }
        public DateTime DateTime { get; set; }

    }
}
