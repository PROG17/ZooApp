using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp.ViewModels
{
    public class NewAnimal
    {
        
        public string Name { get; set; }
        public string Eats { get; set; }
        public string CountryOfOrigin { get; set; }
        public string Habitat { get; set; }
        public string Species { get; set; }
        public int Weight { get; set; }
        public int Parent1Id { get; set; }
        public int Parent2Id { get; set; }
    }
}
