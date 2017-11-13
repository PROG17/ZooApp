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

            return dataAccess.GetAnimalsFromDb(animalData); 
        }
        public BindingList<AnimalModel> GetSelectedAnimal(AnimalModel animalData)
        {
            var dataAccess = new DataAccess();

            return dataAccess.GetAnimalFromDb(animalData);
        }

        public BindingList<AppointmentModel> GetAnimalAppointments(AppointmentModel animalData)
        {
            var dataAccess = new DataAccess();

            return dataAccess.GetAppointmentsFromDb(animalData);
        }
        public BindingList<Vetmodel> GetAvailableVets(AppointmentModel animalData)
        {
            var dataAccess = new DataAccess();

            return dataAccess.GetVetsFromDb(animalData);
        }
        public BindingList<MedicinModel> GetAvailableMedicines(AppointmentModel appointmentData)
        {
            var dataAccess = new DataAccess();

            return dataAccess.GetMedicinsFromDb(appointmentData);
        }

        public void DeleteSelectedAnimal(int selectedanimalid)
        {
            var dataAccess = new DataAccess();
            dataAccess.DeleteAnimal(selectedanimalid);
        }
        public void AddOrChangeAnimal(AnimalModel newAnimal)
        {
            var dataAccess = new DataAccess();
            dataAccess.AddOrChangeAnimalInDb(newAnimal);
        }
        public void BookAppointment(AppointmentModel newAppointment)
        {
            var dataAccess = new DataAccess();
            dataAccess.AddBookingInDb(newAppointment);
        }
        public void AddDiagnose(int appointmentId, string desc)
        {
            var dataAccess = new DataAccess();
            dataAccess.AddDiagnoseInDb(appointmentId, desc);
        }
        public void AddMedicines(int medicineId, int appointmentId)
        {
            var dataAccess = new DataAccess();

            dataAccess.AddMedicineInDb(medicineId, appointmentId);
        }
    }
}
