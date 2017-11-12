using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Validation;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooApp.Datacontext;
using ZooApp.ViewModels;

namespace ZooApp.DAL
{
    class DataAccess
    {

        public BindingList<AnimalModel> GetAnimalsFromDB(AnimalModel animals)
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
        public BindingList<AppointmentModel> GetAppointmentsFromDB(AppointmentModel animal)
        {
            BindingList<AppointmentModel> querriedAppointments = new BindingList<AppointmentModel>();

            using (var db = new ZooContext())
            {

                var query = from a in db.Appointments
                             where (a.AnimalId == animal.AnimalId)                                   
                             select new AppointmentModel
                             {
                                 VetName = a.Vet.VetName,
                                 BookedDateTime = a.DateTime
                             };

                //foreach (var b in query)
                //{
                //    if (b.Parents.Count == 0)
                //    {
                //        querriedAnimals.Add(new AnimalModel
                //        {
                //            AnimalId = b.AnimalId,
                //            Name = b.Name,
                //            Weight = b.Weight,
                //            Eats = b.Eats,
                //            CountryOfOrigin = b.CountryOfOrigin,
                //            Species = b.Species,
                //            Habitat = b.Habitat,
                //            Parent1Id = null,
                //            Parent2Id = null
                //        });
                //    }
                //    if (b.Parents.Count == 1)
                //    {
                //        querriedAnimals.Add(new AnimalModel
                //        {
                //            AnimalId = b.AnimalId,
                //            Name = b.Name,
                //            Weight = b.Weight,
                //            Eats = b.Eats,
                //            CountryOfOrigin = b.CountryOfOrigin,
                //            Species = b.Species,
                //            Habitat = b.Habitat,
                //            Parent1Id = b.Parents.ElementAt(0).AnimalId,
                //            Parent2Id = null
                //        });
                //    }
                //    if (b.Parents.Count == 2)
                //    {
                //        querriedAnimals.Add(new AnimalModel
                //        {
                //            AnimalId = b.AnimalId,
                //            Name = b.Name,
                //            Weight = b.Weight,
                //            Eats = b.Eats,
                //            CountryOfOrigin = b.CountryOfOrigin,
                //            Species = b.Species,
                //            Habitat = b.Habitat,
                //            Parent1Id = b.Parents.ElementAt(0).AnimalId,
                //            Parent2Id = b.Parents.ElementAt(1).AnimalId
                //        });
                //    }
                //}
                querriedAppointments = new BindingList<AppointmentModel>(query.ToList());

            }

            return querriedAppointments;
        }
        public BindingList<AnimalModel> GetAnimalFromDB(AnimalModel animal)
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

        public void AddOrChangeAnimalInDB(AnimalModel newAnimal)
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
    }
}
