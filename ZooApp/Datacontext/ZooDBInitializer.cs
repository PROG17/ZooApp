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

            CountryOfOrigin thailand = new CountryOfOrigin() { Name = "Thailand" };

            CountryOfOrigin australien = new CountryOfOrigin() { Name = "Australien" };


            Habitat mark = new Habitat() { Name = "Mark" };

            Habitat vatten = new Habitat() { Name = "Vatten" };

            Habitat träd = new Habitat() { Name = "Träd" };

            Species gris = new Species() { Name = "Gris" };

            Species apa = new Species() { Name = "Apa" };

            Species lejon = new Species() { Name = "Lejon" };

            Species fågel = new Species() { Name = "Fågel" };

            Species orm = new Species() { Name = "Orm" };

            Vet gunnar = new Vet() { VetName = "Gunnar" };
            Vet karin = new Vet() { VetName = "Karin" };
            Vet tyko = new Vet() { VetName = "Tyko" };

            Medicine panodil = new Medicine() { Name = "Panodil" };
            Medicine abinex = new Medicine() { Name = "Abinex" };
            Medicine dalmeralin = new Medicine() { Name = "Dalmeralin" };
            Medicine halothane = new Medicine() { Name = "Halothane" };
            Medicine panacur = new Medicine() { Name = "Panacur" };

            Appointment tisdag = new Appointment() { DateTime = new DateTime(2017, 11, 25, 13, 0, 0) };

            Diagnose huvudvärk = new Diagnose() {Description = "Huvudvärk"};

            DiagnoseMedicine diagnosmedicinkoppling = new DiagnoseMedicine() { Diagnose = huvudvärk, Medicine = panacur };


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

            tisdag.Animal = grisbarn;
            tisdag.Diagnose = huvudvärk;
            tisdag.Vet = tyko;

            tyko.Appointments.Add(tisdag);
            grisbarn.Appointments.Add(tisdag);

            huvudvärk.Appointments.Add(tisdag);
            huvudvärk.DiagnoseMedicines.Add(diagnosmedicinkoppling);

            diagnosmedicinkoppling.Diagnose = huvudvärk;
            diagnosmedicinkoppling.Medicine = panacur;

            panacur.DiagnoseMedicines.Add(diagnosmedicinkoppling);



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
            ctx.Specieses.Add(lejon);
            ctx.Specieses.Add(orm);
            ctx.Specieses.Add(fågel);

            ctx.CountryOfOrigins.Add(sverige);
            ctx.CountryOfOrigins.Add(uganda);
            ctx.CountryOfOrigins.Add(thailand);
            ctx.CountryOfOrigins.Add(australien);

            ctx.Appointments.Add(tisdag);
            ctx.Vets.Add(tyko);
            ctx.Vets.Add(karin);
            ctx.Vets.Add(gunnar);

            ctx.Diagnoses.Add(huvudvärk);
            ctx.DiagnoseMedicins.Add(diagnosmedicinkoppling);
            ctx.Medicins.Add(panacur);
            ctx.Medicins.Add(panodil);
            ctx.Medicins.Add(abinex);
            ctx.Medicins.Add(dalmeralin);
            ctx.Medicins.Add(halothane);

            base.Seed(ctx);
        }
    }
}
