using ZooApp.Datacontext;

namespace ZooApp
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ZooContext : DbContext
    {
        // Your context has been configured to use a 'ZooContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ZooApp.ZooContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ZooContext' 
        // connection string in the application configuration file.
        public ZooContext()
            : base("name=ZooContext")
        {
            Database.SetInitializer(new ZooDBInitializer());
        }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<CountryOfOrigin> CountryOfOrigins { get; set; }
        public DbSet<Habitat> Habitats { get; set; }
        public DbSet<Species> Specieses { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Vet> Vets { get; set; }
        public DbSet<Diagnose> Diagnoses { get; set; }
        public DbSet<DiagnoseMedicine> DiagnoseMedicins { get; set; }
        public DbSet<Medicine> Medicins { get; set; }


        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Configure domain classes using modelBuilder here
            modelBuilder.Entity<Animal>()
                .HasMany(x => x.Parents)
                .WithMany()
                .Map(x => x.ToTable("ParentLink"));
            
            modelBuilder.Entity<Animal>()
                .HasRequired<CountryOfOrigin>(s => s.CountryOfOrigin)
                .WithMany(g => g.Animals)
                .HasForeignKey<int>(f => f.CountryOfOriginId);

            modelBuilder.Entity<Animal>()
                .HasRequired<Habitat>(s => s.Habitat)
                .WithMany(g => g.Animals)
                .HasForeignKey<int>(f => f.HabitatId);

            modelBuilder.Entity<Animal>()
                .HasRequired<Species>(s => s.Species)
                .WithMany(g => g.Animals)
                .HasForeignKey<int>(f => f.SpeciesId);

            modelBuilder.Entity<Animal>()
                .HasMany(s => s.Appointments)
                .WithOptional(g => g.Animal)
                .HasForeignKey<int?>(f => f.AnimalId);

            modelBuilder.Entity<Appointment>()
                .HasRequired<Diagnose>(s => s.Diagnose)
                .WithMany(g => g.Appointments)
                .HasForeignKey<int>(f => f.DiagnoseId);

            modelBuilder.Entity<Appointment>()
                .HasRequired<Vet>(s => s.Vet)
                .WithMany(g => g.Appointments)
                .HasForeignKey<int>(f => f.VetId);

            modelBuilder.Entity<DiagnoseMedicine>()
                .HasOptional<Medicine>(s => s.Medicine)
                .WithMany(g => g.DiagnoseMedicines)
                .HasForeignKey<int?>(f => f.MedicineId);

            modelBuilder.Entity<DiagnoseMedicine>()
                .HasOptional<Diagnose>(s => s.Diagnose)
                .WithMany(g => g.DiagnoseMedicines)
                .HasForeignKey<int?>(f => f.DiagnoseId);










        }
        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name2 { get; set; }
    //}
}