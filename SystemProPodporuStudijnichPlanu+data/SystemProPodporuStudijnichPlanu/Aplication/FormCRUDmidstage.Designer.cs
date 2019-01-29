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
            this.gb_vyber.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_close
            // 
            this.bt_close.BackColor = System.Drawing.Color.Red;
            this.bt_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_close.Location = new System.Drawing.Point(713, 12);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(75, 23);
            this.bt_close.TabIndex = 3;
            this.bt_close.Text = "Zavřít";
            this.bt_close.UseVisualStyleBackColor = false;
            this.bt_close.Click += new System.EventHandler(this.Bt_close_Click);
            // 
            // bt_smazat
            // 
            this.bt_smazat.BackColor = System.Drawing.Color.Linen;
            this.bt_smazat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_smazat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_smazat.Location = new System.Drawing.Point(174, 12);
            this.bt_smazat.Name = "bt_smazat";
            this.bt_smazat.Size = new System.Drawing.Size(75, 23);
            this.bt_smazat.TabIndex = 4;
            this.bt_smazat.Text = "Smazat";
            this.bt_smazat.UseVisualStyleBackColor = false;
            // 
            // bt_novy
            // 
            this.bt_novy.BackColor = System.Drawing.Color.Honeydew;
            this.bt_novy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_novy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_novy.Location = new System.Drawing.Point(12, 12);
            this.bt_novy.Name = "bt_novy";
            this.bt_novy.Size = new System.Drawing.Size(75, 23);
            this.bt_novy.TabIndex = 5;
            this.bt_novy.Text = "Nový";
            this.bt_novy.UseVisualStyleBackColor = false;
            this.bt_novy.Click += new System.EventHandler(this.Bt_novy_Click);
            // 
            // bt_upravit
            // 
            this.bt_upravit.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.bt_upravit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_upravit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_upravit.Location = new System.Drawing.Point(93, 12);
            this.bt_upravit.Name = "bt_upravit";
            this.bt_upravit.Size = new System.Drawing.Size(75, 23);
            this.bt_upravit.TabIndex = 6;
            this.bt_upravit.Text = "Upravit";
            this.bt_upravit.UseVisualStyleBackColor = false;
            // 
            // cb_katedra
            // 
            this.cb_katedra.FormattingEnabled = true;
            this.cb_katedra.Location = new System.Drawing.Point(12, 166);
            this.cb_katedra.Name = "cb_katedra";
            this.cb_katedra.Size = new System.Drawing.Size(169, 21);
            this.cb_katedra.Sorted = true;
            this.cb_katedra.TabIndex = 7;
            // 
            // cb_obor
            // 
            this.cb_obor.FormattingEnabled = true;
            this.cb_obor.Location = new System.Drawing.Point(12, 193);
            this.cb_obor.Name = "cb_obor";
            this.cb_obor.Size = new System.Drawing.Size(169, 21);
            this.cb_obor.Sorted = true;
            this.cb_obor.TabIndex = 8;
            // 
            // rb_predmet
            // 
            this.rb_predmet.AutoSize = true;
            this.rb_predmet.Location = new System.Drawing.Point(18, 65);
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
            this.rb_obor.Location = new System.Drawing.Point(18, 19);
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
            this.rb_katedra.Location = new System.Drawing.Point(18, 42);
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
            this.rb_garant.Location = new System.Drawing.Point(18, 88);
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
            this.gb_vyber.Location = new System.Drawing.Point(12, 41);
            this.gb_vyber.Name = "gb_vyber";
            this.gb_vyber.Size = new System.Drawing.Size(169, 119);
            this.gb_vyber.TabIndex = 13;
            this.gb_vyber.TabStop = false;
            this.gb_vyber.Text = "Vyberte s čím chcete pracovat";
            // 
            // cb_garant
            // 
            this.cb_garant.FormattingEnabled = true;
            this.cb_garant.Location = new System.Drawing.Point(12, 220);
            this.cb_garant.Name = "cb_garant";
            this.cb_garant.Size = new System.Drawing.Size(169, 21);
            this.cb_garant.TabIndex = 14;
            // 
            // FormCRUDmidstage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CancelButton = this.bt_close;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_garant);
            this.Controls.Add(this.gb_vyber);
            this.Controls.Add(this.cb_obor);
            this.Controls.Add(this.cb_katedra);
            this.Controls.Add(this.bt_upravit);
            this.Controls.Add(this.bt_novy);
            this.Controls.Add(this.bt_smazat);
            this.Controls.Add(this.bt_close);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCRUDmidstage";
            this.Text = "FormCRUDmidstage";
            this.gb_vyber.ResumeLayout(false);
            this.gb_vyber.PerformLayout();
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
    }
}