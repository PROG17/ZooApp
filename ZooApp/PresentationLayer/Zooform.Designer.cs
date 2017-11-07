﻿namespace ZooApp
{
    partial class Zooform
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
            this.ZooGridViewSök = new System.Windows.Forms.DataGridView();
            this.EnvironmentComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SpeciesComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EatsComboBox = new System.Windows.Forms.ComboBox();
            this.AddAnimalButton = new System.Windows.Forms.Button();
            this.BookButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.AnimalNameSearchBox = new System.Windows.Forms.TextBox();
            this.DeleteAnimalButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ZooGridViewSök)).BeginInit();
            this.SuspendLayout();
            // 
            // ZooGridViewSök
            // 
            this.ZooGridViewSök.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ZooGridViewSök.Location = new System.Drawing.Point(49, 38);
            this.ZooGridViewSök.Name = "ZooGridViewSök";
            this.ZooGridViewSök.RowTemplate.Height = 28;
            this.ZooGridViewSök.Size = new System.Drawing.Size(604, 249);
            this.ZooGridViewSök.TabIndex = 0;
            // 
            // EnvironmentComboBox
            // 
            this.EnvironmentComboBox.FormattingEnabled = true;
            this.EnvironmentComboBox.Items.AddRange(new object[] {
            "Vatten",
            "Mark",
            "Träd"});
            this.EnvironmentComboBox.Location = new System.Drawing.Point(680, 63);
            this.EnvironmentComboBox.Name = "EnvironmentComboBox";
            this.EnvironmentComboBox.Size = new System.Drawing.Size(121, 28);
            this.EnvironmentComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(676, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bor i miljö";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(676, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Djursort";
            // 
            // SpeciesComboBox
            // 
            this.SpeciesComboBox.FormattingEnabled = true;
            this.SpeciesComboBox.Location = new System.Drawing.Point(680, 157);
            this.SpeciesComboBox.Name = "SpeciesComboBox";
            this.SpeciesComboBox.Size = new System.Drawing.Size(121, 28);
            this.SpeciesComboBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(676, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Föda";
            // 
            // EatsComboBox
            // 
            this.EatsComboBox.FormattingEnabled = true;
            this.EatsComboBox.Items.AddRange(new object[] {
            "Kött",
            "Växter"});
            this.EatsComboBox.Location = new System.Drawing.Point(680, 270);
            this.EatsComboBox.Name = "EatsComboBox";
            this.EatsComboBox.Size = new System.Drawing.Size(121, 28);
            this.EatsComboBox.TabIndex = 6;
            // 
            // AddAnimalButton
            // 
            this.AddAnimalButton.Location = new System.Drawing.Point(827, 38);
            this.AddAnimalButton.Name = "AddAnimalButton";
            this.AddAnimalButton.Size = new System.Drawing.Size(123, 53);
            this.AddAnimalButton.TabIndex = 7;
            this.AddAnimalButton.Text = "Lägg till djur";
            this.AddAnimalButton.UseVisualStyleBackColor = true;
            // 
            // BookButton
            // 
            this.BookButton.Location = new System.Drawing.Point(827, 244);
            this.BookButton.Name = "BookButton";
            this.BookButton.Size = new System.Drawing.Size(135, 54);
            this.BookButton.TabIndex = 8;
            this.BookButton.Text = "Boka veterinärs besök";
            this.BookButton.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(49, 311);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(95, 40);
            this.SearchButton.TabIndex = 9;
            this.SearchButton.Text = "Sök";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Djurnamn";
            // 
            // AnimalNameSearchBox
            // 
            this.AnimalNameSearchBox.Location = new System.Drawing.Point(244, 318);
            this.AnimalNameSearchBox.Name = "AnimalNameSearchBox";
            this.AnimalNameSearchBox.Size = new System.Drawing.Size(213, 26);
            this.AnimalNameSearchBox.TabIndex = 11;
            // 
            // DeleteAnimalButton
            // 
            this.DeleteAnimalButton.Location = new System.Drawing.Point(827, 128);
            this.DeleteAnimalButton.Name = "DeleteAnimalButton";
            this.DeleteAnimalButton.Size = new System.Drawing.Size(123, 57);
            this.DeleteAnimalButton.TabIndex = 12;
            this.DeleteAnimalButton.Text = "Ta bort djur";
            this.DeleteAnimalButton.UseVisualStyleBackColor = true;
            // 
            // Zooform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 386);
            this.Controls.Add(this.DeleteAnimalButton);
            this.Controls.Add(this.AnimalNameSearchBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.BookButton);
            this.Controls.Add(this.AddAnimalButton);
            this.Controls.Add(this.EatsComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SpeciesComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnvironmentComboBox);
            this.Controls.Add(this.ZooGridViewSök);
            this.Name = "Zooform";
            this.Text = "Sök djur";
            ((System.ComponentModel.ISupportInitialize)(this.ZooGridViewSök)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ZooGridViewSök;
        private System.Windows.Forms.ComboBox EnvironmentComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SpeciesComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox EatsComboBox;
        private System.Windows.Forms.Button AddAnimalButton;
        private System.Windows.Forms.Button BookButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AnimalNameSearchBox;
        private System.Windows.Forms.Button DeleteAnimalButton;
    }
}

