using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooApp.Models;

namespace ZooApp.DAL
{
    class DataAccess
    {
        // GetAnimals()
        public BindingList<Models.AnimalModel> ReturnAllAnimals()
        {
            BindingList<Models.AnimalModel> querriedanimals = new BindingList<AnimalModel>();

            using (var db = new ZooContext())
            {
               

                    foreach (var animalitem in db.Animals)
                    {
                        querriedanimals.Add(new AnimalModel()
                        {
                            AnimalId = animalitem.AnimalId,
                            Name = animalitem.Name,
                            Weight = animalitem.Weight,
                            Eats = animalitem.Eats
                        });
                    }
                

            }
            return querriedanimals;
        }
        //GetCategories(), which will return information about all of the categories
        //GetProducts(), which will return information about all of the products
        //GetProductsByCategoryID(categoryID), which will return all products that belong to a specified category
        //GetProductByProductID(productID), which will return information about a particular product
    }
}
