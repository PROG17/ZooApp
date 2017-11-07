using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp.Datacontext
{
    class ZooDBInitializer : DropCreateDatabaseAlways<ZooContext>
    {
        protected override void Seed(ZooContext ctx)
        {
            CountryOfOrigin sverige = new CountryOfOrigin(){Name = "Sverige"};
            Habitat mark = new Habitat(){Name = "Mark"};
            Species gris = new Species(){Name = "Gris"};
            
            Animal grisbarn = new Animal() {Name = "Greger", Eats = "Gräs", Weight = 100};
            Animal grismamma = new Animal() { Name = "Berta", Eats = "Gräs", Weight = 150 };
            Animal grispappa = new Animal() { Name = "Bertil", Eats = "Gräs", Weight = 200 };

            grisbarn.Parents.Add(grismamma);
            grisbarn.Parents.Add(grispappa);

            mark.Animals.Add(grisbarn);
            mark.Animals.Add(grismamma);
            mark.Animals.Add(grispappa);

            gris.Animals.Add(grisbarn);
            gris.Animals.Add(grismamma);
            gris.Animals.Add(grispappa);

            sverige.Animals.Add(grisbarn);
            sverige.Animals.Add(grismamma);
            sverige.Animals.Add(grispappa);

            ctx.CountryOfOrigins.Add(sverige);
            ctx.Habitats.Add(mark);
            ctx.CountryOfOrigins.Add(sverige);
            ctx.Specieses.Add(gris);
            

            ////ctx.SaveChanges();
            base.Seed(ctx);



        }
    }
}
