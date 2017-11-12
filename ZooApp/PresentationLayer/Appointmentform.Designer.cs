namespace ZooApp.PresentationLayer
{
    partial class Appointmentform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.VetsDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.AppDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.DiagnosDataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.MedicinDataGridView = new System.Windows.Forms.DataGridView();
            this.Mediciner = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VetsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedicinDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // VetsDataGridView
            // 
            this.VetsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VetsDataGridView.Location = new System.Drawing.Point(459, 52);
            this.VetsDataGridView.Name = "VetsDataGridView";
            this.VetsDataGridView.Size = new System.Drawing.Size(240, 150);
            this.VetsDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(457, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vetrinärer";
            // 
            // AppDataGridView
            // 
            this.AppDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppDataGridView.Location = new System.Drawing.Point(44, 52);
            this.AppDataGridView.Name = "AppDataGridView";
            this.AppDataGridView.Size = new System.Drawing.Size(240, 150);
            this.AppDataGridView.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Besök";
            // 
            // DiagnosDataGridView
            // 
            this.DiagnosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DiagnosDataGridView.Location = new System.Drawing.Point(44, 285);
            this.DiagnosDataGridView.Name = "DiagnosDataGridView";
            this.DiagnosDataGridView.Size = new System.Drawing.Size(240, 150);
            this.DiagnosDataGridView.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Diagnos";
            // 
            // MedicinDataGridView
            // 
            this.MedicinDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedicinDataGridView.Location = new System.Drawing.Point(459, 285);
            this.MedicinDataGridView.Name = "MedicinDataGridView";
            this.MedicinDataGridView.Size = new System.Drawing.Size(240, 150);
            this.MedicinDataGridView.TabIndex = 6;
            // 
            // Mediciner
            // 
            this.Mediciner.AutoSize = true;
            this.Mediciner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mediciner.Location = new System.Drawing.Point(457, 254);
            this.Mediciner.Name = "Mediciner";
            this.Mediciner.Size = new System.Drawing.Size(106, 25);
            this.Mediciner.TabIndex = 7;
            this.Mediciner.Text = "Mediciner";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(459, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Lägg till veterinär";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(459, 451);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Lägg till mediciner";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Appointmentform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 491);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Mediciner);
            this.Controls.Add(this.MedicinDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DiagnosDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AppDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VetsDataGridView);
            this.Name = "Appointmentform";
            this.Text = "Book Appointment";
            ((System.ComponentModel.ISupportInitialize)(this.VetsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedicinDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView VetsDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView AppDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DiagnosDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView MedicinDataGridView;
        private System.Windows.Forms.Label Mediciner;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}