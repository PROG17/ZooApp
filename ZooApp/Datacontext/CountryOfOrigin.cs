using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp.Datacontext
{
    public class CountryOfOrigin
    {
        public CountryOfOrigin()
        {
            this.Animals = new HashSet<Animal>();
        }
        
        public int CountryOfOriginId { get; set; }
        
        public string Name { get; set; }

        public virtual ICollection<Animal> Animals { get; set; }
    }
}
