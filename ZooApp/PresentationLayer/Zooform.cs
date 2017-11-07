using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //var kategorival = KategoriComboBox.GetItemText(KategoriComboBox.SelectedItem);

            ZooGridViewSök.DataSource = EskilstunaZoo.GetAnimals("");
            //KategoriComboBox.SelectedIndex = -1;
        }

        //Om sökning sker med flera filter, t.ex.miljö och art, ska 
        //sökresultatet returnera de djur som har fått båda träffar.I fallet med 3 filter 
        //så måste det vara 3 träffar för att sökresultatet ska visas.
    }
}
