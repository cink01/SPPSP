namespace SystemProPodporuStudijnichPlanu.Komponenty
{
    partial class VypisGarant
    {
        /// <summary> 
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód vygenerovaný pomocí Návrháře komponent

        /// <summary> 
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_konz = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_tel = new System.Windows.Forms.TextBox();
            this.tb_kat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gb_gar = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_garantuje = new System.Windows.Forms.ComboBox();
            this.gb_gar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_konz
            // 
            this.tb_konz.BackColor = System.Drawing.Color.White;
            this.tb_konz.Location = new System.Drawing.Point(73, 13);
            this.tb_konz.Name = "tb_konz";
            this.tb_konz.ReadOnly = true;
            this.tb_konz.Size = new System.Drawing.Size(206, 20);
            this.tb_konz.TabIndex = 0;
            // 
            // tb_email
            // 
            this.tb_email.BackColor = System.Drawing.Color.White;
            this.tb_email.Location = new System.Drawing.Point(73, 39);
            this.tb_email.Name = "tb_email";
            this.tb_email.ReadOnly = true;
            this.tb_email.Size = new System.Drawing.Size(206, 20);
            this.tb_email.TabIndex = 1;
            // 
            // tb_tel
            // 
            this.tb_tel.BackColor = System.Drawing.Color.White;
            this.tb_tel.Location = new System.Drawing.Point(73, 65);
            this.tb_tel.Name = "tb_tel";
            this.tb_tel.ReadOnly = true;
            this.tb_tel.Size = new System.Drawing.Size(206, 20);
            this.tb_tel.TabIndex = 2;
            // 
            // tb_kat
            // 
            this.tb_kat.BackColor = System.Drawing.Color.White;
            this.tb_kat.Location = new System.Drawing.Point(73, 91);
            this.tb_kat.Name = "tb_kat";
            this.tb_kat.ReadOnly = true;
            this.tb_kat.Size = new System.Drawing.Size(206, 20);
            this.tb_kat.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Katedra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Konzultace:";
            // 
            // gb_gar
            // 
            this.gb_gar.Controls.Add(this.cmb_garantuje);
            this.gb_gar.Controls.Add(this.label5);
            this.gb_gar.Controls.Add(this.label4);
            this.gb_gar.Controls.Add(this.label3);
            this.gb_gar.Controls.Add(this.tb_konz);
            this.gb_gar.Controls.Add(this.tb_email);
            this.gb_gar.Controls.Add(this.label2);
            this.gb_gar.Controls.Add(this.tb_tel);
            this.gb_gar.Controls.Add(this.label1);
            this.gb_gar.Controls.Add(this.tb_kat);
            this.gb_gar.Location = new System.Drawing.Point(1, -3);
            this.gb_gar.Name = "gb_gar";
            this.gb_gar.Size = new System.Drawing.Size(285, 143);
            this.gb_gar.TabIndex = 8;
            this.gb_gar.TabStop = false;
            this.gb_gar.Text = "Informace garanta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Garantuje:";
            // 
            // comboBox1
            // 
            this.cmb_garantuje.FormattingEnabled = true;
            this.cmb_garantuje.Location = new System.Drawing.Point(73, 117);
            this.cmb_garantuje.Name = "comboBox1";
            this.cmb_garantuje.Size = new System.Drawing.Size(206, 21);
            this.cmb_garantuje.TabIndex = 4;
            // 
            // VypisGarant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_gar);
            this.Name = "VypisGarant";
            this.Size = new System.Drawing.Size(287, 141);
            this.gb_gar.ResumeLayout(false);
            this.gb_gar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_konz;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_tel;
        private System.Windows.Forms.TextBox tb_kat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gb_gar;
        private System.Windows.Forms.ComboBox cmb_garantuje;
        private System.Windows.Forms.Label label5;
    }
}
