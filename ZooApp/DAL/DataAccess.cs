using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using ZooApp.Datacontext;
using ZooApp.ViewModels;

namespace ZooApp.DAL
{
    class DataAccess
    {

        public BindingList<AnimalModel> GetAnimalsFromDb(AnimalModel animals)
        {
            BindingList<AnimalModel> querriedAnimals = new BindingList<AnimalModel>();
            
            using (var db = new ZooContext())
            {

                var query = (from a in db.Animals
                            where (string.IsNullOrEmpty(animals.Habitat) || a.Habitat.Name == animals.Habitat) &&
                                   (string.IsNullOrEmpty(animals.Species) || a.Species.Name.Contains(animals.Species)) &&
                                   (string.IsNullOrEmpty(animals.Eats) || a.Eats == animals.Eats)
                                    select new 
                                    {
                                          AnimalId = a.AnimalId,
                                          Name = a.Name,
                                          Weight = a.Weight,
                                          Eats = a.Eats,
                                          CountryOfOrigin = a.CountryOfOrigin.Name,
                                          Species = a.Species.Name,
                                          Habitat = a.Habitat.Name,
                                          Parents = a.Parents
                                      }).ToList();

                foreach (var b in query)
                {
                    if (b.Parents.Count == 0)
                    {
                        querriedAnimals.Add(new AnimalModel
                        {
                            AnimalId = b.AnimalId,
                            Name = b.Name,
                            Weight = b.Weight,
                            Eats = b.Eats,
                            CountryOfOrigin = b.CountryOfOrigin,
                            Species = b.Species,
                            Habitat = b.Habitat,
                            Parent1Id = null,
                            Parent2Id = null
                        });
                    }
                    if (b.Parents.Count == 1)
                    {
                        querriedAnimals.Add(new AnimalModel
                        {
                            AnimalId = b.AnimalId,
                            Name = b.Name,
                            Weight = b.Weight,
                            Eats = b.Eats,
                            CountryOfOrigin = b.CountryOfOrigin,
                            Species = b.Species,
                            Habitat = b.Habitat,
                            Parent1Id = b.Parents.ElementAt(0).AnimalId,
                            Parent2Id = null
                        });
                    }
                    if (b.Parents.Count == 2)
                    {
                        querriedAnimals.Add(new AnimalModel
                        {
                            AnimalId = b.AnimalId,
                            Name = b.Name,
                            Weight = b.Weight,
                            Eats = b.Eats,
                            CountryOfOrigin = b.CountryOfOrigin,
                            Species = b.Species,
                            Habitat = b.Habitat,
                            Parent1Id = b.Parents.ElementAt(0).AnimalId,
                            Parent2Id = b.Parents.ElementAt(1).AnimalId
                        });
                    }
                }

             }

            return querriedAnimals;
        }
        public BindingList<Vetmodel> GetVetsFromDb(AppointmentModel animals)
        {
            BindingList<Vetmodel> querriedVets = new BindingList<Vetmodel>();

            using (var db = new ZooContext())
            {
                var availableVets = db.Vets
                    .Select(v => new ViewModels.Vetmodel {VetName = v.VetName, VetId = v.VetId}).ToList();
               querriedVets = new BindingList<Vetmodel>(availableVets);
            }

            return querriedVets;
        }
        public BindingList<MedicinModel> GetMedicinsFromDb(AppointmentModel appointmentdata)
        {
            BindingList<MedicinModel> querriedMedicines = new BindingList<MedicinModel>();

            using (var db = new ZooContext())
            {
                var query = db.Medicins
                    .Select(m => new MedicinModel {Name = m.Name, MedicineId = m.MedicineId}).ToList();
                querriedMedicines = new BindingList<MedicinModel>(query);
            }

            return querriedMedicines;
        }
        public BindingList<AppointmentModel> GetAppointmentsFromDb(AppointmentModel animal)
        {
            BindingList<AppointmentModel> querriedAppointments = new BindingList<AppointmentModel>();

            using (var db = new ZooContext())
            {
                //var appointmentdiagnose = db.Diagnoses.FirstOrDefault(x => x.Appointments.FirstOrDefault(y => y.AppointmentId == animal.AppointmentId)); 
                    //.Local.First(x => x.AnimalId == selectedanimalid);

                var query = from a in db.Appointments
                             where (a.AnimalId == animal.AnimalId)                                   
                             select new AppointmentModel
                             {
                                 AnimalId = a.AnimalId,
                                 VetName = a.Vet.VetName,
                                 BookedDateTime = a.DateTime,
                                 Diagnose = a.Diagnose.Description,
                                 AppointmentId = a.AppointmentId
                             };



                querriedAppointments = new BindingList<AppointmentModel>(query.ToList());

            }

            return querriedAppointments;
        }
        public BindingList<AnimalModel> GetAnimalFromDb(AnimalModel animal)
        {
            BindingList<AnimalModel> animalToBeChanged = new BindingList<AnimalModel>();

            using (var db = new ZooContext())
            {

                var query = (from a in db.Animals
                            where a.AnimalId == animal.AnimalId
                            select new 
                            {
                                AnimalId = a.AnimalId,
                                Name = a.Name,
                                Weight = a.Weight,
                                Eats = a.Eats,
                                Habitat = a.Habitat.Name,
                                CountryOfOrigin = a.CountryOfOrigin.Name,
                                Species = a.Species.Name,
                                Parents = a.Parents
                            }).ToList();

                foreach (var b in query)
                {
                    if (b.Parents.Count == 0)
                    {
                        animalToBeChanged.Add(new AnimalModel
                        {
                            AnimalId = b.AnimalId,
                            Name = b.Name,
                            Weight = b.Weight,
                            Eats = b.Eats,
                            CountryOfOrigin = b.CountryOfOrigin,
                            Species = b.Species,
                            Habitat = b.Habitat,
                            Parent1Id = null,
                            Parent2Id = null
                        });
                    }
                    if (b.Parents.Count == 1)
                    {
                        animalToBeChanged.Add(new AnimalModel
                        {
                            AnimalId = b.AnimalId,
                            Name = b.Name,
                            Weight = b.Weight,
                            Eats = b.Eats,
                            CountryOfOrigin = b.CountryOfOrigin,
                            Species = b.Species,
                            Habitat = b.Habitat,
                            Parent1Id = b.Parents.ElementAt(0).AnimalId,
                            Parent2Id = null
                        });
                    }
                    if (b.Parents.Count == 2)
                    {
                        animalToBeChanged.Add(new AnimalModel
                        {
                            AnimalId = b.AnimalId,
                            Name = b.Name,
                            Weight = b.Weight,
                            Eats = b.Eats,
                            CountryOfOrigin = b.CountryOfOrigin,
                            Species = b.Species,
                            Habitat = b.Habitat,
                            Parent1Id = b.Parents.ElementAt(0).AnimalId,
                            Parent2Id = b.Parents.ElementAt(1).AnimalId
                        });
                    }
                }

            }

            return animalToBeChanged;
        }

