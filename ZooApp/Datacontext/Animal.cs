using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp.Datacontext
{
    public class Animal
    {
        public Animal()
        {
            this.Parents = new HashSet<Animal>();
        }

        public int AnimalId { get; set; }

        public string Name { get; set; }

        public int Weight { get; set; }

        public string Eats { get; set; }

        public int CountryOfOriginId { get; set; }
        public int HabitatId { get; set; }
        public int SpeciesId { get; set; }
        
        public virtual CountryOfOrigin CountryOfOrigin { get; set; }
        public virtual Habitat Habitat { get; set; }
        public virtual Species Species { get; set; }

        public virtual ICollection<Animal> Parents { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
