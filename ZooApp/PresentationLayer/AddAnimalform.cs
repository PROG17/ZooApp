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
            ParentsdataGridView.DataSource = eskilstunaZoo.GetSearchedAnimals(new AnimalModel {Habitat = "", Eats = "", Species = "" });
            dataGridViewChangeAnim.Visible = false;
            this.Text = "Lägg till nytt djur";
        }
        public AddAnimalform(Zoo eskilstunaZoo, AnimalModel animal)
        {
            InitializeComponent();
            ParentsdataGridView.Visible = false;
            Parent1TextBox.Visible = false;
            Parent2TextBox.Visible = false;
            this.Text = "Ändra djur";
            
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;

            
            dataGridViewChangeAnim.DataSource = eskilstunaZoo.GetSelectedAnimal(animal);
            dataGridViewChangeAnim.Visible = false;

            NewNameBox.Text = dataGridViewChangeAnim[1, 0].Value.ToString();
            NewEatsComboBox.Text = dataGridViewChangeAnim[2, 0].Value.ToString();
            NewCountryBox.Text = dataGridViewChangeAnim[3, 0].Value.ToString();
            NewHabitatComboBox.Text = dataGridViewChangeAnim[4, 0].Value.ToString();
            NewSpeciesComboBox.Text = dataGridViewChangeAnim[5, 0].Value.ToString();
            NewWeightTextbox.Text = dataGridViewChangeAnim[6, 0].Value.ToString();
        }

        private void AddAnimalform_Load(object sender, EventArgs e)
        {
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            


            AnimalModel newAnimalData = new AnimalModel();
            if (this.Text == "Ändra djur") // Används för att kolla om det är ett nytt djur eller om ett befintlig djur ska ändras
            {
                newAnimalData.AnimalId = (int)dataGridViewChangeAnim[0, 0].Value;
            }
            newAnimalData.CountryOfOrigin = NewCountryBox.GetItemText(NewCountryBox.SelectedItem);
            newAnimalData.Eats = NewEatsComboBox.GetItemText(NewEatsComboBox.SelectedItem);
            newAnimalData.Habitat = NewHabitatComboBox.GetItemText(NewHabitatComboBox.SelectedItem);
            newAnimalData.Name = NewNameBox.Text;
            newAnimalData.Weight = int.Parse(NewWeightTextbox.Text);
            newAnimalData.Species = NewSpeciesComboBox.GetItemText(NewSpeciesComboBox.SelectedItem);
            if (!string.IsNullOrEmpty(Parent1TextBox.Text))
            {
                newAnimalData.Parent1Id = int.Parse(Parent1TextBox.Text);
            }
            else newAnimalData.Parent1Id = 0;
            if (!string.IsNullOrEmpty(Parent2TextBox.Text))
            {
                newAnimalData.Parent2Id = int.Parse(Parent2TextBox.Text);
            }
            else newAnimalData.Parent2Id = 0;

            Zoo nyttZoo = new Zoo();
            nyttZoo.AddOrChangeAnimal(newAnimalData);

        }
        
    }
}
