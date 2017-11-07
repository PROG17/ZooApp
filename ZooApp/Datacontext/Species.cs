using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp.Datacontext
{
    public class Species
    {
        public Species()
        {
            this.Animals = new HashSet<Animal>();
        }
        [Key]
        [Required]
        public int SpeciesId { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Animal> Animals { get; set; }
    }
}
