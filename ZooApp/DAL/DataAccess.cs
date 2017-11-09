using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Validation;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooApp.Models;

namespace ZooApp.DAL
{
    class DataAccess
    {

        public BindingList<Models.AnimalModel> ReturnFilteredAnimals(string habitat, string species, string eats)
        {
            BindingList<Models.AnimalModel> filteredAnimals = new BindingList<AnimalModel>();

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

        public void DeleteAnimal(int selectedanimal)
        {
            using (var db = new ZooContext())
            {
                var temp = db.Animals.First(x => x.AnimalId == selectedanimal);
                temp.Habitat = temp.Habitat;
                temp.CountryOfOrigin = temp.CountryOfOrigin;
                temp.Species = temp.Species;

                //db.Animals.Attach(temp);
                db.Animals.Remove(temp);

                db.SaveChanges();
                //try
                //{
                //    var temp = db.Animals.First(x => x.AnimalId == selectedanimal);

                //    //var parent = db.Animals.First(x => x.AnimalId == selectedanimal).Parents;

                //    //temp.Parents = parent;
                //    //var species = temp.Species;
                //    //temp.Species = species;

                //    //db.Animals.Attach(temp);
                //    db.Animals.Remove(temp);
                    
                //    db.SaveChanges();
                //}
                //catch (DbEntityValidationException dbEx)
                //{
                //    foreach (var validationErrors in dbEx.EntityValidationErrors)
                //    {
                //        foreach (var validationError in validationErrors.ValidationErrors)
                //        {
                //            var error = validationError.ErrorMessage;
                //            var error2 = validationError.PropertyName;
                //            //MessageBox.Show(validationError.PropertyName + validationError.ErrorMessage);
                //        }
                //    }
                //}
                

                //var query = from a in db.Animals
                //            where (string.IsNullOrEmpty(habitat) || a.Habitat.Name == habitat) &&
                //                  (string.IsNullOrEmpty(species) || a.Species.Name == species) &&
                //                  (string.IsNullOrEmpty(eats) || a.Eats == eats)
                //            select a;






            }
            // InsertAnimal
            // UpdateAnimal

            //GetCategories(), which will return information about all of the categories
            //GetProducts(), which will return information about all of the products
            //GetProductsByCategoryID(categoryID), which will return all products that belong to a specified category
            //GetProductByProductID(productID), which will return information about a particular product
        }

        public void AddAnimal()
        {
            
        }
    }
}
