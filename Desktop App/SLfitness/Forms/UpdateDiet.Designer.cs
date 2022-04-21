namespace SLfitnessDesktop
{
    partial class UpdateDiet
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.numCarbs = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numFat = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numCalories = new System.Windows.Forms.NumericUpDown();
            this.btnAddDiet = new System.Windows.Forms.Button();
            this.btnPictureBrowse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.picBoxDiet = new System.Windows.Forms.PictureBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.pBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCarbs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCalories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.numCarbs);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.numFat);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numCalories);
            this.panel1.Controls.Add(this.btnAddDiet);
            this.panel1.Controls.Add(this.btnPictureBrowse);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.picBoxDiet);
            this.panel1.Controls.Add(this.tbDescription);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 335);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "Carbs:";
            // 
            // numCarbs
            // 
            this.numCarbs.Location = new System.Drawing.Point(84, 221);
            this.numCarbs.Margin = new System.Windows.Forms.Padding(5);
            this.numCarbs.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numCarbs.Name = "numCarbs";
            this.numCarbs.Size = new System.Drawing.Size(157, 33);
            this.numCarbs.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Fat:";
            // 
            // numFat
            // 
            this.numFat.Location = new System.Drawing.Point(60, 180);
            this.numFat.Margin = new System.Windows.Forms.Padding(5);
            this.numFat.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numFat.Name = "numFat";
            this.numFat.Size = new System.Drawing.Size(181, 33);
            this.numFat.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Calories:";
            // 
            // numCalories
            // 
            this.numCalories.Location = new System.Drawing.Point(104, 140);
            this.numCalories.Margin = new System.Windows.Forms.Padding(5);
            this.numCalories.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numCalories.Name = "numCalories";
            this.numCalories.Size = new System.Drawing.Size(137, 33);
            this.numCalories.TabIndex = 24;
            // 
            // btnAddDiet
            // 
            this.btnAddDiet.BackColor = System.Drawing.Color.Black;
            this.btnAddDiet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddDiet.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddDiet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddDiet.Location = new System.Drawing.Point(12, 262);
            this.btnAddDiet.Name = "btnAddDiet";
            this.btnAddDiet.Size = new System.Drawing.Size(220, 35);
            this.btnAddDiet.TabIndex = 21;
            this.btnAddDiet.Text = "Update Diet";
            this.btnAddDiet.UseVisualStyleBackColor = false;
            this.btnAddDiet.Click += new System.EventHandler(this.btnUpdateDiet_Click);
            // 
            // btnPictureBrowse
            // 
            this.btnPictureBrowse.BackColor = System.Drawing.Color.Black;
            this.btnPictureBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPictureBrowse.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPictureBrowse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPictureBrowse.Location = new System.Drawing.Point(347, 290);
            this.btnPictureBrowse.Name = "btnPictureBrowse";
            this.btnPictureBrowse.Size = new System.Drawing.Size(105, 35);
            this.btnPictureBrowse.TabIndex = 20;
            this.btnPictureBrowse.Text = "Browse";
            this.btnPictureBrowse.UseVisualStyleBackColor = false;
            this.btnPictureBrowse.Click += new System.EventHandler(this.btnPictureBrowse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(271, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Picture";
            // 
            // picBoxDiet
            // 
            this.picBoxDiet.Location = new System.Drawing.Point(271, 30);
            this.picBoxDiet.Name = "picBoxDiet";
            this.picBoxDiet.Size = new System.Drawing.Size(244, 254);
            this.picBoxDiet.TabIndex = 18;
            this.picBoxDiet.TabStop = false;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(12, 66);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(5);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.PlaceholderText = "Description";
            this.tbDescription.Size = new System.Drawing.Size(227, 69);
            this.tbDescription.TabIndex = 17;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 23);
            this.tbName.Margin = new System.Windows.Forms.Padding(5);
            this.tbName.Name = "tbName";
            this.tbName.PlaceholderText = "Name";
            this.tbName.Size = new System.Drawing.Size(227, 33);
            this.tbName.TabIndex = 16;
            // 
            // pBoxLogo
            // 
            this.pBoxLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pBoxLogo.Image = global::SLfitnessDesktop.Properties.Resources.fit_logo;
            this.pBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pBoxLogo.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.pBoxLogo.Name = "pBoxLogo";
            this.pBoxLogo.Size = new System.Drawing.Size(133, 43);
            this.pBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pBoxLogo.TabIndex = 5;
            this.pBoxLogo.TabStop = false;
            // 
            // UpdateDiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(527, 378);
            this.Controls.Add(this.pBoxLogo);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UpdateDiet";
            this.Text = "UpdateDiet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateDiet_FormClosing);
            this.Load += new System.EventHandler(this.UpdateDiet_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCarbs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCalories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pBoxLogo;
        private Label label5;
        private NumericUpDown numCarbs;
        private Label label4;
        private NumericUpDown numFat;
        private Label label2;
        private NumericUpDown numCalories;
        private Button btnAddDiet;
        private Button btnPictureBrowse;
        private Label label3;
        private PictureBox picBoxDiet;
        private TextBox tbDescription;
        private TextBox tbName;
    }
}