using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp.ViewModels
{
    public class AppointmentModel
    {

        public int AnimalId { get; set; }
        public string VetName { get; set; }
        public DateTime BookedDateTime { get; set; }
    }
}
