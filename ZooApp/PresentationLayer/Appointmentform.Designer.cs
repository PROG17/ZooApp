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
            this.label3 = new System.Windows.Forms.Label();
            this.MedicinDataGridView = new System.Windows.Forms.DataGridView();
            this.Mediciner = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.BookButton = new System.Windows.Forms.Button();
            this.DiagnoseTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DateTimeTextBox = new System.Windows.Forms.TextBox();
            this.AddMedButton = new System.Windows.Forms.Button();
            this.AddDiagButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SelectedMedsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.VetsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedicinDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedMedsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // VetsDataGridView
            // 
            this.VetsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VetsDataGridView.Location = new System.Drawing.Point(688, 80);
            this.VetsDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VetsDataGridView.Name = "VetsDataGridView";
            this.VetsDataGridView.Size = new System.Drawing.Size(360, 231);
            this.VetsDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(686, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vetrinärer";
            // 
            // AppDataGridView
            // 
            this.AppDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppDataGridView.Location = new System.Drawing.Point(66, 80);
            this.AppDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AppDataGridView.Name = "AppDataGridView";
            this.AppDataGridView.Size = new System.Drawing.Size(360, 231);
            this.AppDataGridView.TabIndex = 2;
            this.AppDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AppDataGridView_CellClick);
            this.AppDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.AppDataGridView_CellValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Besök";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 391);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Diagnos";
            // 
            // MedicinDataGridView
            // 
            this.MedicinDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedicinDataGridView.Location = new System.Drawing.Point(544, 433);
            this.MedicinDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MedicinDataGridView.Name = "MedicinDataGridView";
            this.MedicinDataGridView.Size = new System.Drawing.Size(360, 231);
            this.MedicinDataGridView.TabIndex = 6;
            // 
            // Mediciner
            // 
            this.Mediciner.AutoSize = true;
            this.Mediciner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mediciner.Location = new System.Drawing.Point(537, 379);
            this.Mediciner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Mediciner.Name = "Mediciner";
            this.Mediciner.Size = new System.Drawing.Size(154, 37);
            this.Mediciner.TabIndex = 7;
            this.Mediciner.Text = "Mediciner";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(688, 694);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "Lägg till mediciner";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BookButton
            // 
            this.BookButton.Location = new System.Drawing.Point(497, 207);
            this.BookButton.Name = "BookButton";
            this.BookButton.Size = new System.Drawing.Size(140, 32);
            this.BookButton.TabIndex = 10;
            this.BookButton.Text = "Boka besök";
            this.BookButton.UseVisualStyleBackColor = true;
            this.BookButton.Click += new System.EventHandler(this.BookButton_Click);
            // 
            // DiagnoseTextBox
            // 
            this.DiagnoseTextBox.Location = new System.Drawing.Point(65, 466);
            this.DiagnoseTextBox.Name = "DiagnoseTextBox";
            this.DiagnoseTextBox.Size = new System.Drawing.Size(361, 26);
            this.DiagnoseTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(493, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Datum/tid";
            // 
            // DateTimeTextBox
            // 
            this.DateTimeTextBox.Location = new System.Drawing.Point(497, 158);
            this.DateTimeTextBox.Name = "DateTimeTextBox";
            this.DateTimeTextBox.Size = new System.Drawing.Size(140, 26);
            this.DateTimeTextBox.TabIndex = 14;
            // 
            // AddMedButton
            // 
            this.AddMedButton.Location = new System.Drawing.Point(927, 433);
            this.AddMedButton.Name = "AddMedButton";
            this.AddMedButton.Size = new System.Drawing.Size(109, 52);
            this.AddMedButton.TabIndex = 15;
            this.AddMedButton.Text = "Lägg till mediciner";
            this.AddMedButton.UseVisualStyleBackColor = true;
            this.AddMedButton.Click += new System.EventHandler(this.AddMedButton_Click);
            // 
            // AddDiagButton
            // 
            this.AddDiagButton.Location = new System.Drawing.Point(65, 525);
            this.AddDiagButton.Name = "AddDiagButton";
            this.AddDiagButton.Size = new System.Drawing.Size(155, 73);
            this.AddDiagButton.TabIndex = 16;
            this.AddDiagButton.Text = "Lägg till diagnos";
            this.AddDiagButton.UseVisualStyleBackColor = true;
            this.AddDiagButton.Click += new System.EventHandler(this.AddDiagButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(497, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 36);
            this.button1.TabIndex = 17;
            this.button1.Text = "Ta bort bokning";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SelectedMedsDataGridView
            // 
            this.SelectedMedsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectedMedsDataGridView.Location = new System.Drawing.Point(65, 629);
            this.SelectedMedsDataGridView.Name = "SelectedMedsDataGridView";
            this.SelectedMedsDataGridView.RowTemplate.Height = 28;
            this.SelectedMedsDataGridView.Size = new System.Drawing.Size(361, 150);
            this.SelectedMedsDataGridView.TabIndex = 18;
            // 
            // Appointmentform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 755);
            this.Controls.Add(this.SelectedMedsDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddDiagButton);
            this.Controls.Add(this.AddMedButton);
            this.Controls.Add(this.DateTimeTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DiagnoseTextBox);
            this.Controls.Add(this.BookButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Mediciner);
            this.Controls.Add(this.MedicinDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AppDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VetsDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Appointmentform";
            this.Text = "Book Appointment";
            ((System.ComponentModel.ISupportInitialize)(this.VetsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedicinDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedMedsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView VetsDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView AppDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView MedicinDataGridView;
        private System.Windows.Forms.Label Mediciner;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BookButton;
        private System.Windows.Forms.TextBox DiagnoseTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DateTimeTextBox;
        private System.Windows.Forms.Button AddMedButton;
        private System.Windows.Forms.Button AddDiagButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView SelectedMedsDataGridView;
    }
}