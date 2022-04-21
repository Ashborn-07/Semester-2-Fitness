﻿namespace SLfitnessDesktop
{
    partial class ProteinDetails
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbGoal = new System.Windows.Forms.ComboBox();
            this.cbProteinFlavour = new System.Windows.Forms.ComboBox();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblProductId = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.tbOccurance = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "SLFIT - Protein Details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.tbOccurance);
            this.panel1.Controls.Add(this.cbGoal);
            this.panel1.Controls.Add(this.cbProteinFlavour);
            this.panel1.Controls.Add(this.btnBrowseImage);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lblProductId);
            this.panel1.Controls.Add(this.numPrice);
            this.panel1.Controls.Add(this.tbDescription);
            this.panel1.Controls.Add(this.cbBrand);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.picBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 308);
            this.panel1.TabIndex = 3;
            // 
            // cbGoal
            // 
            this.cbGoal.FormattingEnabled = true;
            this.cbGoal.Items.AddRange(new object[] {
            "BUILD MUSCLE",
            "ENDURANCE",
            "LOSE WEIGHT",
            "STAY HEALTHY"});
            this.cbGoal.Location = new System.Drawing.Point(21, 234);
            this.cbGoal.Name = "cbGoal";
            this.cbGoal.Size = new System.Drawing.Size(148, 23);
            this.cbGoal.TabIndex = 57;
            this.cbGoal.Text = "Goals";
            // 
            // cbProteinFlavour
            // 
            this.cbProteinFlavour.FormattingEnabled = true;
            this.cbProteinFlavour.Items.AddRange(new object[] {
            "CHOCOLATE",
            "STRAWBERRY",
            "BANANA",
            "COOKIES",
            "VANILLA"});
            this.cbProteinFlavour.Location = new System.Drawing.Point(21, 205);
            this.cbProteinFlavour.Name = "cbProteinFlavour";
            this.cbProteinFlavour.Size = new System.Drawing.Size(148, 23);
            this.cbProteinFlavour.TabIndex = 56;
            this.cbProteinFlavour.Text = "Protein flavour";
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.BackColor = System.Drawing.Color.Black;
            this.btnBrowseImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrowseImage.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBrowseImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBrowseImage.Location = new System.Drawing.Point(202, 234);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(165, 28);
            this.btnBrowseImage.TabIndex = 55;
            this.btnBrowseImage.Text = "Browse";
            this.btnBrowseImage.UseVisualStyleBackColor = false;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 53;
            this.label2.Text = "Price:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSave.Location = new System.Drawing.Point(21, 263);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 42);
            this.btnSave.TabIndex = 52;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProductId.Location = new System.Drawing.Point(175, 19);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(10, 15);
            this.lblProductId.TabIndex = 51;
            this.lblProductId.Text = ".";
            // 
            // numPrice
            // 
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numPrice.Location = new System.Drawing.Point(21, 172);
            this.numPrice.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(148, 23);
            this.numPrice.TabIndex = 50;
            // 
            // tbDescription
            // 
            this.tbDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.tbDescription.Location = new System.Drawing.Point(21, 69);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.PlaceholderText = "Description";
            this.tbDescription.Size = new System.Drawing.Size(148, 48);
            this.tbDescription.TabIndex = 49;
            // 
            // cbBrand
            // 
            this.cbBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(21, 40);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(148, 23);
            this.cbBrand.TabIndex = 48;
            this.cbBrand.Text = "Brand";
            // 
            // tbName
            // 
            this.tbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.tbName.Location = new System.Drawing.Point(21, 11);
            this.tbName.Name = "tbName";
            this.tbName.PlaceholderText = "Name";
            this.tbName.Size = new System.Drawing.Size(148, 23);
            this.tbName.TabIndex = 47;
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.DimGray;
            this.picBox.Location = new System.Drawing.Point(202, 32);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(165, 196);
            this.picBox.TabIndex = 46;
            this.picBox.TabStop = false;
            // 
            // tbOccurance
            // 
            this.tbOccurance.Location = new System.Drawing.Point(21, 123);
            this.tbOccurance.Name = "tbOccurance";
            this.tbOccurance.PlaceholderText = "Occurance";
            this.tbOccurance.Size = new System.Drawing.Size(148, 23);
            this.tbOccurance.TabIndex = 58;
            // 
            // ProteinDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(408, 346);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "ProteinDetails";
            this.Text = "ProteinDetails";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProteinDetails_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private ComboBox cbGoal;
        private ComboBox cbProteinFlavour;
        private Button btnBrowseImage;
        private Label label2;
        private Button btnSave;
        private Label lblProductId;
        private NumericUpDown numPrice;
        private TextBox tbDescription;
        private ComboBox cbBrand;
        private TextBox tbName;
        private PictureBox picBox;
        private TextBox tbOccurance;
    }
}