        public void DeleteAnimal(int selectedanimalid)
        {
            using (var db = new ZooContext())
            {
                var animalToBeDeleted = db.Animals.First(x => x.AnimalId == selectedanimalid);

                var childrenOfAnimalToBeDeleted = db.Animals.Where(x => x.Parents.Any(s => s.AnimalId == selectedanimalid));

                if (childrenOfAnimalToBeDeleted.Count() > 0)
                { 
                    foreach (var item in childrenOfAnimalToBeDeleted)
                    {
                        item.Parents.Remove(animalToBeDeleted);
                    }
                }
                animalToBeDeleted.Parents.Clear(); 
                db.Animals.Remove(animalToBeDeleted);
                db.SaveChanges();
                
                

                
            }
            
        }

        public void AddOrChangeAnimalInDb(AnimalModel newAnimal)
        {
            using (var db = new ZooContext())
            {
                var country = db.CountryOfOrigins.First(x => x.Name == newAnimal.CountryOfOrigin);
                var habitat = db.Habitats.First(x => x.Name == newAnimal.Habitat);
                var species = db.Specieses.First(x => x.Name == newAnimal.Species);
                var firstparent = db.Animals.FirstOrDefault(x => x.AnimalId == newAnimal.Parent1Id);
                var secondparent = db.Animals.FirstOrDefault(x => x.AnimalId == newAnimal.Parent2Id);
                var changedAnimal = db.Animals.FirstOrDefault(x => x.AnimalId == newAnimal.AnimalId);

                if (!db.Animals.Any(x => x.AnimalId == newAnimal.AnimalId))
                {
                    Animal newAnimalinstance = new Animal()
                    {
                        Name = newAnimal.Name,
                        Eats = newAnimal.Eats,
                        Weight = newAnimal.Weight,
                        CountryOfOrigin = country,
                        Habitat = habitat,
                        Species = species,
                    };
                    if (secondparent != null && firstparent != null)
                    {
                        newAnimalinstance.Parents.Add(firstparent);
                        newAnimalinstance.Parents.Add(secondparent);
                    }
                    else if (firstparent == null)
                    {
                        newAnimalinstance.Parents.Add(secondparent);
                    }
                    else if (secondparent == null)
                    {
                        newAnimalinstance.Parents.Add(firstparent);
                    }
                    country.Animals.Add(newAnimalinstance);
                    habitat.Animals.Add(newAnimalinstance);
                    species.Animals.Add(newAnimalinstance);

                    db.Animals.Add(newAnimalinstance);

                }
                else
                {
                    changedAnimal.CountryOfOrigin.Name = newAnimal.CountryOfOrigin;
                    changedAnimal.Habitat.Name = newAnimal.Habitat;
                    changedAnimal.Eats = newAnimal.Eats;
                    changedAnimal.Species.Name = newAnimal.Species;
                    changedAnimal.Weight = newAnimal.Weight;
                    changedAnimal.Name = newAnimal.Name;
                }

                db.SaveChanges();
                
            }
        
        }
        public void AddBookingInDb(AppointmentModel newAppointment)
        {
            using (var db = new ZooContext())
            {
                
                var appointmentVet = db.Vets.First(x => x.VetId == newAppointment.VetId);
                var appointmentAnimal = db.Animals.First(x => x.AnimalId == newAppointment.AnimalId);
                

                Appointment newApp = new Appointment()
                {
                    Animal = appointmentAnimal,
                    AnimalId = appointmentAnimal.AnimalId,
                    DateTime = newAppointment.BookedDateTime,
                    Vet = appointmentVet,
                    VetId = appointmentVet.VetId
                };

                appointmentAnimal.Appointments.Add(newApp);
                appointmentVet.Appointments.Add(newApp);

                db.Appointments.Add(newApp);


                db.SaveChanges();

            }

        }
        public void AddDiagnoseInDb(int appointmentId, string desc)
        {
            using (var db = new ZooContext())
            {

                var appointment = db.Appointments.First(x => x.AppointmentId == appointmentId);
                
                if (db.Diagnoses.Any(x => x.Description == desc))
                {
                    var appointmentdiagnose = new Diagnose();
                    appointmentdiagnose = db.Diagnoses.First(x => x.Description == desc);
                    appointmentdiagnose.Appointments.Add(appointment);
                }
                else
                {
                    Diagnose newDiag = new Diagnose()
                    {
                        Description = desc

                    };
                    newDiag.Appointments.Add(appointment);
                    appointment.Diagnose = newDiag;

                }
                

            

                //appointmentAnimal.Appointments.Add(newApp);
                //appointmentVet.Appointments.Add(newApp);

                //db.Appointments.Add(newApp);


                db.SaveChanges();

            }

        }
        public void AddMedicineInDb(int medicineId, int appointmentId)
        {
            

            using (var db = new ZooContext())
            {
                var currentDiagnose =
                    db.Diagnoses.First(x => x.Appointments.Any(y => y.AppointmentId == appointmentId));
                var appointment = db.Appointments.First(x => x.AppointmentId == appointmentId);
                var currentMedicine = db.Medicins.First(x => x.MedicineId == medicineId);

                if (!db.DiagnoseMedicins.Any(x =>
                    x.DiagnoseId == currentDiagnose.DiagnoseId && x.MedicineId == currentMedicine.MedicineId))
                {
                    DiagnoseMedicine newDiagMed = new DiagnoseMedicine()
                    {
                        Diagnose = currentDiagnose,
                        Medicine = currentMedicine

                    };
                    currentDiagnose.DiagnoseMedicines.Add(newDiagMed);
                    currentMedicine.DiagnoseMedicines.Add(newDiagMed);
                    db.SaveChanges();
                }
                    
                

            }

        }
    }
}
