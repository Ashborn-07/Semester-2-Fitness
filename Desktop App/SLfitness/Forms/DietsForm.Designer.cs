namespace SLfitness
{
    partial class DietsForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridv = new System.Windows.Forms.DataGridView();
            this.dietBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dietBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddDiet = new System.Windows.Forms.Button();
            this.pBoxLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dietBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.image = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridv
            // 
            this.dataGridv.AllowUserToAddRows = false;
            this.dataGridv.AllowUserToDeleteRows = false;
            this.dataGridv.AllowUserToResizeColumns = false;
            this.dataGridv.AllowUserToResizeRows = false;
            this.dataGridv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.image,
            this.Update});
            this.dataGridv.Location = new System.Drawing.Point(12, 45);
            this.dataGridv.MultiSelect = false;
            this.dataGridv.Name = "dataGridv";
            this.dataGridv.ReadOnly = true;
            this.dataGridv.RowTemplate.Height = 25;
            this.dataGridv.Size = new System.Drawing.Size(696, 202);
            this.dataGridv.TabIndex = 0;
            this.dataGridv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridv_CellContentClick);
            // 
            // dietBindingSource2
            // 
            this.dietBindingSource2.DataSource = typeof(SLfitness.Diet);
            // 
            // dietBindingSource1
            // 
            this.dietBindingSource1.DataSource = typeof(SLfitness.Diet);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.cbFilter);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnAddDiet);
            this.panel1.Controls.Add(this.dataGridv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 308);
            this.panel1.TabIndex = 0;
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "No filter",
            "Zero Carbs",
            "Healthy"});
            this.cbFilter.Location = new System.Drawing.Point(12, 16);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(149, 23);
            this.cbFilter.TabIndex = 3;
            this.cbFilter.Text = "Filter";
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Black;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRefresh.Location = new System.Drawing.Point(183, 253);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(165, 43);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddDiet
            // 
            this.btnAddDiet.BackColor = System.Drawing.Color.Black;
            this.btnAddDiet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddDiet.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddDiet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddDiet.Location = new System.Drawing.Point(12, 253);
            this.btnAddDiet.Name = "btnAddDiet";
            this.btnAddDiet.Size = new System.Drawing.Size(165, 43);
            this.btnAddDiet.TabIndex = 1;
            this.btnAddDiet.Text = "ADD NEW DIET";
            this.btnAddDiet.UseVisualStyleBackColor = false;
            this.btnAddDiet.Click += new System.EventHandler(this.btnAddDiet_Click);
            // 
            // pBoxLogo
            // 
            this.pBoxLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pBoxLogo.Image = global::SLfitness.Properties.Resources.fit_logo;
            this.pBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pBoxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pBoxLogo.Name = "pBoxLogo";
            this.pBoxLogo.Size = new System.Drawing.Size(109, 65);
            this.pBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pBoxLogo.TabIndex = 3;
            this.pBoxLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(299, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "DIETS";
            // 
            // dietBindingSource
            // 
            this.dietBindingSource.DataSource = typeof(SLfitness.Diet);
            // 
            // image
            // 
            this.image.HeaderText = "image";
            this.image.Name = "image";
            this.image.ReadOnly = true;
            this.image.Text = "image";
            this.image.UseColumnTextForButtonValue = true;
            // 
            // Update
            // 
            this.Update.HeaderText = "Update";
            this.Update.Name = "Update";
            this.Update.ReadOnly = true;
            this.Update.Text = "Update";
            this.Update.UseColumnTextForButtonValue = true;
            // 
            // DietsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(717, 373);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pBoxLogo);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DietsForm";
            this.Text = "DietsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DietsForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridv;
        private PictureBox pBoxLogo;
        private Label label1;
        private Button btnAddDiet;
        private Button btnRefresh;
        private BindingSource dietBindingSource;
        private BindingSource dietBindingSource1;
        private BindingSource dietBindingSource2;
        private ComboBox cbFilter;
        private DataGridViewButtonColumn image;
        private DataGridViewButtonColumn Update;
    }
}