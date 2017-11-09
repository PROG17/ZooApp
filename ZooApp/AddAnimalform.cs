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
            ParentsListBox.DataSource = eskilstunaZoo.GetAnimals("", "", "");
            ParentsListBox.ValueMember = "AnimalId";
            ParentsListBox.DisplayMember = "Name";
        }

        private void AddAnimalform_Load(object sender, EventArgs e)
        {
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //if (ParentsListBox. )
            //    ParentsListBox.SelectedIndex = -1;
            NewAnimal newAnimal = new NewAnimal();
            newAnimal.CountryOfOrigin = NewCountryBox.GetItemText(NewCountryBox.SelectedItem);
            newAnimal.Eats = NewEatsComboBox.GetItemText(NewEatsComboBox.SelectedItem);
            newAnimal.Habitat = NewHabitatComboBox.GetItemText(NewHabitatComboBox.SelectedItem);
            newAnimal.Name = NewNameBox.Text;
            newAnimal.Weight = int.Parse(NewWeightTextbox.Text);
            newAnimal.Species = NewSpeciesComboBox.GetItemText(NewSpeciesComboBox.SelectedItem);
            //newAnimal.Parent1Id = ParentsListBox.;
            //newAnimal.Parent1Id = ParentsListBox.sel
            newAnimal.Parent1Id = 1; //ParentsListBox.SelectedIndices[0];
            newAnimal.Parent2Id = 2;

            Zoo nyttZoo = new Zoo();
            nyttZoo.AddNewAnimal(newAnimal);

        }
    }
}
