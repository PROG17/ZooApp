using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooApp.DAL;
using ZooApp.ViewModels;

namespace ZooApp.BusinessLayer
{
    public class Zoo
    {
        public BindingList<AnimalModel> GetAnimals(string habitat, string species, string eats)
        {
            var dataAccess = new DataAccess();

            return dataAccess.GetAnimalsFromDB(habitat, species, eats); 
        }
        public void DeleteSelectedAnimal(int selectedanimalid)
        {
            var dataAccess = new DataAccess();
            dataAccess.DeleteAnimal(selectedanimalid);
        }
        public void AddNewAnimal(NewAnimal newAnimal)
        {
            var dataAccess = new DataAccess();
            dataAccess.AddAnimal(newAnimal);
        }



    }
}
