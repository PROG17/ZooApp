using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace ZooApp.Datacontext
{
    public class Species
    {
        public Species()
        {
            this.Animals = new HashSet<Animal>();
        }
        
        public int SpeciesId { get; set; }
        
        public string Name { get; set; }

        public virtual ICollection<Animal> Animals { get; set; }
    }
}
