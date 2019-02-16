namespace SystemProPodporuStudijnichPlanu
{
    partial class FormPridavani
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
            this.bt_ok = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_rem = new System.Windows.Forms.Button();
            this.lb_vypis = new System.Windows.Forms.ListBox();
            this.lb_chci = new System.Windows.Forms.ListBox();
            this.nud_kredity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.vypisPopisPredmet = new SystemProPodporuStudijnichPlanu.Komponenty.VypisPopisPredmetcs();
            ((System.ComponentModel.ISupportInitialize)(this.nud_kredity)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_ok
            // 
            this.bt_ok.BackColor = System.Drawing.Color.Lime;
            this.bt_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_ok.Location = new System.Drawing.Point(527, 347);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(75, 23);
            this.bt_ok.TabIndex = 0;
            this.bt_ok.Text = "Ok";
            this.bt_ok.UseVisualStyleBackColor = false;
            // 
            // bt_close
            // 
            this.bt_close.BackColor = System.Drawing.Color.Red;
            this.bt_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_close.Location = new System.Drawing.Point(667, 348);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(75, 23);
            this.bt_close.TabIndex = 1;
            this.bt_close.Text = "Zavřít";
            this.bt_close.UseVisualStyleBackColor = false;
            this.bt_close.Click += new System.EventHandler(this.Bt_close_Click);
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.Color.Chartreuse;
            this.bt_add.Image = global::SystemProPodporuStudijnichPlanu.Properties.Resources.ButtonL53;
            this.bt_add.Location = new System.Drawing.Point(608, 118);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(53, 53);
            this.bt_add.TabIndex = 2;
            this.bt_add.Text = "button1";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Click += new System.EventHandler(this.Bt_add_Click);
            // 
            // bt_rem
            // 
            this.bt_rem.BackColor = System.Drawing.Color.Red;
            this.bt_rem.Image = global::SystemProPodporuStudijnichPlanu.Properties.Resources.ButtonR53;
            this.bt_rem.Location = new System.Drawing.Point(608, 177);
            this.bt_rem.Name = "bt_rem";
            this.bt_rem.Size = new System.Drawing.Size(53, 53);
            this.bt_rem.TabIndex = 3;
            this.bt_rem.Text = "button2";
            this.bt_rem.UseVisualStyleBackColor = false;
            this.bt_rem.Click += new System.EventHandler(this.Bt_rem_Click);
            // 
            // lb_vypis
            // 
            this.lb_vypis.FormattingEnabled = true;
            this.lb_vypis.HorizontalScrollbar = true;
            this.lb_vypis.Location = new System.Drawing.Point(394, 12);
            this.lb_vypis.Name = "lb_vypis";
            this.lb_vypis.Size = new System.Drawing.Size(208, 329);
            this.lb_vypis.TabIndex = 4;
            this.lb_vypis.SelectedIndexChanged += new System.EventHandler(this.Lb_vypis_SelectedIndexChanged);
            // 
            // lb_chci
            // 
            this.lb_chci.FormattingEnabled = true;
            this.lb_chci.HorizontalScrollbar = true;
            this.lb_chci.Location = new System.Drawing.Point(667, 13);
            this.lb_chci.Name = "lb_chci";
            this.lb_chci.Size = new System.Drawing.Size(208, 329);
            this.lb_chci.TabIndex = 5;
            this.lb_chci.SelectedIndexChanged += new System.EventHandler(this.Lb_chci_SelectedIndexChanged);
            // 
            // nud_kredity
            // 
            this.nud_kredity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nud_kredity.Location = new System.Drawing.Point(835, 347);
            this.nud_kredity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_kredity.Name = "nud_kredity";
            this.nud_kredity.ReadOnly = true;
            this.nud_kredity.Size = new System.Drawing.Size(40, 23);
            this.nud_kredity.TabIndex = 6;
            this.nud_kredity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_kredity.ThousandsSeparator = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(790, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kredity";
            // 
            // vypisPopisPredmet
            // 
            this.vypisPopisPredmet.Cviceni = "";
            this.vypisPopisPredmet.Garant = "";
            this.vypisPopisPredmet.Jazyk = "";
            this.vypisPopisPredmet.Kombi = "";
            this.vypisPopisPredmet.Kredit = "";
            this.vypisPopisPredmet.Lab = "";
            this.vypisPopisPredmet.Location = new System.Drawing.Point(-1, 3);
            this.vypisPopisPredmet.Name = "vypisPopisPredmet";
            this.vypisPopisPredmet.P = null;
            this.vypisPopisPredmet.Popis = "";
            this.vypisPopisPredmet.Povinnost = "";
            this.vypisPopisPredmet.Prednaska = "";
            this.vypisPopisPredmet.Prerekvizita = "";
            this.vypisPopisPredmet.Size = new System.Drawing.Size(388, 341);
            this.vypisPopisPredmet.TabIndex = 9;
            this.vypisPopisPredmet.Zakončení = "";
            this.vypisPopisPredmet.Zkr = "";
            // 
            // FormPridavani
            // 
            this.AcceptButton = this.bt_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CancelButton = this.bt_ok;
            this.ClientSize = new System.Drawing.Size(884, 378);
            this.Controls.Add(this.vypisPopisPredmet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_kredity);
            this.Controls.Add(this.lb_chci);
            this.Controls.Add(this.lb_vypis);
            this.Controls.Add(this.bt_rem);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.bt_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPridavani";
            this.Text = "FormPridavani";
            ((System.ComponentModel.ISupportInitialize)(this.nud_kredity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_rem;
        private System.Windows.Forms.ListBox lb_vypis;
        private System.Windows.Forms.ListBox lb_chci;
        private System.Windows.Forms.NumericUpDown nud_kredity;
        private System.Windows.Forms.Label label1;
        private Komponenty.VypisPopisPredmetcs vypisPopisPredmet;
    }
}