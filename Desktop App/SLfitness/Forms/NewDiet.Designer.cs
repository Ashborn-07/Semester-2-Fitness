namespace SLfitnessDesktop
{
    partial class NewDiet
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.numCarbs = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numFat = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numCalories = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnAddDiet = new System.Windows.Forms.Button();
            this.btnPictureBrowse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.picBoxDiet = new System.Windows.Forms.PictureBox();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.pBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCarbs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCalories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(5, 7);
            this.tbName.Margin = new System.Windows.Forms.Padding(5);
            this.tbName.Name = "tbName";
            this.tbName.PlaceholderText = "Name";
            this.tbName.Size = new System.Drawing.Size(227, 33);
            this.tbName.TabIndex = 0;
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
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbType);
            this.panel1.Controls.Add(this.btnAddDiet);
            this.panel1.Controls.Add(this.btnPictureBrowse);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.picBoxDiet);
            this.panel1.Controls.Add(this.tbDescription);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 329);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Carbs:";
            // 
            // numCarbs
            // 
            this.numCarbs.Location = new System.Drawing.Point(82, 242);
            this.numCarbs.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numCarbs.Name = "numCarbs";
            this.numCarbs.Size = new System.Drawing.Size(150, 33);
            this.numCarbs.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fat:";
            // 
            // numFat
            // 
            this.numFat.Location = new System.Drawing.Point(58, 203);
            this.numFat.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numFat.Name = "numFat";
            this.numFat.Size = new System.Drawing.Size(174, 33);
            this.numFat.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Calories:";
            // 
            // numCalories
            // 
            this.numCalories.Location = new System.Drawing.Point(102, 165);
            this.numCalories.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numCalories.Name = "numCalories";
            this.numCalories.Size = new System.Drawing.Size(130, 33);
            this.numCalories.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Type:";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Healthy",
            "Zero Carbs"});
            this.cbType.Location = new System.Drawing.Point(78, 124);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(154, 33);
            this.cbType.TabIndex = 8;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // btnAddDiet
            // 
            this.btnAddDiet.BackColor = System.Drawing.Color.Black;
            this.btnAddDiet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddDiet.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddDiet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddDiet.Location = new System.Drawing.Point(12, 281);
            this.btnAddDiet.Name = "btnAddDiet";
            this.btnAddDiet.Size = new System.Drawing.Size(220, 35);
            this.btnAddDiet.TabIndex = 7;
            this.btnAddDiet.Text = "Add Diet";
            this.btnAddDiet.UseVisualStyleBackColor = false;
            this.btnAddDiet.Click += new System.EventHandler(this.btnAddDiet_Click);
            // 
            // btnPictureBrowse
            // 
            this.btnPictureBrowse.BackColor = System.Drawing.Color.Black;
            this.btnPictureBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPictureBrowse.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPictureBrowse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPictureBrowse.Location = new System.Drawing.Point(322, 281);
            this.btnPictureBrowse.Name = "btnPictureBrowse";
            this.btnPictureBrowse.Size = new System.Drawing.Size(89, 35);
            this.btnPictureBrowse.TabIndex = 6;
            this.btnPictureBrowse.Text = "Browse";
            this.btnPictureBrowse.UseVisualStyleBackColor = false;
            this.btnPictureBrowse.Click += new System.EventHandler(this.btnPictureBrowse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(271, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Picture";
            // 
            // picBoxDiet
            // 
            this.picBoxDiet.Location = new System.Drawing.Point(271, 35);
            this.picBoxDiet.Name = "picBoxDiet";
            this.picBoxDiet.Size = new System.Drawing.Size(193, 240);
            this.picBoxDiet.TabIndex = 4;
            this.picBoxDiet.TabStop = false;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(5, 50);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(5);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.PlaceholderText = "Description";
            this.tbDescription.Size = new System.Drawing.Size(227, 69);
            this.tbDescription.TabIndex = 3;
            // 
            // pBoxLogo
            // 
            this.pBoxLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pBoxLogo.Image = global::SLfitnessDesktop.Properties.Resources.fit_logo;
            this.pBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pBoxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pBoxLogo.Name = "pBoxLogo";
            this.pBoxLogo.Size = new System.Drawing.Size(109, 49);
            this.pBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pBoxLogo.TabIndex = 4;
            this.pBoxLogo.TabStop = false;
            // 
            // NewDiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(490, 378);
            this.Controls.Add(this.pBoxLogo);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "NewDiet";
            this.Text = "NewDiet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewDiet_FormClosing);
            this.Load += new System.EventHandler(this.NewDiet_Load);
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

        private TextBox tbName;
        private Panel panel1;
        private PictureBox pBoxLogo;
        private Button btnAddDiet;
        private Button btnPictureBrowse;
        private Label label3;
        private PictureBox picBoxDiet;
        private TextBox tbDescription;
        private Label label1;
        private ComboBox cbType;
        private Label label5;
        private NumericUpDown numCarbs;
        private Label label4;
        private NumericUpDown numFat;
        private Label label2;
        private NumericUpDown numCalories;
    }
}