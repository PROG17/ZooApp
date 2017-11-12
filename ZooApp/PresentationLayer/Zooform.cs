using System;
using System.Windows.Forms;
using ZooApp.PresentationLayer;
using ZooApp.ViewModels;

namespace ZooApp
{
    public partial class Zooform : Form
    {
        public BusinessLayer.Zoo EskilstunaZoo { get; set; } = new BusinessLayer.Zoo();

        public Zooform()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(1000, 400);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var habitatSelection = HabitatComboBox.GetItemText(HabitatComboBox.SelectedItem);
            var speciesSelection = SpeciestextBox.Text;

            if (SpeciesComboBox.SelectedIndex > -1)
            {
                speciesSelection = SpeciesComboBox.GetItemText(SpeciesComboBox.SelectedItem);
            }
            var eatsSelection = EatsComboBox.GetItemText(EatsComboBox.SelectedItem);

            var animalsQuery = new AnimalModel{

                Eats = eatsSelection,
                Species = speciesSelection,
                Habitat = habitatSelection
            };

            ZooGridViewSök.DataSource = EskilstunaZoo.GetSearchedAnimals(animalsQuery);
            HabitatComboBox.SelectedIndex = -1;
            SpeciesComboBox.SelectedIndex = -1;
            EatsComboBox.SelectedIndex = -1;

        }

        private void DeleteAnimalButton_Click(object sender, EventArgs e)
        {
            
            if (ZooGridViewSök.SelectedRows.Count == 1)
            {
                var selectedAnimal = ZooGridViewSök[0, ZooGridViewSök.CurrentCell.RowIndex].Value;
                
                EskilstunaZoo.DeleteSelectedAnimal((int)selectedAnimal);
            }
            ZooGridViewSök.DataSource = EskilstunaZoo.GetSearchedAnimals(new AnimalModel { Habitat = "", Eats = "", Species = "" });

        }

        private void AddAnimalButton_Click(object sender, EventArgs e)
        {
            var addNewAnimalForm = new AddAnimalform(EskilstunaZoo);
            addNewAnimalForm.ShowDialog();

        }

        private void ChangeAnimalButton_Click(object sender, EventArgs e)
        {
            if (ZooGridViewSök.SelectedRows.Count == 1)
            {
                AnimalModel animalToBeChanged = new AnimalModel { AnimalId = (int)(ZooGridViewSök[0, ZooGridViewSök.CurrentCell.RowIndex].Value)};
                var changeAnimalForm = new AddAnimalform(EskilstunaZoo, animalToBeChanged);
                changeAnimalForm.ShowDialog();
            }
            
            
        }

        private void BookButton_Click(object sender, EventArgs e)
        {
            if (ZooGridViewSök.SelectedRows.Count == 1)
            {
                AppointmentModel animalToBeBooked = new AppointmentModel { AnimalId = (int)(ZooGridViewSök[0, ZooGridViewSök.CurrentCell.RowIndex].Value) };
                var addNewAppointmentForm = new Appointmentform(EskilstunaZoo, animalToBeBooked);
                addNewAppointmentForm.ShowDialog();
            }
           

        }
    }

        //Om sökning sker med flera filter, t.ex.miljö och art, ska 
        //sökresultatet returnera de djur som har fått båda träffar.I fallet med 3 filter 
        //så måste det vara 3 träffar för att sökresultatet ska visas.
    
}
