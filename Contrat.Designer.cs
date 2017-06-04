namespace MyProjectV2
{
    partial class Contrat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contrat));
            this.excelDataSource1 = new DevExpress.DataAccess.Excel.ExcelDataSource();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.contrats = new MyProjectV2.Contrats();
            this.contratsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.contrat_IdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForcontrat_Id = new DevExpress.XtraLayout.LayoutControlItem();
            this.raison_SocialeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForraison_Sociale = new DevExpress.XtraLayout.LayoutControlItem();
            this.nomTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemFornom = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrat_IdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForcontrat_Id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raison_SocialeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForraison_Sociale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFornom)).BeginInit();
            this.SuspendLayout();
            // 
            // excelDataSource1
            // 
            this.excelDataSource1.Name = "excelDataSource1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(343, 111);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataLayoutControl1);
            this.groupBox2.Controls.Add(this.simpleButton1);
            this.groupBox2.Location = new System.Drawing.Point(30, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 172);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::MyProjectV2.Properties.Resources.Button_Add_icon;
            this.simpleButton1.Location = new System.Drawing.Point(163, 137);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(81, 29);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Ajouter";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox4.Image = global::MyProjectV2.Properties.Resources.Logooo;
            this.pictureBox4.Location = new System.Drawing.Point(235, 319);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(107, 26);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(97, 20);
            this.textBox1.TabIndex = 4;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.contrat_IdTextEdit);
            this.dataLayoutControl1.Controls.Add(this.raison_SocialeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.nomTextEdit);
            this.dataLayoutControl1.DataSource = this.contratsBindingSource2;
            this.dataLayoutControl1.Location = new System.Drawing.Point(38, 11);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(180, 92);
            this.dataLayoutControl1.TabIndex = 4;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(180, 92);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // contrats
            // 
            this.contrats.DataSetName = "Contrats";
            this.contrats.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contratsBindingSource2
            // 
            this.contratsBindingSource2.DataMember = "contrats";
            this.contratsBindingSource2.DataSource = this.contrats;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForcontrat_Id,
            this.ItemForraison_Sociale,
            this.ItemFornom});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(160, 72);
            // 
            // contrat_IdTextEdit
            // 
            this.contrat_IdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.contratsBindingSource2, "contrat_Id", true));
            this.contrat_IdTextEdit.Location = new System.Drawing.Point(108, 12);
            this.contrat_IdTextEdit.Name = "contrat_IdTextEdit";
            this.contrat_IdTextEdit.Size = new System.Drawing.Size(60, 20);
            this.contrat_IdTextEdit.StyleController = this.dataLayoutControl1;
            this.contrat_IdTextEdit.TabIndex = 4;
            // 
            // ItemForcontrat_Id
            // 
            this.ItemForcontrat_Id.Control = this.contrat_IdTextEdit;
            this.ItemForcontrat_Id.Location = new System.Drawing.Point(0, 0);
            this.ItemForcontrat_Id.Name = "ItemForcontrat_Id";
            this.ItemForcontrat_Id.Size = new System.Drawing.Size(160, 24);
            this.ItemForcontrat_Id.Text = "Réference";
            this.ItemForcontrat_Id.TextSize = new System.Drawing.Size(92, 13);
            // 
            // raison_SocialeTextEdit
            // 
            this.raison_SocialeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.contratsBindingSource2, "raison_Sociale", true));
            this.raison_SocialeTextEdit.Location = new System.Drawing.Point(108, 36);
            this.raison_SocialeTextEdit.Name = "raison_SocialeTextEdit";
            this.raison_SocialeTextEdit.Size = new System.Drawing.Size(60, 20);
            this.raison_SocialeTextEdit.StyleController = this.dataLayoutControl1;
            this.raison_SocialeTextEdit.TabIndex = 5;
            // 
            // ItemForraison_Sociale
            // 
            this.ItemForraison_Sociale.Control = this.raison_SocialeTextEdit;
            this.ItemForraison_Sociale.Location = new System.Drawing.Point(0, 24);
            this.ItemForraison_Sociale.Name = "ItemForraison_Sociale";
            this.ItemForraison_Sociale.Size = new System.Drawing.Size(160, 24);
            this.ItemForraison_Sociale.Text = "Raison Sociale";
            this.ItemForraison_Sociale.TextSize = new System.Drawing.Size(92, 13);
            // 
            // nomTextEdit
            // 
            this.nomTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.contratsBindingSource2, "nom", true));
            this.nomTextEdit.Location = new System.Drawing.Point(108, 60);
            this.nomTextEdit.Name = "nomTextEdit";
            this.nomTextEdit.Size = new System.Drawing.Size(60, 20);
            this.nomTextEdit.StyleController = this.dataLayoutControl1;
            this.nomTextEdit.TabIndex = 6;
            // 
            // ItemFornom
            // 
            this.ItemFornom.Control = this.nomTextEdit;
            this.ItemFornom.Location = new System.Drawing.Point(0, 48);
            this.ItemFornom.Name = "ItemFornom";
            this.ItemFornom.Size = new System.Drawing.Size(160, 24);
            this.ItemFornom.Text = "Nom de l\'entreprise";
            this.ItemFornom.TextSize = new System.Drawing.Size(92, 13);
            // 
            // Contrat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(340, 346);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Contrat";
            this.Text = "Contrat";
            this.Load += new System.EventHandler(this.Contrat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrat_IdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForcontrat_Id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raison_SocialeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForraison_Sociale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFornom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.Persistent.Base.ReportsV2.ViewDataSource viewDataSource1;
        private DevExpress.DataAccess.Excel.ExcelDataSource excelDataSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.TextBox textBox1;
        private Contrats contrats;
        private System.Windows.Forms.BindingSource contratsBindingSource2;
        private DevExpress.XtraEditors.TextEdit contrat_IdTextEdit;
        private DevExpress.XtraEditors.TextEdit raison_SocialeTextEdit;
        private DevExpress.XtraEditors.TextEdit nomTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForcontrat_Id;
        private DevExpress.XtraLayout.LayoutControlItem ItemForraison_Sociale;
        private DevExpress.XtraLayout.LayoutControlItem ItemFornom;
    }
}