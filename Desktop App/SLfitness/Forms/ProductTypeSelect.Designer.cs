namespace SLfitnessDesktop
{
    partial class ProductTypeSelect
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
            this.btnClothing = new System.Windows.Forms.Button();
            this.btnProtein = new System.Windows.Forms.Button();
            this.btnVitamin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClothing
            // 
            this.btnClothing.BackColor = System.Drawing.Color.Black;
            this.btnClothing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClothing.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClothing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClothing.Location = new System.Drawing.Point(12, 12);
            this.btnClothing.Name = "btnClothing";
            this.btnClothing.Size = new System.Drawing.Size(154, 87);
            this.btnClothing.TabIndex = 34;
            this.btnClothing.Text = "Clothing";
            this.btnClothing.UseVisualStyleBackColor = false;
            this.btnClothing.Click += new System.EventHandler(this.btnClothing_Click);
            // 
            // btnProtein
            // 
            this.btnProtein.BackColor = System.Drawing.Color.Black;
            this.btnProtein.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProtein.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProtein.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnProtein.Location = new System.Drawing.Point(172, 12);
            this.btnProtein.Name = "btnProtein";
            this.btnProtein.Size = new System.Drawing.Size(154, 87);
            this.btnProtein.TabIndex = 35;
            this.btnProtein.Text = "Protein";
            this.btnProtein.UseVisualStyleBackColor = false;
            this.btnProtein.Click += new System.EventHandler(this.btnProtein_Click);
            // 
            // btnVitamin
            // 
            this.btnVitamin.BackColor = System.Drawing.Color.Black;
            this.btnVitamin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVitamin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVitamin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnVitamin.Location = new System.Drawing.Point(332, 12);
            this.btnVitamin.Name = "btnVitamin";
            this.btnVitamin.Size = new System.Drawing.Size(154, 87);
            this.btnVitamin.TabIndex = 36;
            this.btnVitamin.Text = "Vitamins";
            this.btnVitamin.UseVisualStyleBackColor = false;
            this.btnVitamin.Click += new System.EventHandler(this.btnVitamin_Click);
            // 
            // ProductTypeSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(498, 111);
            this.Controls.Add(this.btnVitamin);
            this.Controls.Add(this.btnProtein);
            this.Controls.Add(this.btnClothing);
            this.Name = "ProductTypeSelect";
            this.Text = "ProductTypeSelect";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnClothing;
        private Button btnProtein;
        private Button btnVitamin;
    }
}