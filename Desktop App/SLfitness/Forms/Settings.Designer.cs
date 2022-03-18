namespace SLfitness
{
    partial class Settings
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
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.tbSaveChanges = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tblastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.pBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnUploadImage);
            this.panel1.Controls.Add(this.picBox);
            this.panel1.Controls.Add(this.tbSaveChanges);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.tblastName);
            this.panel1.Controls.Add(this.tbFirstName);
            this.panel1.Controls.Add(this.tbUsername);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 244);
            this.panel1.TabIndex = 0;
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.BackColor = System.Drawing.Color.Black;
            this.btnUploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUploadImage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUploadImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUploadImage.Location = new System.Drawing.Point(261, 203);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(200, 30);
            this.btnUploadImage.TabIndex = 8;
            this.btnUploadImage.Text = "Upload";
            this.btnUploadImage.UseVisualStyleBackColor = false;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(261, 17);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(198, 177);
            this.picBox.TabIndex = 7;
            this.picBox.TabStop = false;
            // 
            // tbSaveChanges
            // 
            this.tbSaveChanges.BackColor = System.Drawing.Color.Black;
            this.tbSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tbSaveChanges.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbSaveChanges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tbSaveChanges.Location = new System.Drawing.Point(12, 173);
            this.tbSaveChanges.Name = "tbSaveChanges";
            this.tbSaveChanges.Size = new System.Drawing.Size(200, 43);
            this.tbSaveChanges.TabIndex = 6;
            this.tbSaveChanges.Text = "SAVE";
            this.tbSaveChanges.UseVisualStyleBackColor = false;
            this.tbSaveChanges.Click += new System.EventHandler(this.tbSaveChanges_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(12, 134);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PlaceholderText = "email";
            this.tbEmail.Size = new System.Drawing.Size(200, 33);
            this.tbEmail.TabIndex = 3;
            // 
            // tblastName
            // 
            this.tblastName.Location = new System.Drawing.Point(12, 95);
            this.tblastName.Name = "tblastName";
            this.tblastName.PlaceholderText = "Last Name";
            this.tblastName.Size = new System.Drawing.Size(200, 33);
            this.tblastName.TabIndex = 2;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(12, 56);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.PlaceholderText = "First Name";
            this.tbFirstName.Size = new System.Drawing.Size(200, 33);
            this.tbFirstName.TabIndex = 1;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(12, 17);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.PlaceholderText = "Username";
            this.tbUsername.Size = new System.Drawing.Size(200, 33);
            this.tbUsername.TabIndex = 0;
            // 
            // pBoxLogo
            // 
            this.pBoxLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pBoxLogo.Image = global::SLfitness.Properties.Resources.fit_logo;
            this.pBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pBoxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pBoxLogo.Name = "pBoxLogo";
            this.pBoxLogo.Size = new System.Drawing.Size(109, 59);
            this.pBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pBoxLogo.TabIndex = 4;
            this.pBoxLogo.TabStop = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(488, 303);
            this.Controls.Add(this.pBoxLogo);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Settings";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox tbEmail;
        private TextBox tblastName;
        private TextBox tbFirstName;
        private TextBox tbUsername;
        private Button btnUploadImage;
        private PictureBox picBox;
        private Button tbSaveChanges;
        private PictureBox pBoxLogo;
    }
}