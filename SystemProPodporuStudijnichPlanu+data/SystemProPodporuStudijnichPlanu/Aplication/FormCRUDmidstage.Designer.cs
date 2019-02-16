namespace SystemProPodporuStudijnichPlanu.Aplication
{
    partial class FormCRUDmidstage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCRUDmidstage));
            this.bt_close = new System.Windows.Forms.Button();
            this.bt_smazat = new System.Windows.Forms.Button();
            this.bt_novy = new System.Windows.Forms.Button();
            this.bt_upravit = new System.Windows.Forms.Button();
            this.rb_predmet = new System.Windows.Forms.RadioButton();
            this.rb_obor = new System.Windows.Forms.RadioButton();
            this.rb_katedra = new System.Windows.Forms.RadioButton();
            this.rb_garant = new System.Windows.Forms.RadioButton();
            this.gb_vyber = new System.Windows.Forms.GroupBox();
            this.gb_k = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_kat = new System.Windows.Forms.ComboBox();
            this.gb_o = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_obo = new System.Windows.Forms.ComboBox();
            this.gb_g = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_kat_gar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_garant = new System.Windows.Forms.ComboBox();
            this.gb_p = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_obo_pre = new System.Windows.Forms.ComboBox();
            this.cb_pre = new System.Windows.Forms.ComboBox();
            this.cb_semestry = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_povin = new System.Windows.Forms.ComboBox();
            this.vypisPopisPredmetMid = new SystemProPodporuStudijnichPlanu.Komponenty.VypisPopisPredmetcs();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.povolitSprávuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hromadnéNačteníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.naplnitDatabáziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.přidatPopisyKPředmětůmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_vyber.SuspendLayout();
            this.gb_k.SuspendLayout();
            this.gb_o.SuspendLayout();
            this.gb_g.SuspendLayout();
            this.gb_p.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_close
            // 
            this.bt_close.BackColor = System.Drawing.Color.Red;
            this.bt_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_close.Location = new System.Drawing.Point(653, 337);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(75, 23);
            this.bt_close.TabIndex = 3;
            this.bt_close.Text = "Zavřít";
            this.bt_close.UseVisualStyleBackColor = false;
            this.bt_close.Click += new System.EventHandler(this.Bt_close_Click);
            // 
            // bt_smazat
            // 
            this.bt_smazat.BackColor = System.Drawing.Color.Bisque;
            this.bt_smazat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_smazat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_smazat.Location = new System.Drawing.Point(165, 337);
            this.bt_smazat.Name = "bt_smazat";
            this.bt_smazat.Size = new System.Drawing.Size(75, 23);
            this.bt_smazat.TabIndex = 4;
            this.bt_smazat.Text = "Smazat";
            this.bt_smazat.UseVisualStyleBackColor = false;
            this.bt_smazat.Visible = false;
            this.bt_smazat.Click += new System.EventHandler(this.Bt_smazat_Click);
            // 
            // bt_novy
            // 
            this.bt_novy.BackColor = System.Drawing.Color.GreenYellow;
            this.bt_novy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_novy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_novy.Location = new System.Drawing.Point(3, 337);
            this.bt_novy.Name = "bt_novy";
            this.bt_novy.Size = new System.Drawing.Size(75, 23);
            this.bt_novy.TabIndex = 5;
            this.bt_novy.Text = "Nový";
            this.bt_novy.UseVisualStyleBackColor = false;
            this.bt_novy.Visible = false;
            this.bt_novy.Click += new System.EventHandler(this.Bt_novy_Click);
            // 
            // bt_upravit
            // 
            this.bt_upravit.BackColor = System.Drawing.Color.LemonChiffon;
            this.bt_upravit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_upravit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_upravit.Location = new System.Drawing.Point(84, 337);
            this.bt_upravit.Name = "bt_upravit";
            this.bt_upravit.Size = new System.Drawing.Size(75, 23);
            this.bt_upravit.TabIndex = 6;
            this.bt_upravit.Text = "Upravit";
            this.bt_upravit.UseVisualStyleBackColor = false;
            this.bt_upravit.Visible = false;
            this.bt_upravit.Click += new System.EventHandler(this.Bt_upravit_Click);
            // 
            // rb_predmet
            // 
            this.rb_predmet.AutoSize = true;
            this.rb_predmet.Location = new System.Drawing.Point(599, 19);
            this.rb_predmet.Name = "rb_predmet";
            this.rb_predmet.Size = new System.Drawing.Size(65, 17);
            this.rb_predmet.TabIndex = 9;
            this.rb_predmet.TabStop = true;
            this.rb_predmet.Text = "Předmět";
            this.rb_predmet.UseVisualStyleBackColor = true;
            // 
            // rb_obor
            // 
            this.rb_obor.AutoSize = true;
            this.rb_obor.Location = new System.Drawing.Point(244, 19);
            this.rb_obor.Name = "rb_obor";
            this.rb_obor.Size = new System.Drawing.Size(48, 17);
            this.rb_obor.TabIndex = 10;
            this.rb_obor.TabStop = true;
            this.rb_obor.Text = "Obor";
            this.rb_obor.UseVisualStyleBackColor = true;
            // 
            // rb_katedra
            // 
            this.rb_katedra.AutoSize = true;
            this.rb_katedra.Location = new System.Drawing.Point(18, 19);
            this.rb_katedra.Name = "rb_katedra";
            this.rb_katedra.Size = new System.Drawing.Size(62, 17);
            this.rb_katedra.TabIndex = 11;
            this.rb_katedra.TabStop = true;
            this.rb_katedra.Text = "Katedra";
            this.rb_katedra.UseVisualStyleBackColor = true;
            // 
            // rb_garant
            // 
            this.rb_garant.AutoSize = true;
            this.rb_garant.Location = new System.Drawing.Point(418, 19);
            this.rb_garant.Name = "rb_garant";
            this.rb_garant.Size = new System.Drawing.Size(57, 17);
            this.rb_garant.TabIndex = 12;
            this.rb_garant.TabStop = true;
            this.rb_garant.Text = "Garant";
            this.rb_garant.UseVisualStyleBackColor = true;
            // 
            // gb_vyber
            // 
            this.gb_vyber.Controls.Add(this.rb_obor);
            this.gb_vyber.Controls.Add(this.rb_garant);
            this.gb_vyber.Controls.Add(this.rb_predmet);
            this.gb_vyber.Controls.Add(this.rb_katedra);
            this.gb_vyber.Location = new System.Drawing.Point(3, 27);
            this.gb_vyber.Name = "gb_vyber";
            this.gb_vyber.Size = new System.Drawing.Size(725, 45);
            this.gb_vyber.TabIndex = 13;
            this.gb_vyber.TabStop = false;
            this.gb_vyber.Text = "Vyberte s čím chcete pracovat";
            // 
            // gb_k
            // 
            this.gb_k.Controls.Add(this.label8);
            this.gb_k.Controls.Add(this.cb_kat);
            this.gb_k.Location = new System.Drawing.Point(3, 78);
            this.gb_k.Name = "gb_k";
            this.gb_k.Size = new System.Drawing.Size(182, 67);
            this.gb_k.TabIndex = 20;
            this.gb_k.TabStop = false;
            this.gb_k.Text = "Výběr a vyhledávání kateder";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Katedra:";
            // 
            // cb_kat
            // 
            this.cb_kat.FormattingEnabled = true;
            this.cb_kat.Location = new System.Drawing.Point(13, 30);
            this.cb_kat.Name = "cb_kat";
            this.cb_kat.Size = new System.Drawing.Size(168, 21);
            this.cb_kat.TabIndex = 21;
            this.cb_kat.DropDown += new System.EventHandler(this.Cb_katedra_Hledani);
            // 
            // gb_o
            // 
            this.gb_o.Controls.Add(this.label1);
            this.gb_o.Controls.Add(this.cb_obo);
            this.gb_o.Location = new System.Drawing.Point(184, 78);
            this.gb_o.Name = "gb_o";
            this.gb_o.Size = new System.Drawing.Size(182, 67);
            this.gb_o.TabIndex = 21;
            this.gb_o.TabStop = false;
            this.gb_o.Text = "Výběr a vyhledávání oborů";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Obor:";
            // 
            // cb_obo
            // 
            this.cb_obo.DropDownWidth = 200;
            this.cb_obo.FormattingEnabled = true;
            this.cb_obo.Location = new System.Drawing.Point(6, 30);
            this.cb_obo.Name = "cb_obo";
            this.cb_obo.Size = new System.Drawing.Size(168, 21);
            this.cb_obo.TabIndex = 22;
            this.cb_obo.DropDown += new System.EventHandler(this.Cb_obor_Hledani);
            // 
            // gb_g
            // 
            this.gb_g.Controls.Add(this.label3);
            this.gb_g.Controls.Add(this.cmb_kat_gar);
            this.gb_g.Controls.Add(this.label2);
            this.gb_g.Controls.Add(this.cb_garant);
            this.gb_g.Location = new System.Drawing.Point(365, 78);
            this.gb_g.Name = "gb_g";
            this.gb_g.Size = new System.Drawing.Size(182, 110);
            this.gb_g.TabIndex = 22;
            this.gb_g.TabStop = false;
            this.gb_g.Text = "Výběr a vyhledávání garantů";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Katedra:";
            // 
            // cmb_kat_gar
            // 
            this.cmb_kat_gar.FormattingEnabled = true;
            this.cmb_kat_gar.Location = new System.Drawing.Point(6, 30);
            this.cmb_kat_gar.Name = "cmb_kat_gar";
            this.cmb_kat_gar.Size = new System.Drawing.Size(168, 21);
            this.cmb_kat_gar.TabIndex = 29;
            this.cmb_kat_gar.DropDown += new System.EventHandler(this.Cmb_kat_gar_hledaní);
            this.cmb_kat_gar.SelectedIndexChanged += new System.EventHandler(this.Cmb_kat_gar_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Garant:";
            // 
            // cb_garant
            // 
            this.cb_garant.FormattingEnabled = true;
            this.cb_garant.Location = new System.Drawing.Point(6, 68);
            this.cb_garant.Name = "cb_garant";
            this.cb_garant.Size = new System.Drawing.Size(169, 21);
            this.cb_garant.TabIndex = 20;
            this.cb_garant.DropDown += new System.EventHandler(this.Cb_garant_Hledani);
            // 
            // gb_p
            // 
            this.gb_p.Controls.Add(this.label7);
            this.gb_p.Controls.Add(this.cmb_obo_pre);
            this.gb_p.Controls.Add(this.cb_pre);
            this.gb_p.Controls.Add(this.cb_semestry);
            this.gb_p.Controls.Add(this.label6);
            this.gb_p.Controls.Add(this.label4);
            this.gb_p.Controls.Add(this.label5);
            this.gb_p.Controls.Add(this.cmb_povin);
            this.gb_p.Location = new System.Drawing.Point(546, 78);
            this.gb_p.Name = "gb_p";
            this.gb_p.Size = new System.Drawing.Size(182, 164);
            this.gb_p.TabIndex = 23;
            this.gb_p.TabStop = false;
            this.gb_p.Text = "Výběr a vyhledávání předmětů";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Obor:";
            // 
            // cmb_obo_pre
            // 
            this.cmb_obo_pre.FormattingEnabled = true;
            this.cmb_obo_pre.Location = new System.Drawing.Point(6, 30);
            this.cmb_obo_pre.Name = "cmb_obo_pre";
            this.cmb_obo_pre.Size = new System.Drawing.Size(168, 21);
            this.cmb_obo_pre.TabIndex = 24;
            this.cmb_obo_pre.DropDown += new System.EventHandler(this.Cmb_obo_pre_Hledání);
            this.cmb_obo_pre.SelectedIndexChanged += new System.EventHandler(this.Cmb_obo_pre_SelectedIndexChanged);
            // 
            // cb_pre
            // 
            this.cb_pre.FormattingEnabled = true;
            this.cb_pre.Location = new System.Drawing.Point(6, 67);
            this.cb_pre.Name = "cb_pre";
            this.cb_pre.Size = new System.Drawing.Size(168, 21);
            this.cb_pre.TabIndex = 22;
            this.cb_pre.DropDown += new System.EventHandler(this.Cb_predmet_Hledani);
            this.cb_pre.SelectedIndexChanged += new System.EventHandler(this.Cb_pre_SelectedIndexChanged);
            // 
            // cb_semestry
            // 
            this.cb_semestry.DropDownWidth = 50;
            this.cb_semestry.FormattingEnabled = true;
            this.cb_semestry.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "Nezařazené",
            "Všechny"});
            this.cb_semestry.Location = new System.Drawing.Point(63, 121);
            this.cb_semestry.Name = "cb_semestry";
            this.cb_semestry.Size = new System.Drawing.Size(111, 21);
            this.cb_semestry.TabIndex = 23;
            this.cb_semestry.SelectedIndexChanged += new System.EventHandler(this.Cb_semestry_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Semestr:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Název:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Povinnost:";
            // 
            // cmb_povin
            // 
            this.cmb_povin.DropDownWidth = 200;
            this.cmb_povin.FormattingEnabled = true;
            this.cmb_povin.Items.AddRange(new object[] {
            "\"Povinný předmět\"",
            "\"Cizí jazyk\"",
            "\"Volitelný předmět\"",
            "\"Povinně volitelný\"",
            "\"Volitelný předmět (sportovní aktivita)\""});
            this.cmb_povin.Location = new System.Drawing.Point(63, 94);
            this.cmb_povin.Name = "cmb_povin";
            this.cmb_povin.Size = new System.Drawing.Size(111, 21);
            this.cmb_povin.TabIndex = 20;
            // 
            // vypisPopisPredmetMid
            // 
            this.vypisPopisPredmetMid.Cviceni = "";
            this.vypisPopisPredmetMid.Garant = "";
            this.vypisPopisPredmetMid.Jazyk = "";
            this.vypisPopisPredmetMid.Kombi = "";
            this.vypisPopisPredmetMid.Kredit = "";
            this.vypisPopisPredmetMid.Lab = "";
            this.vypisPopisPredmetMid.Location = new System.Drawing.Point(734, 27);
            this.vypisPopisPredmetMid.Name = "vypisPopisPredmetMid";
            this.vypisPopisPredmetMid.P = null;
            this.vypisPopisPredmetMid.Popis = "";
            this.vypisPopisPredmetMid.Povinnost = "";
            this.vypisPopisPredmetMid.Prednaska = "";
            this.vypisPopisPredmetMid.Prerekvizita = "";
            this.vypisPopisPredmetMid.Size = new System.Drawing.Size(388, 341);
            this.vypisPopisPredmetMid.TabIndex = 24;
            this.vypisPopisPredmetMid.Zakončení = "";
            this.vypisPopisPredmetMid.Zkr = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.povolitSprávuToolStripMenuItem,
            this.hromadnéNačteníToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1126, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // povolitSprávuToolStripMenuItem
            // 
            this.povolitSprávuToolStripMenuItem.Name = "povolitSprávuToolStripMenuItem";
            this.povolitSprávuToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.povolitSprávuToolStripMenuItem.Text = "Povolit správu";
            this.povolitSprávuToolStripMenuItem.Click += new System.EventHandler(this.PovolitSprávuToolStripMenuItem_Click);
            // 
            // hromadnéNačteníToolStripMenuItem
            // 
            this.hromadnéNačteníToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.naplnitDatabáziToolStripMenuItem,
            this.přidatPopisyKPředmětůmToolStripMenuItem});
            this.hromadnéNačteníToolStripMenuItem.Name = "hromadnéNačteníToolStripMenuItem";
            this.hromadnéNačteníToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.hromadnéNačteníToolStripMenuItem.Text = "Hromadné načtení";
            this.hromadnéNačteníToolStripMenuItem.Visible = false;
            // 
            // naplnitDatabáziToolStripMenuItem
            // 
            this.naplnitDatabáziToolStripMenuItem.Name = "naplnitDatabáziToolStripMenuItem";
            this.naplnitDatabáziToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.naplnitDatabáziToolStripMenuItem.Text = "Naplnit databázi";
            this.naplnitDatabáziToolStripMenuItem.Click += new System.EventHandler(this.NaplnitDatabáziToolStripMenuItem_Click);
            // 
            // přidatPopisyKPředmětůmToolStripMenuItem
            // 
            this.přidatPopisyKPředmětůmToolStripMenuItem.Name = "přidatPopisyKPředmětůmToolStripMenuItem";
            this.přidatPopisyKPředmětůmToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.přidatPopisyKPředmětůmToolStripMenuItem.Text = "Přidat popisy k předmětům";
            this.přidatPopisyKPředmětůmToolStripMenuItem.Click += new System.EventHandler(this.PřidatPopisyKPředmětůmToolStripMenuItem_Click);
            // 
            // FormCRUDmidstage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CancelButton = this.bt_close;
            this.ClientSize = new System.Drawing.Size(1126, 372);
            this.Controls.Add(this.vypisPopisPredmetMid);
            this.Controls.Add(this.gb_p);
            this.Controls.Add(this.gb_g);
            this.Controls.Add(this.gb_o);
            this.Controls.Add(this.gb_k);
            this.Controls.Add(this.gb_vyber);
            this.Controls.Add(this.bt_upravit);
            this.Controls.Add(this.bt_novy);
            this.Controls.Add(this.bt_smazat);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormCRUDmidstage";
            this.Text = "FormCRUDmidstage";
            this.Load += new System.EventHandler(this.FormCRUDmidstage_Load);
            this.gb_vyber.ResumeLayout(false);
            this.gb_vyber.PerformLayout();
            this.gb_k.ResumeLayout(false);
            this.gb_k.PerformLayout();
            this.gb_o.ResumeLayout(false);
            this.gb_o.PerformLayout();
            this.gb_g.ResumeLayout(false);
            this.gb_g.PerformLayout();
            this.gb_p.ResumeLayout(false);
            this.gb_p.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Button bt_smazat;
        private System.Windows.Forms.Button bt_novy;
        private System.Windows.Forms.Button bt_upravit;
        private System.Windows.Forms.RadioButton rb_predmet;
        private System.Windows.Forms.RadioButton rb_obor;
        private System.Windows.Forms.RadioButton rb_katedra;
        private System.Windows.Forms.RadioButton rb_garant;
        private System.Windows.Forms.GroupBox gb_vyber;
        private System.Windows.Forms.GroupBox gb_k;
        private System.Windows.Forms.GroupBox gb_o;
        private System.Windows.Forms.GroupBox gb_g;
        private System.Windows.Forms.GroupBox gb_p;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_povin;
        private System.Windows.Forms.ComboBox cb_semestry;
        private System.Windows.Forms.ComboBox cb_garant;
        private System.Windows.Forms.ComboBox cb_kat;
        private System.Windows.Forms.ComboBox cb_obo;
        private System.Windows.Forms.ComboBox cb_pre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_obo_pre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_kat_gar;
        private System.Windows.Forms.Label label2;
        private Komponenty.VypisPopisPredmetcs vypisPopisPredmetMid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem povolitSprávuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hromadnéNačteníToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem naplnitDatabáziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem přidatPopisyKPředmětůmToolStripMenuItem;
    }
}