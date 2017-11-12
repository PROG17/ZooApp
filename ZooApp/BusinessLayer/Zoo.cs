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
        public BindingList<AnimalModel> GetSearchedAnimals(AnimalModel animalData)
        {
            var dataAccess = new DataAccess();

            return dataAccess.GetAnimalsFromDB(animalData); 
        }
        public BindingList<AnimalModel> GetSelectedAnimal(AnimalModel animalData)
        {
            var dataAccess = new DataAccess();

            return dataAccess.GetAnimalFromDB(animalData);
        }

        public BindingList<AppointmentModel> GetAnimalAppointments(AppointmentModel animalData)
        {
            var dataAccess = new DataAccess();

            return dataAccess.GetAppointmentsFromDB(animalData);
        }

        public void DeleteSelectedAnimal(int selectedanimalid)
        {
            var dataAccess = new DataAccess();
            dataAccess.DeleteAnimal(selectedanimalid);
        }
        public void AddOrChangeAnimal(AnimalModel newAnimal)
        {
            var dataAccess = new DataAccess();
            dataAccess.AddOrChangeAnimalInDB(newAnimal);
        }



    }
}
