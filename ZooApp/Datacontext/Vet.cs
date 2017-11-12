using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp.Datacontext
{
    public class Vet
    {
        public Vet()
        {
            this.Appointments = new HashSet<Appointment>();
        }

        public int VetId { get; set; }
        public string VetName { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }

    }
}
