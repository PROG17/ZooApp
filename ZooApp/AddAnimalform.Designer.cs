﻿namespace ZooApp
{
    partial class AddAnimalform
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
            this.label1 = new System.Windows.Forms.Label();
            this.NewNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NewEatsComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NewSpeciesBox = new System.Windows.Forms.ComboBox();
            this.NewSpeciesComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NewHabitatComboBox = new System.Windows.Forms.ComboBox();
            this.NewWeightTextbox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Namn";
            // 
            // NewNameBox
            // 
            this.NewNameBox.Location = new System.Drawing.Point(177, 28);
            this.NewNameBox.Name = "NewNameBox";
            this.NewNameBox.Size = new System.Drawing.Size(226, 26);
            this.NewNameBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Äter";
            // 
            // NewEatsComboBox
            // 
            this.NewEatsComboBox.FormattingEnabled = true;
            this.NewEatsComboBox.Items.AddRange(new object[] {
            "Kött",
            "Växter"});
            this.NewEatsComboBox.Location = new System.Drawing.Point(177, 73);
            this.NewEatsComboBox.Name = "NewEatsComboBox";
            this.NewEatsComboBox.Size = new System.Drawing.Size(121, 28);
            this.NewEatsComboBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ursprungsland";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Art";
            // 
            // NewSpeciesBox
            // 
            this.NewSpeciesBox.FormattingEnabled = true;
            this.NewSpeciesBox.Items.AddRange(new object[] {
            "Sverige",
            "Thailand",
            "Uganda",
            "Australien"});
            this.NewSpeciesBox.Location = new System.Drawing.Point(177, 121);
            this.NewSpeciesBox.Name = "NewSpeciesBox";
            this.NewSpeciesBox.Size = new System.Drawing.Size(121, 28);
            this.NewSpeciesBox.TabIndex = 6;
            // 
            // NewSpeciesComboBox
            // 
            this.NewSpeciesComboBox.FormattingEnabled = true;
            this.NewSpeciesComboBox.Items.AddRange(new object[] {
            "Lejon",
            "Elefant",
            "Orm",
            "Fågel",
            "Gris"});
            this.NewSpeciesComboBox.Location = new System.Drawing.Point(177, 175);
            this.NewSpeciesComboBox.Name = "NewSpeciesComboBox";
            this.NewSpeciesComboBox.Size = new System.Drawing.Size(121, 28);
            this.NewSpeciesComboBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Vikt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Bor i";
            // 
            // NewHabitatComboBox
            // 
            this.NewHabitatComboBox.FormattingEnabled = true;
            this.NewHabitatComboBox.Items.AddRange(new object[] {
            "Vatten",
            "Mark",
            "Träd"});
            this.NewHabitatComboBox.Location = new System.Drawing.Point(177, 226);
            this.NewHabitatComboBox.Name = "NewHabitatComboBox";
            this.NewHabitatComboBox.Size = new System.Drawing.Size(121, 28);
            this.NewHabitatComboBox.TabIndex = 10;
            // 
            // NewWeightTextbox
            // 
            this.NewWeightTextbox.Location = new System.Drawing.Point(177, 278);
            this.NewWeightTextbox.Name = "NewWeightTextbox";
            this.NewWeightTextbox.Size = new System.Drawing.Size(100, 26);
            this.NewWeightTextbox.TabIndex = 11;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(514, 31);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(133, 70);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Spara";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // AddAnimalform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 378);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NewWeightTextbox);
            this.Controls.Add(this.NewHabitatComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NewSpeciesComboBox);
            this.Controls.Add(this.NewSpeciesBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NewEatsComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NewNameBox);
            this.Controls.Add(this.label1);
            this.Name = "AddAnimalform";
            this.Text = "Lägg till djur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NewNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox NewEatsComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox NewSpeciesBox;
        private System.Windows.Forms.ComboBox NewSpeciesComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox NewHabitatComboBox;
        private System.Windows.Forms.TextBox NewWeightTextbox;
        private System.Windows.Forms.Button SaveButton;
    }
}