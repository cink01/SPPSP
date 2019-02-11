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
            this.cb_katedra = new System.Windows.Forms.ComboBox();
            this.cb_obor = new System.Windows.Forms.ComboBox();
            this.rb_predmet = new System.Windows.Forms.RadioButton();
            this.rb_obor = new System.Windows.Forms.RadioButton();
            this.rb_katedra = new System.Windows.Forms.RadioButton();
            this.rb_garant = new System.Windows.Forms.RadioButton();
            this.gb_vyber = new System.Windows.Forms.GroupBox();
            this.cb_garant = new System.Windows.Forms.ComboBox();
            this.cb_predmet = new System.Windows.Forms.ComboBox();
            this.tb_katedraN = new System.Windows.Forms.TextBox();
            this.tb_oborN = new System.Windows.Forms.TextBox();
            this.tb_garantN = new System.Windows.Forms.TextBox();
            this.tb_predmetN = new System.Windows.Forms.TextBox();
            this.gb_k = new System.Windows.Forms.GroupBox();
            this.gb_o = new System.Windows.Forms.GroupBox();
            this.gb_g = new System.Windows.Forms.GroupBox();
            this.gb_p = new System.Windows.Forms.GroupBox();
            this.gb_vyber.SuspendLayout();
            this.gb_k.SuspendLayout();
            this.gb_o.SuspendLayout();
            this.gb_g.SuspendLayout();
            this.gb_p.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_close
            // 
            this.bt_close.BackColor = System.Drawing.Color.Red;
            this.bt_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_close.Location = new System.Drawing.Point(662, 268);
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
            this.bt_smazat.Location = new System.Drawing.Point(174, 268);
            this.bt_smazat.Name = "bt_smazat";
            this.bt_smazat.Size = new System.Drawing.Size(75, 23);
            this.bt_smazat.TabIndex = 4;
            this.bt_smazat.Text = "Smazat";
            this.bt_smazat.UseVisualStyleBackColor = false;
            // 
            // bt_novy
            // 
            this.bt_novy.BackColor = System.Drawing.Color.GreenYellow;
            this.bt_novy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_novy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_novy.Location = new System.Drawing.Point(12, 268);
            this.bt_novy.Name = "bt_novy";
            this.bt_novy.Size = new System.Drawing.Size(75, 23);
            this.bt_novy.TabIndex = 5;
            this.bt_novy.Text = "Nový";
            this.bt_novy.UseVisualStyleBackColor = false;
            this.bt_novy.Click += new System.EventHandler(this.Bt_novy_Click);
            // 
            // bt_upravit
            // 
            this.bt_upravit.BackColor = System.Drawing.Color.LemonChiffon;
            this.bt_upravit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_upravit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_upravit.Location = new System.Drawing.Point(93, 268);
            this.bt_upravit.Name = "bt_upravit";
            this.bt_upravit.Size = new System.Drawing.Size(75, 23);
            this.bt_upravit.TabIndex = 6;
            this.bt_upravit.Text = "Upravit";
            this.bt_upravit.UseVisualStyleBackColor = false;
            // 
            // cb_katedra
            // 
            this.cb_katedra.FormattingEnabled = true;
            this.cb_katedra.Location = new System.Drawing.Point(6, 19);
            this.cb_katedra.Name = "cb_katedra";
            this.cb_katedra.Size = new System.Drawing.Size(169, 21);
            this.cb_katedra.Sorted = true;
            this.cb_katedra.TabIndex = 7;
            // 
            // cb_obor
            // 
            this.cb_obor.FormattingEnabled = true;
            this.cb_obor.Location = new System.Drawing.Point(6, 19);
            this.cb_obor.Name = "cb_obor";
            this.cb_obor.Size = new System.Drawing.Size(169, 21);
            this.cb_obor.Sorted = true;
            this.cb_obor.TabIndex = 8;
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
            this.gb_vyber.Location = new System.Drawing.Point(12, 12);
            this.gb_vyber.Name = "gb_vyber";
            this.gb_vyber.Size = new System.Drawing.Size(725, 45);
            this.gb_vyber.TabIndex = 13;
            this.gb_vyber.TabStop = false;
            this.gb_vyber.Text = "Vyberte s čím chcete pracovat";
            // 
            // cb_garant
            // 
            this.cb_garant.FormattingEnabled = true;
            this.cb_garant.Location = new System.Drawing.Point(6, 19);
            this.cb_garant.Name = "cb_garant";
            this.cb_garant.Size = new System.Drawing.Size(169, 21);
            this.cb_garant.TabIndex = 14;
            // 
            // cb_predmet
            // 
            this.cb_predmet.FormattingEnabled = true;
            this.cb_predmet.Location = new System.Drawing.Point(6, 19);
            this.cb_predmet.Name = "cb_predmet";
            this.cb_predmet.Size = new System.Drawing.Size(169, 21);
            this.cb_predmet.TabIndex = 15;
            // 
            // tb_katedraN
            // 
            this.tb_katedraN.Location = new System.Drawing.Point(6, 46);
            this.tb_katedraN.Name = "tb_katedraN";
            this.tb_katedraN.Size = new System.Drawing.Size(169, 20);
            this.tb_katedraN.TabIndex = 16;
            this.tb_katedraN.TextChanged += new System.EventHandler(this.Tb_katedraN_TextChanged);
            // 
            // tb_oborN
            // 
            this.tb_oborN.Location = new System.Drawing.Point(6, 46);
            this.tb_oborN.Name = "tb_oborN";
            this.tb_oborN.Size = new System.Drawing.Size(169, 20);
            this.tb_oborN.TabIndex = 17;
            this.tb_oborN.TextChanged += new System.EventHandler(this.Tb_oborN_TextChanged);
            // 
            // tb_garantN
            // 
            this.tb_garantN.Location = new System.Drawing.Point(6, 46);
            this.tb_garantN.Name = "tb_garantN";
            this.tb_garantN.Size = new System.Drawing.Size(169, 20);
            this.tb_garantN.TabIndex = 18;
            this.tb_garantN.TextChanged += new System.EventHandler(this.Tb_garantN_TextChanged);
            // 
            // tb_predmetN
            // 
            this.tb_predmetN.Location = new System.Drawing.Point(6, 46);
            this.tb_predmetN.Name = "tb_predmetN";
            this.tb_predmetN.Size = new System.Drawing.Size(169, 20);
            this.tb_predmetN.TabIndex = 19;
            this.tb_predmetN.TextChanged += new System.EventHandler(this.Tb_predmetN_TextChanged);
            // 
            // gb_k
            // 
            this.gb_k.Controls.Add(this.cb_katedra);
            this.gb_k.Controls.Add(this.tb_katedraN);
            this.gb_k.Location = new System.Drawing.Point(12, 63);
            this.gb_k.Name = "gb_k";
            this.gb_k.Size = new System.Drawing.Size(182, 199);
            this.gb_k.TabIndex = 20;
            this.gb_k.TabStop = false;
            this.gb_k.Text = "Výběr a vybledávání kateder";
            // 
            // gb_o
            // 
            this.gb_o.Controls.Add(this.cb_obor);
            this.gb_o.Controls.Add(this.tb_oborN);
            this.gb_o.Location = new System.Drawing.Point(193, 63);
            this.gb_o.Name = "gb_o";
            this.gb_o.Size = new System.Drawing.Size(182, 199);
            this.gb_o.TabIndex = 21;
            this.gb_o.TabStop = false;
            this.gb_o.Text = "Výběr a vybledávání oborů";
            // 
            // gb_g
            // 
            this.gb_g.Controls.Add(this.cb_garant);
            this.gb_g.Controls.Add(this.tb_garantN);
            this.gb_g.Location = new System.Drawing.Point(374, 63);
            this.gb_g.Name = "gb_g";
            this.gb_g.Size = new System.Drawing.Size(182, 199);
            this.gb_g.TabIndex = 22;
            this.gb_g.TabStop = false;
            this.gb_g.Text = "Výběr a vybledávání garantů";
            // 
            // gb_p
            // 
            this.gb_p.Controls.Add(this.cb_predmet);
            this.gb_p.Controls.Add(this.tb_predmetN);
            this.gb_p.Location = new System.Drawing.Point(555, 63);
            this.gb_p.Name = "gb_p";
            this.gb_p.Size = new System.Drawing.Size(182, 199);
            this.gb_p.TabIndex = 23;
            this.gb_p.TabStop = false;
            this.gb_p.Text = "Výběr a vybledávání předmětů";
            // 
            // FormCRUDmidstage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CancelButton = this.bt_close;
            this.ClientSize = new System.Drawing.Size(750, 305);
            this.Controls.Add(this.gb_p);
            this.Controls.Add(this.gb_g);
            this.Controls.Add(this.gb_o);
            this.Controls.Add(this.gb_k);
            this.Controls.Add(this.gb_vyber);
            this.Controls.Add(this.bt_upravit);
            this.Controls.Add(this.bt_novy);
            this.Controls.Add(this.bt_smazat);
            this.Controls.Add(this.bt_close);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Button bt_smazat;
        private System.Windows.Forms.Button bt_novy;
        private System.Windows.Forms.Button bt_upravit;
        private System.Windows.Forms.ComboBox cb_katedra;
        private System.Windows.Forms.ComboBox cb_obor;
        private System.Windows.Forms.RadioButton rb_predmet;
        private System.Windows.Forms.RadioButton rb_obor;
        private System.Windows.Forms.RadioButton rb_katedra;
        private System.Windows.Forms.RadioButton rb_garant;
        private System.Windows.Forms.GroupBox gb_vyber;
        private System.Windows.Forms.ComboBox cb_garant;
        private System.Windows.Forms.ComboBox cb_predmet;
        private System.Windows.Forms.TextBox tb_katedraN;
        private System.Windows.Forms.TextBox tb_oborN;
        private System.Windows.Forms.TextBox tb_garantN;
        private System.Windows.Forms.TextBox tb_predmetN;
        private System.Windows.Forms.GroupBox gb_k;
        private System.Windows.Forms.GroupBox gb_o;
        private System.Windows.Forms.GroupBox gb_g;
        private System.Windows.Forms.GroupBox gb_p;
    }
}