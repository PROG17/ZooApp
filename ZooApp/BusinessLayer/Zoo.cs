using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooApp.DAL;

namespace ZooApp.BusinessLayer
{
    public class Zoo
    {
        public BindingList<Models.AnimalModel> GetAnimals(string kategorival)
        {
            var dataAccess = new DataAccess();
            if (kategorival == null || kategorival == "")
                return dataAccess.ReturnAllAnimals();
            return dataAccess.ReturnAllAnimals(); 
        }
    }
}
