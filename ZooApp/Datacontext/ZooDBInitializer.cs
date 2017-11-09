using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooApp.Datacontext
{
    class ZooDBInitializer : DropCreateDatabaseAlways<ZooContext>
    {
        protected override void Seed(ZooContext ctx)
        {
            CountryOfOrigin sverige = new CountryOfOrigin() { Name = "Sverige" };

            CountryOfOrigin uganda = new CountryOfOrigin() { Name = "Uganda" };
            
            Habitat mark = new Habitat() {Name = "Mark"};

            Habitat vatten = new Habitat() { Name = "Vatten" };

            Habitat träd = new Habitat() { Name = "Träd" };

            Species gris = new Species(){Name = "Gris"};

            Species apa = new Species() { Name = "Apa" };


            Animal grisbarn = new Animal()
            {
                Name = "Greger",
                Eats = "Växter",
                Weight = 100,
                CountryOfOrigin = sverige,
                Habitat = mark,
                Species = gris
            };



            Animal apmamma = new Animal()
            {
                Name = "Berta",
                Eats = "Kött",
                Weight = 150,
                CountryOfOrigin = uganda,
                Habitat = träd,
                Species = apa
            };
            Animal appappa = new Animal()
            {
                Name = "Bertil",
                Eats = "Kött",
                Weight = 200,
                CountryOfOrigin = uganda,
                Habitat = träd,
                Species = apa
            };
            Animal apbarn = new Animal()
            {
                Name = "Svea",
                Eats = "Kött",
                Weight = 40,
                CountryOfOrigin = uganda,
                Habitat = träd,
                Species = apa
            };

            apbarn.Parents.Add(apmamma);
            apbarn.Parents.Add(appappa);
            grisbarn.Parents.Add(apmamma);
            grisbarn.Parents.Add(appappa);

            mark.Animals.Add(grisbarn);

            gris.Animals.Add(grisbarn);
            apa.Animals.Add(apbarn);
            apa.Animals.Add(apmamma);
            apa.Animals.Add(appappa);

            sverige.Animals.Add(grisbarn);
            uganda.Animals.Add(apbarn);
            uganda.Animals.Add(appappa);
            uganda.Animals.Add(apmamma);

            ctx.Animals.Add(grisbarn);

            ctx.Animals.Add(apbarn);

            ctx.Animals.Add(apmamma);

            ctx.Animals.Add(appappa);

            ctx.Habitats.Add(mark);
            ctx.Habitats.Add(vatten);
            ctx.Habitats.Add(träd);
            
            ctx.Specieses.Add(gris);
            ctx.Specieses.Add(apa);

            ctx.CountryOfOrigins.Add(sverige);
            ctx.CountryOfOrigins.Add(uganda);

            base.Seed(ctx);
        }
    }
}
