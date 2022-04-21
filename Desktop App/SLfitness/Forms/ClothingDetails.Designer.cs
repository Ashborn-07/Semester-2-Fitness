namespace SLfitnessDesktop
{
    partial class ClothingDetails
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
            this.picBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbClothType = new System.Windows.Forms.ComboBox();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblProductId = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.tbName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.DimGray;
            this.picBox.Location = new System.Drawing.Point(193, 14);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(165, 196);
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(69, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "SLFIT - Clothing Details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.cbClothType);
            this.panel1.Controls.Add(this.btnBrowseImage);
            this.panel1.Controls.Add(this.cbSize);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lblProductId);
            this.panel1.Controls.Add(this.numPrice);
            this.panel1.Controls.Add(this.tbDescription);
            this.panel1.Controls.Add(this.cbBrand);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.picBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 277);
            this.panel1.TabIndex = 2;
            // 
            // cbClothType
            // 
            this.cbClothType.FormattingEnabled = true;
            this.cbClothType.Items.AddRange(new object[] {
            "T SHIRTS",
            "HOODIES",
            "JACKETS",
            "LEGGINGS",
            "SPORT BRAS",
            "SPORT SHOES"});
            this.cbClothType.Location = new System.Drawing.Point(12, 168);
            this.cbClothType.Name = "cbClothType";
            this.cbClothType.Size = new System.Drawing.Size(148, 23);
            this.cbClothType.TabIndex = 45;
            this.cbClothType.Text = "Cloth Type";
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.BackColor = System.Drawing.Color.Black;
            this.btnBrowseImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrowseImage.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBrowseImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBrowseImage.Location = new System.Drawing.Point(193, 216);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(165, 28);
            this.btnBrowseImage.TabIndex = 44;
            this.btnBrowseImage.Text = "Browse";
            this.btnBrowseImage.UseVisualStyleBackColor = false;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // cbSize
            // 
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Items.AddRange(new object[] {
            "S",
            "XS",
            "M",
            "L",
            "XL",
            "XXL",
            "XXXL"});
            this.cbSize.Location = new System.Drawing.Point(12, 197);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(148, 23);
            this.cbSize.TabIndex = 43;
            this.cbSize.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 42;
            this.label2.Text = "Price:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSave.Location = new System.Drawing.Point(12, 226);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 42);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProductId.Location = new System.Drawing.Point(164, 6);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(10, 15);
            this.lblProductId.TabIndex = 40;
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
            this.numPrice.Location = new System.Drawing.Point(12, 135);
            this.numPrice.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(148, 23);
            this.numPrice.TabIndex = 39;
            // 
            // tbDescription
            // 
            this.tbDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.tbDescription.Location = new System.Drawing.Point(12, 64);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.PlaceholderText = "Description";
            this.tbDescription.Size = new System.Drawing.Size(148, 48);
            this.tbDescription.TabIndex = 37;
            // 
            // cbBrand
            // 
            this.cbBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Location = new System.Drawing.Point(12, 34);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(148, 23);
            this.cbBrand.TabIndex = 36;
            this.cbBrand.Text = "Brand";
            // 
            // tbName
            // 
            this.tbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(39)))), ((int)(((byte)(52)))));
            this.tbName.Location = new System.Drawing.Point(12, 3);
            this.tbName.Name = "tbName";
            this.tbName.PlaceholderText = "Name";
            this.tbName.Size = new System.Drawing.Size(148, 23);
            this.tbName.TabIndex = 35;
            // 
            // ClothingDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(368, 314);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "ClothingDetails";
            this.Text = "ClothingDetails";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClothingDetails_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picBox;
        private Label label1;
        private Panel panel1;
        private ComboBox cbSize;
        private Label label2;
        private Button btnSave;
        private Label lblProductId;
        private NumericUpDown numPrice;
        private TextBox tbDescription;
        private ComboBox cbBrand;
        private TextBox tbName;
        private Button btnBrowseImage;
        private ComboBox cbClothType;
    }
}