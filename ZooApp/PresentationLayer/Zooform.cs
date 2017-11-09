using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooApp.ViewModels;

namespace ZooApp
{
    public partial class Zooform : Form
    {
        public BusinessLayer.Zoo EskilstunaZoo { get; set; } = new BusinessLayer.Zoo();

        public Zooform()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var habitatSelection = HabitatComboBox.GetItemText(HabitatComboBox.SelectedItem);
            var speciesSelection = SpeciesComboBox.GetItemText(SpeciesComboBox.SelectedItem);
            var eatsSelection = EatsComboBox.GetItemText(EatsComboBox.SelectedItem);

            ZooGridViewSök.DataSource = EskilstunaZoo.GetAnimals(habitatSelection, speciesSelection, eatsSelection);
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
            
        }

        private void AddAnimalButton_Click(object sender, EventArgs e)
        {
            
            var addNewAnimalForm = new AddAnimalform(EskilstunaZoo);
            addNewAnimalForm.ShowDialog();

        }
    }

        //Om sökning sker med flera filter, t.ex.miljö och art, ska 
        //sökresultatet returnera de djur som har fått båda träffar.I fallet med 3 filter 
        //så måste det vara 3 träffar för att sökresultatet ska visas.
    
}
