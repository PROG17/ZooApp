using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ZooApp.BusinessLayer;
using ZooApp.ViewModels;

namespace ZooApp.PresentationLayer
{
    public partial class Appointmentform : Form
    {
        public int AnimalId { get; set; }

        public Appointmentform()
        {
            InitializeComponent();
        }
        public Appointmentform(Zoo eskilstunaZoo, AppointmentModel animal)
        {
            InitializeComponent();
            AnimalId = animal.AnimalId;
            AppDataGridView.DataSource = eskilstunaZoo.GetAnimalAppointments(animal);
            AppDataGridView.Columns[0].Visible = false;
            MedicinDataGridView.DataSource = eskilstunaZoo.GetAvailableMedicines(animal);
            //DateTime datum = DateTime.Parse(AppDataGridView.CurrentCell.Value.ToString());

            VetsDataGridView.DataSource = eskilstunaZoo.GetAvailableVets(animal);

            //dataGridViewChangeAnim.DataSource = eskilstunaZoo.GetSelectedAnimal(animal);
            //dataGridViewChangeAnim.Visible = false;

            //NewNameBox.Text = dataGridViewChangeAnim[1, 0].Value.ToString();
            //NewEatsComboBox.Text = dataGridViewChangeAnim[2, 0].Value.ToString();
            //NewCountryBox.Text = dataGridViewChangeAnim[3, 0].Value.ToString();
            //NewHabitatComboBox.Text = dataGridViewChangeAnim[4, 0].Value.ToString();
            //NewSpeciesComboBox.Text = dataGridViewChangeAnim[5, 0].Value.ToString();
            //NewWeightTextbox.Text = dataGridViewChangeAnim[6, 0].Value.ToString();
        }

        private void AppDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            Zoo nyttZoo = new Zoo();
            
        }

        private void BookButton_Click(object sender, EventArgs e)
        {
            DateTime datum = DateTime.Parse(DateTimeTextBox.Text);
            
            AppointmentModel newBooking = new AppointmentModel()
            {
                
                AnimalId = this.AnimalId,
                BookedDateTime = datum,
                VetId = (int)VetsDataGridView[0, VetsDataGridView.CurrentCell.RowIndex].Value,
                
            };
            Zoo kolmorden = new Zoo();
            kolmorden.BookAppointment(newBooking);
            AppDataGridView.DataSource = kolmorden.GetAnimalAppointments(new AppointmentModel{AnimalId = newBooking.AnimalId});
            

        }

        private void AddDiagButton_Click(object sender, EventArgs e)
        {
            Zoo zoot = new Zoo();
            zoot.AddDiagnose((int)AppDataGridView[1, AppDataGridView.CurrentCell.RowIndex].Value, DiagnoseTextBox.Text);
        }
        
        private void AppDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void AddMedButton_Click(object sender, EventArgs e)
        {
            var selectedMedicineId = (int)MedicinDataGridView[1, MedicinDataGridView.CurrentCell.RowIndex].Value;
            var selectedAppointmentId = (int) AppDataGridView[1, AppDataGridView.CurrentCell.RowIndex].Value;
            Zoo zootropolis = new Zoo();
            zootropolis.AddMedicines(selectedMedicineId, selectedAppointmentId);
        }
    }
}
