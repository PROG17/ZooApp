using System.Windows.Forms;
using ZooApp.BusinessLayer;
using ZooApp.ViewModels;

namespace ZooApp.PresentationLayer
{
    public partial class Appointmentform : Form
    {
        public Appointmentform()
        {
            InitializeComponent();
        }
        public Appointmentform(Zoo eskilstunaZoo, AppointmentModel animal)
        {
            InitializeComponent();

            AppDataGridView.DataSource = eskilstunaZoo.GetAnimalAppointments(animal);
            AppDataGridView.Columns[0].Visible = false;
            //dataGridViewChangeAnim.DataSource = eskilstunaZoo.GetSelectedAnimal(animal);
            //dataGridViewChangeAnim.Visible = false;

            //NewNameBox.Text = dataGridViewChangeAnim[1, 0].Value.ToString();
            //NewEatsComboBox.Text = dataGridViewChangeAnim[2, 0].Value.ToString();
            //NewCountryBox.Text = dataGridViewChangeAnim[3, 0].Value.ToString();
            //NewHabitatComboBox.Text = dataGridViewChangeAnim[4, 0].Value.ToString();
            //NewSpeciesComboBox.Text = dataGridViewChangeAnim[5, 0].Value.ToString();
            //NewWeightTextbox.Text = dataGridViewChangeAnim[6, 0].Value.ToString();
        }
    }
}
