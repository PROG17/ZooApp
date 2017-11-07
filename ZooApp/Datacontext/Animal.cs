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

        [Key]
        [Required]
        public int AnimalId { get; set; }
        [Required]
        public string Name { get; set; }

        public int Weight { get; set; }

        public string Eats { get; set; }

        public virtual ICollection<Animal> Parents { get; set; }
       
    }
}
