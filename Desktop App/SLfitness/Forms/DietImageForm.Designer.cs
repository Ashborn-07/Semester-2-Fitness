namespace SLfitness
{
    partial class DietImageForm
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
            this.picBoxDietImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDietImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxDietImage
            // 
            this.picBoxDietImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxDietImage.Location = new System.Drawing.Point(0, 0);
            this.picBoxDietImage.Name = "picBoxDietImage";
            this.picBoxDietImage.Size = new System.Drawing.Size(447, 344);
            this.picBoxDietImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxDietImage.TabIndex = 0;
            this.picBoxDietImage.TabStop = false;
            // 
            // DietImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 344);
            this.Controls.Add(this.picBoxDietImage);
            this.Name = "DietImageForm";
            this.Text = "DietImageForm";
            this.Load += new System.EventHandler(this.DietImageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDietImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox picBoxDietImage;
    }
}