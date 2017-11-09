using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooApp.DAL;
using ZooApp.Models;

namespace ZooApp.BusinessLayer
{
    public class Zoo
    {
        public BindingList<Models.AnimalModel> GetAnimals(string habitat, string species, string eats)
        {
            var dataAccess = new DataAccess();

            return dataAccess.ReturnFilteredAnimals(habitat, species, eats); 
        }
        public void DeleteSelectedAnimal(int selectedanimalid)
        {
            var dataAccess = new DataAccess();
            dataAccess.DeleteAnimal(selectedanimalid);
        }


    }
}
