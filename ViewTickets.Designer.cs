namespace MyProjectV2
{
    partial class ViewTickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTickets));
            this.cboFilter = new System.Windows.Forms.DataGridView();
            this.Recherche = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cboFilter)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // cboFilter
            // 
            this.cboFilter.AllowUserToAddRows = false;
            this.cboFilter.AllowUserToDeleteRows = false;
            this.cboFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cboFilter.Location = new System.Drawing.Point(1, 1);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.ReadOnly = true;
            this.cboFilter.Size = new System.Drawing.Size(1082, 214);
            this.cboFilter.TabIndex = 0;
            // 
            // Recherche
            // 
            this.Recherche.FormattingEnabled = true;
            this.Recherche.Items.AddRange(new object[] {
            "Responsable",
            "Entreprise",
            "Type d\'intervention"});
            this.Recherche.Location = new System.Drawing.Point(6, 19);
            this.Recherche.Name = "Recherche";
            this.Recherche.Size = new System.Drawing.Size(134, 21);
            this.Recherche.TabIndex = 5;
            this.Recherche.SelectedIndexChanged += new System.EventHandler(this.Recherche_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Recherche);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(374, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 77);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyProjectV2.Properties.Resources.Search_icon3;
            this.pictureBox1.Location = new System.Drawing.Point(302, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 18);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox4.Image = global::MyProjectV2.Properties.Resources.Logooo;
            this.pictureBox4.Location = new System.Drawing.Point(976, 333);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(107, 26);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // ViewTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1084, 359);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboFilter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewTickets";
            this.Text = "Tickets";
            this.Load += new System.EventHandler(this.ViewTickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cboFilter)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView cboFilter;
        private System.Windows.Forms.ComboBox Recherche;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}