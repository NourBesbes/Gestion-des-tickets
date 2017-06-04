namespace MyProjectV2
{
    partial class Modifier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modifier));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.empl_IdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.employesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPLOYE = new MyProjectV2.EMPLOYE();
            this.loginTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.passwordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nomTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.prenomTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.telTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForempl_Id = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForlogin = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForpassword = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemFornom = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForprenom = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemFormail = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemFortel = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.employesTableAdapter1 = new MyProjectV2.MyProjectDBDataSet5TableAdapters.employesTableAdapter();
            this.employesTableAdapter = new MyProjectV2.EMPLOYETableAdapters.employesTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empl_IdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prenomTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForempl_Id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForlogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForpassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFornom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForprenom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFormail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFortel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataLayoutControl1);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Location = new System.Drawing.Point(24, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 293);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.empl_IdTextEdit);
            this.dataLayoutControl1.Controls.Add(this.loginTextEdit);
            this.dataLayoutControl1.Controls.Add(this.passwordTextEdit);
            this.dataLayoutControl1.Controls.Add(this.nomTextEdit);
            this.dataLayoutControl1.Controls.Add(this.prenomTextEdit);
            this.dataLayoutControl1.Controls.Add(this.mailTextEdit);
            this.dataLayoutControl1.Controls.Add(this.telTextEdit);
            this.dataLayoutControl1.DataSource = this.employesBindingSource;
            this.dataLayoutControl1.Location = new System.Drawing.Point(23, 19);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(208, 194);
            this.dataLayoutControl1.TabIndex = 14;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // empl_IdTextEdit
            // 
            this.empl_IdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employesBindingSource, "empl_Id", true));
            this.empl_IdTextEdit.Location = new System.Drawing.Point(79, 12);
            this.empl_IdTextEdit.Name = "empl_IdTextEdit";
            this.empl_IdTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.empl_IdTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.empl_IdTextEdit.Properties.Mask.EditMask = "N0";
            this.empl_IdTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.empl_IdTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.empl_IdTextEdit.Size = new System.Drawing.Size(117, 20);
            this.empl_IdTextEdit.StyleController = this.dataLayoutControl1;
            this.empl_IdTextEdit.TabIndex = 4;
            // 
            // employesBindingSource
            // 
            this.employesBindingSource.DataMember = "employes";
            this.employesBindingSource.DataSource = this.eMPLOYE;
            // 
            // eMPLOYE
            // 
            this.eMPLOYE.DataSetName = "EMPLOYE";
            this.eMPLOYE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginTextEdit
            // 
            this.loginTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employesBindingSource, "login", true));
            this.loginTextEdit.Location = new System.Drawing.Point(79, 36);
            this.loginTextEdit.Name = "loginTextEdit";
            this.loginTextEdit.Size = new System.Drawing.Size(117, 20);
            this.loginTextEdit.StyleController = this.dataLayoutControl1;
            this.loginTextEdit.TabIndex = 5;
            // 
            // passwordTextEdit
            // 
            this.passwordTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employesBindingSource, "password", true));
            this.passwordTextEdit.Location = new System.Drawing.Point(79, 60);
            this.passwordTextEdit.Name = "passwordTextEdit";
            this.passwordTextEdit.Size = new System.Drawing.Size(117, 20);
            this.passwordTextEdit.StyleController = this.dataLayoutControl1;
            this.passwordTextEdit.TabIndex = 6;
            // 
            // nomTextEdit
            // 
            this.nomTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employesBindingSource, "nom", true));
            this.nomTextEdit.Location = new System.Drawing.Point(79, 84);
            this.nomTextEdit.Name = "nomTextEdit";
            this.nomTextEdit.Size = new System.Drawing.Size(117, 20);
            this.nomTextEdit.StyleController = this.dataLayoutControl1;
            this.nomTextEdit.TabIndex = 7;
            // 
            // prenomTextEdit
            // 
            this.prenomTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employesBindingSource, "prenom", true));
            this.prenomTextEdit.Location = new System.Drawing.Point(79, 108);
            this.prenomTextEdit.Name = "prenomTextEdit";
            this.prenomTextEdit.Size = new System.Drawing.Size(117, 20);
            this.prenomTextEdit.StyleController = this.dataLayoutControl1;
            this.prenomTextEdit.TabIndex = 8;
            // 
            // mailTextEdit
            // 
            this.mailTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employesBindingSource, "mail", true));
            this.mailTextEdit.Location = new System.Drawing.Point(79, 132);
            this.mailTextEdit.Name = "mailTextEdit";
            this.mailTextEdit.Size = new System.Drawing.Size(117, 20);
            this.mailTextEdit.StyleController = this.dataLayoutControl1;
            this.mailTextEdit.TabIndex = 9;
            // 
            // telTextEdit
            // 
            this.telTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employesBindingSource, "tel", true));
            this.telTextEdit.Location = new System.Drawing.Point(79, 156);
            this.telTextEdit.Name = "telTextEdit";
            this.telTextEdit.Size = new System.Drawing.Size(117, 20);
            this.telTextEdit.StyleController = this.dataLayoutControl1;
            this.telTextEdit.TabIndex = 10;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(208, 194);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForempl_Id,
            this.ItemForlogin,
            this.ItemForpassword,
            this.ItemFornom,
            this.ItemForprenom,
            this.ItemFormail,
            this.ItemFortel});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(188, 174);
            // 
            // ItemForempl_Id
            // 
            this.ItemForempl_Id.Control = this.empl_IdTextEdit;
            this.ItemForempl_Id.Location = new System.Drawing.Point(0, 0);
            this.ItemForempl_Id.Name = "ItemForempl_Id";
            this.ItemForempl_Id.Size = new System.Drawing.Size(188, 24);
            this.ItemForempl_Id.Text = "empl_Id";
            this.ItemForempl_Id.TextSize = new System.Drawing.Size(64, 13);
            // 
            // ItemForlogin
            // 
            this.ItemForlogin.Control = this.loginTextEdit;
            this.ItemForlogin.Location = new System.Drawing.Point(0, 24);
            this.ItemForlogin.Name = "ItemForlogin";
            this.ItemForlogin.Size = new System.Drawing.Size(188, 24);
            this.ItemForlogin.Text = "Login";
            this.ItemForlogin.TextSize = new System.Drawing.Size(64, 13);
            // 
            // ItemForpassword
            // 
            this.ItemForpassword.Control = this.passwordTextEdit;
            this.ItemForpassword.Location = new System.Drawing.Point(0, 48);
            this.ItemForpassword.Name = "ItemForpassword";
            this.ItemForpassword.Size = new System.Drawing.Size(188, 24);
            this.ItemForpassword.Text = "Mot de passe";
            this.ItemForpassword.TextSize = new System.Drawing.Size(64, 13);
            // 
            // ItemFornom
            // 
            this.ItemFornom.Control = this.nomTextEdit;
            this.ItemFornom.Location = new System.Drawing.Point(0, 72);
            this.ItemFornom.Name = "ItemFornom";
            this.ItemFornom.Size = new System.Drawing.Size(188, 24);
            this.ItemFornom.Text = "Nom";
            this.ItemFornom.TextSize = new System.Drawing.Size(64, 13);
            // 
            // ItemForprenom
            // 
            this.ItemForprenom.Control = this.prenomTextEdit;
            this.ItemForprenom.Location = new System.Drawing.Point(0, 96);
            this.ItemForprenom.Name = "ItemForprenom";
            this.ItemForprenom.Size = new System.Drawing.Size(188, 24);
            this.ItemForprenom.Text = "Prenom";
            this.ItemForprenom.TextSize = new System.Drawing.Size(64, 13);
            // 
            // ItemFormail
            // 
            this.ItemFormail.Control = this.mailTextEdit;
            this.ItemFormail.Location = new System.Drawing.Point(0, 120);
            this.ItemFormail.Name = "ItemFormail";
            this.ItemFormail.Size = new System.Drawing.Size(188, 24);
            this.ItemFormail.Text = "Email";
            this.ItemFormail.TextSize = new System.Drawing.Size(64, 13);
            // 
            // ItemFortel
            // 
            this.ItemFortel.Control = this.telTextEdit;
            this.ItemFortel.Location = new System.Drawing.Point(0, 144);
            this.ItemFortel.Name = "ItemFortel";
            this.ItemFortel.Size = new System.Drawing.Size(188, 30);
            this.ItemFortel.Text = "Telephone";
            this.ItemFortel.TextSize = new System.Drawing.Size(64, 13);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::MyProjectV2.Properties.Resources.Actions_edit_redo_icon;
            this.simpleButton1.Location = new System.Drawing.Point(137, 240);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(77, 22);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Modifier";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox4.Image = global::MyProjectV2.Properties.Resources.Logooo;
            this.pictureBox4.Location = new System.Drawing.Point(191, 336);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(107, 26);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // employesTableAdapter1
            // 
            this.employesTableAdapter1.ClearBeforeFill = true;
            // 
            // employesTableAdapter
            // 
            this.employesTableAdapter.ClearBeforeFill = true;
            // 
            // Modifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(298, 363);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Modifier";
            this.Text = "Modifier";
            this.Load += new System.EventHandler(this.Mod_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.empl_IdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPLOYE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nomTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prenomTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForempl_Id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForlogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForpassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFornom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForprenom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFormail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemFortel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MyProjectDBDataSet5TableAdapters.employesTableAdapter employesTableAdapter1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private EMPLOYE eMPLOYE;
        private System.Windows.Forms.BindingSource employesBindingSource;
        private EMPLOYETableAdapters.employesTableAdapter employesTableAdapter;
        private DevExpress.XtraEditors.TextEdit empl_IdTextEdit;
        private DevExpress.XtraEditors.TextEdit loginTextEdit;
        private DevExpress.XtraEditors.TextEdit passwordTextEdit;
        private DevExpress.XtraEditors.TextEdit nomTextEdit;
        private DevExpress.XtraEditors.TextEdit prenomTextEdit;
        private DevExpress.XtraEditors.TextEdit mailTextEdit;
        private DevExpress.XtraEditors.TextEdit telTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForempl_Id;
        private DevExpress.XtraLayout.LayoutControlItem ItemForlogin;
        private DevExpress.XtraLayout.LayoutControlItem ItemForpassword;
        private DevExpress.XtraLayout.LayoutControlItem ItemFornom;
        private DevExpress.XtraLayout.LayoutControlItem ItemForprenom;
        private DevExpress.XtraLayout.LayoutControlItem ItemFormail;
        private DevExpress.XtraLayout.LayoutControlItem ItemFortel;
    }
}