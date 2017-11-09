using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp.Datacontext
{
    public class Habitat
    {
        public Habitat()
        {
            this.Animals = new HashSet<Animal>();
        }

        public int HabitatId { get; set; }
        
        public string Name { get; set; }

        public virtual ICollection<Animal> Animals { get; set; }
    }
}
