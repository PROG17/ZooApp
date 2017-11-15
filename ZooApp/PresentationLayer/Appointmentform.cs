using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ZooApp.BusinessLayer;
using ZooApp.ViewModels;

namespace ZooApp.PresentationLayer
{
    public partial class Appointmentform : Form
    {
        public int AppointmentAnimalId { get; set; }

        public Zoo EskilstunaZoo { get; set; }

        public Appointmentform()
        {
            InitializeComponent();
        }
        public Appointmentform(Zoo eskilstunaZoo, AppointmentModel animal)
        {
            InitializeComponent();
            EskilstunaZoo = eskilstunaZoo;
            AppointmentAnimalId = animal.AnimalId;
            AppDataGridView.DataSource = eskilstunaZoo.GetAnimalAppointments(animal);
            AppDataGridView.Columns[0].Visible = false;
            this.Size = new System.Drawing.Size(1000, 600);
            //SelectedMedsDataGridView.DataSource = eskilstunaZoo.GetDiagnosedMedicines(animal.AppointmentId);
            MedicinDataGridView.DataSource = eskilstunaZoo.GetAvailableMedicines(animal);
            

            VetsDataGridView.DataSource = eskilstunaZoo.GetAvailableVets(animal);

        }

        private void AppDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            
            
        }

        private void BookButton_Click(object sender, EventArgs e)
        {
            DateTime datum = DateTime.Parse(DateTimeTextBox.Text);
            
            AppointmentModel newBooking = new AppointmentModel()
            {
                
                AnimalId = this.AppointmentAnimalId,
                BookedDateTime = datum,
                VetId = (int)VetsDataGridView[0, VetsDataGridView.CurrentCell.RowIndex].Value,
                
            };
            
            EskilstunaZoo.BookAppointment(newBooking);
            AppDataGridView.DataSource = EskilstunaZoo.GetAnimalAppointments(new AppointmentModel{AnimalId = newBooking.AnimalId});
            

        }

        private void AddDiagButton_Click(object sender, EventArgs e)
        {
            var selectedAppointmentId = (int)AppDataGridView[1, AppDataGridView.CurrentCell.RowIndex].Value;
            EskilstunaZoo.AddDiagnose(selectedAppointmentId, DiagnoseTextBox.Text);
            AppDataGridView.DataSource = EskilstunaZoo.GetAnimalAppointments(new AppointmentModel() { AnimalId = AppointmentAnimalId });
        }
        
        private void AppDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedAppointmentId = (int)AppDataGridView[1, AppDataGridView.CurrentCell.RowIndex].Value;
            // Show Diagnose description text in description textbox
            if (AppDataGridView[4, AppDataGridView.CurrentCell.RowIndex].Value != null)
            {
                DiagnoseTextBox.Text = AppDataGridView[4, AppDataGridView.CurrentCell.RowIndex].Value.ToString();
            }
                
            else DiagnoseTextBox.Clear();
            if (selectedAppointmentId != 0)
            {
                SelectedMedsDataGridView.DataSource = EskilstunaZoo.GetDiagnosedMedicines(selectedAppointmentId);
                if (SelectedMedsDataGridView.RowCount > 0)
                    SelectedMedsDataGridView.Columns[1].Visible = false;

            }
            else SelectedMedsDataGridView.DataSource = null;
        }

        private void AddMedButton_Click(object sender, EventArgs e)
        {
            var selectedMedicineId = (int)MedicinDataGridView[1, MedicinDataGridView.CurrentCell.RowIndex].Value;
            var selectedAppointmentId = (int) AppDataGridView[1, AppDataGridView.CurrentCell.RowIndex].Value;
            
            EskilstunaZoo.AddMedicines(selectedMedicineId, selectedAppointmentId);
            SelectedMedsDataGridView.DataSource = EskilstunaZoo.GetDiagnosedMedicines(selectedAppointmentId);
            if (SelectedMedsDataGridView.RowCount > 0)
            {
                SelectedMedsDataGridView.Columns[1].Visible = false;
            }
        }

        private void DeleteBookingButton_Click(object sender, EventArgs e)
        {

            var selectedAppointmentId = (int)AppDataGridView[1, AppDataGridView.CurrentCell.RowIndex].Value;

            EskilstunaZoo.RemoveAppointment(selectedAppointmentId);
            AppDataGridView.DataSource =
            EskilstunaZoo.GetAnimalAppointments(new AppointmentModel() {AnimalId = AppointmentAnimalId});

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
