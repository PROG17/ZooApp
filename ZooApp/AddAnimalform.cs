using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ZooApp.BusinessLayer;
using ZooApp.ViewModels;

namespace ZooApp
{
    public partial class AddAnimalform : Form
    {
        public AddAnimalform(Zoo eskilstunaZoo)
        {
            InitializeComponent();
            ParentsdataGridView.DataSource = eskilstunaZoo.GetAnimals("", "", "");
        }

        private void AddAnimalform_Load(object sender, EventArgs e)
        {
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {



            NewAnimal newAnimal = new NewAnimal();
            newAnimal.CountryOfOrigin = NewCountryBox.GetItemText(NewCountryBox.SelectedItem);
            newAnimal.Eats = NewEatsComboBox.GetItemText(NewEatsComboBox.SelectedItem);
            newAnimal.Habitat = NewHabitatComboBox.GetItemText(NewHabitatComboBox.SelectedItem);
            newAnimal.Name = NewNameBox.Text;
            newAnimal.Weight = int.Parse(NewWeightTextbox.Text);
            newAnimal.Species = NewSpeciesComboBox.GetItemText(NewSpeciesComboBox.SelectedItem);
            
            newAnimal.Parent1Id = int.Parse(Parent1TextBox.Text);
            newAnimal.Parent2Id = int.Parse(Parent2TextBox.Text);

            Zoo nyttZoo = new Zoo();
            nyttZoo.AddNewAnimal(newAnimal);

        }
    }
}
