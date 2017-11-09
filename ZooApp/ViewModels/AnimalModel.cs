using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp.Models
{
    public class AnimalModel
    {
        public int AnimalId { get; set; }
        public string Name { get; set; }
        public string Eats { get; set; }
        public string CountryOfOrigin { get; set; }
        public int Weight { get; set; }
        public string Species { get; set; }
        //public bool HasVetAppointment { get; set; }
        //public string FirstParent { get; set; }
        //public string SecondParent { get; set; }
    }
}
