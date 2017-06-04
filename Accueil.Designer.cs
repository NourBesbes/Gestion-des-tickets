namespace MyProjectV2
{
    partial class Accueil
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
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem1 = new DevExpress.XtraEditors.TileItem();
            this.tileItem2 = new DevExpress.XtraEditors.TileItem();
            this.tileItem3 = new DevExpress.XtraEditors.TileItem();
            this.tileGroup3 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem4 = new DevExpress.XtraEditors.TileItem();
            this.tileItem5 = new DevExpress.XtraEditors.TileItem();
            this.tileItem6 = new DevExpress.XtraEditors.TileItem();
            this.tileItem7 = new DevExpress.XtraEditors.TileItem();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tileControl1
            // 
            this.tileControl1.AllowSelectedItem = true;
            this.tileControl1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tileControl1.DragSize = new System.Drawing.Size(0, 0);
            this.tileControl1.Groups.Add(this.tileGroup2);
            this.tileControl1.Groups.Add(this.tileGroup3);
            this.tileControl1.Location = new System.Drawing.Point(-121, -100);
            this.tileControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tileControl1.MaxId = 9;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Padding = new System.Windows.Forms.Padding(14, 15, 14, 15);
            this.tileControl1.Size = new System.Drawing.Size(915, 596);
            this.tileControl1.TabIndex = 9;
            this.tileControl1.Text = "tileControl1";
            this.tileControl1.Click += new System.EventHandler(this.tileControl1_Click);
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.tileItem3);
            this.tileGroup2.Items.Add(this.tileItem1);
            this.tileGroup2.Items.Add(this.tileItem2);
            this.tileGroup2.Name = "tileGroup2";
            // 
            // tileItem1
            // 
            this.tileItem1.AppearanceItem.Hovered.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tileItem1.AppearanceItem.Hovered.BackColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.tileItem1.AppearanceItem.Hovered.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.tileItem1.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tileItem1.AppearanceItem.Hovered.Options.UseBorderColor = true;
            this.tileItem1.AppearanceItem.Normal.BackColor = System.Drawing.Color.SteelBlue;
            this.tileItem1.AppearanceItem.Normal.Options.UseBackColor = true;
            tileItemElement2.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement2.Image")));
            tileItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement2.ImageIndex = -6;
            tileItemElement2.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Bottom;
            tileItemElement2.Text = "Gestion du compte";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            this.tileItem1.Elements.Add(tileItemElement2);
            this.tileItem1.Id = 0;
            this.tileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem1.Name = "tileItem1";
            this.tileItem1.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem1_ItemClick);
            // 
            // tileItem2
            // 
            this.tileItem2.AppearanceItem.Normal.BackColor = System.Drawing.Color.SteelBlue;
            this.tileItem2.AppearanceItem.Normal.Options.UseBackColor = true;
            tileItemElement3.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement3.Image")));
            tileItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement3.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Bottom;
            tileItemElement3.Text = "Gestion des contrats";
            tileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            this.tileItem2.Elements.Add(tileItemElement3);
            this.tileItem2.Id = 2;
            this.tileItem2.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem2.Name = "tileItem2";
            this.tileItem2.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem2_ItemClick);
            // 
            // tileItem3
            // 
            this.tileItem3.AppearanceItem.Normal.BackColor = System.Drawing.Color.SteelBlue;
            this.tileItem3.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItem3.BackgroundImage = global::MyProjectV2.Properties.Resources.User_icon8;
            this.tileItem3.BackgroundImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            tileItemElement1.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.None;
            tileItemElement1.Text = "tileIte";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            this.tileItem3.Elements.Add(tileItemElement1);
            this.tileItem3.Id = 4;
            this.tileItem3.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem3.Name = "tileItem3";
            this.tileItem3.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem3_ItemClick);
            // 
            // tileGroup3
            // 
            this.tileGroup3.Items.Add(this.tileItem4);
            this.tileGroup3.Items.Add(this.tileItem5);
            this.tileGroup3.Items.Add(this.tileItem6);
            this.tileGroup3.Items.Add(this.tileItem7);
            this.tileGroup3.Name = "tileGroup3";
            // 
            // tileItem4
            // 
            this.tileItem4.AppearanceItem.Normal.BackColor = System.Drawing.Color.SteelBlue;
            this.tileItem4.AppearanceItem.Normal.Options.UseBackColor = true;
            tileItemElement4.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement4.Image")));
            tileItemElement4.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement4.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Bottom;
            tileItemElement4.Text = "Afficher les tickets";
            tileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            this.tileItem4.Elements.Add(tileItemElement4);
            this.tileItem4.Id = 5;
            this.tileItem4.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem4.Name = "tileItem4";
            this.tileItem4.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem4_ItemClick);
            // 
            // tileItem5
            // 
            this.tileItem5.AppearanceItem.Normal.BackColor = System.Drawing.Color.SteelBlue;
            this.tileItem5.AppearanceItem.Normal.Options.UseBackColor = true;
            tileItemElement5.Image = global::MyProjectV2.Properties.Resources._29637;
            tileItemElement5.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement5.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Bottom;
            tileItemElement5.Text = "Afficher les tickets ouverts";
            tileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual;
            this.tileItem5.Elements.Add(tileItemElement5);
            this.tileItem5.Id = 6;
            this.tileItem5.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem5.Name = "tileItem5";
            this.tileItem5.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem5_ItemClick);
            // 
            // tileItem6
            // 
            this.tileItem6.AppearanceItem.Normal.BackColor = System.Drawing.Color.SteelBlue;
            this.tileItem6.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItem6.Checked = true;
            tileItemElement6.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement6.Image")));
            tileItemElement6.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement6.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Bottom;
            tileItemElement6.Text = "Afficher les tickets fermés";
            tileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            this.tileItem6.Elements.Add(tileItemElement6);
            this.tileItem6.Id = 7;
            this.tileItem6.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem6.Name = "tileItem6";
            this.tileItem6.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem6_ItemClick);
            // 
            // tileItem7
            // 
            this.tileItem7.AppearanceItem.Normal.BackColor = System.Drawing.Color.SteelBlue;
            this.tileItem7.AppearanceItem.Normal.Options.UseBackColor = true;
            tileItemElement7.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement7.Image")));
            tileItemElement7.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement7.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Bottom;
            tileItemElement7.Text = "Statistique";
            tileItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter;
            this.tileItem7.Elements.Add(tileItemElement7);
            this.tileItem7.Id = 8;
            this.tileItem7.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem7.Name = "tileItem7";
            this.tileItem7.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem7_ItemClick);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.BackgroundImage = global::MyProjectV2.Properties.Resources.Reload_icon;
            this.simpleButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton1.Image = global::MyProjectV2.Properties.Resources.Reload_icon1;
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(628, 10);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(38, 54);
            this.simpleButton1.TabIndex = 15;
            this.simpleButton1.Text = "\r\n";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = global::MyProjectV2.Properties.Resources.Logooo;
            this.pictureBox1.Location = new System.Drawing.Point(568, 385);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 26);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 413);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tileControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.TransparencyKey = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem tileItem1;
        private DevExpress.XtraEditors.TileItem tileItem2;
        private DevExpress.XtraEditors.TileItem tileItem3;
        private DevExpress.XtraEditors.TileGroup tileGroup3;
        private DevExpress.XtraEditors.TileItem tileItem4;
        private DevExpress.XtraEditors.TileItem tileItem5;
        private DevExpress.XtraEditors.TileItem tileItem6;
        private DevExpress.XtraEditors.TileItem tileItem7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}