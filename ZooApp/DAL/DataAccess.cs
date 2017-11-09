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

        public BindingList<AnimalModel> GetAnimalsFromDB(string habitat, string species, string eats)
        {
            BindingList<AnimalModel> filteredAnimals = new BindingList<AnimalModel>();

            using (var db = new ZooContext())
            {

                var query = from animalitem in db.Animals
                            where (string.IsNullOrEmpty(habitat) || animalitem.Habitat.Name == habitat) &&
                                  (string.IsNullOrEmpty(species) || animalitem.Species.Name == species) &&
                                  (string.IsNullOrEmpty(eats) || animalitem.Eats == eats)
                            select new AnimalModel
                            {
                                AnimalId = animalitem.AnimalId,
                                Name = animalitem.Name,
                                Weight = animalitem.Weight,
                                Eats = animalitem.Eats,
                                CountryOfOrigin = animalitem.CountryOfOrigin.Name,
                                Species = animalitem.Species.Name
                            };

                filteredAnimals = new BindingList<AnimalModel>(query.ToList());

            }

            return filteredAnimals;
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
            // InsertAnimal
            // UpdateAnimal

            //GetCategories(), which will return information about all of the categories
            //GetProducts(), which will return information about all of the products
            //GetProductsByCategoryID(categoryID), which will return all products that belong to a specified category
            //GetProductByProductID(productID), which will return information about a particular product
        }

        public void AddAnimal(NewAnimal newAnimal)
        {
            using (var db = new ZooContext())
            {
                var country = db.CountryOfOrigins.First(x => x.Name == newAnimal.CountryOfOrigin);
                var habitat = db.Habitats.First(x => x.Name == newAnimal.Habitat);
                var species = db.Specieses.First(x => x.Name == newAnimal.Species);
                var firstparent = db.Animals.First(x => x.AnimalId == newAnimal.Parent1Id);
                var secondparent = db.Animals.First(x => x.AnimalId == newAnimal.Parent2Id);

                Animal newAnimalinstance = new Animal()
                {
                    Name = newAnimal.Name,
                    Eats = newAnimal.Eats,
                    Weight = newAnimal.Weight,
                    CountryOfOrigin = country,
                    Habitat = habitat,
                    Species = species,
                };

                newAnimalinstance.Parents.Add(firstparent);
                newAnimalinstance.Parents.Add(secondparent);
                country.Animals.Add(newAnimalinstance);
                habitat.Animals.Add(newAnimalinstance);
                species.Animals.Add(newAnimalinstance);

                db.Animals.Add(newAnimalinstance);

                db.SaveChanges();
                
            }
        }
    }
}
