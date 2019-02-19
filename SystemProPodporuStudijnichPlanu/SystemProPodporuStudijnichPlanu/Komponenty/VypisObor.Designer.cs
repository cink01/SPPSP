namespace SystemProPodporuStudijnichPlanu.Komponenty
{
    partial class VypisObor
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
            this.gb_obor = new System.Windows.Forms.GroupBox();
            this.rtb_praxe = new System.Windows.Forms.RichTextBox();
            this.gb_základ = new System.Windows.Forms.GroupBox();
            this.tb_zkratka = new System.Windows.Forms.TextBox();
            this.l_zkratka = new System.Windows.Forms.Label();
            this.l_kredity = new System.Windows.Forms.Label();
            this.tb_rok = new System.Windows.Forms.TextBox();
            this.gb_vyuc = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_s = new System.Windows.Forms.TextBox();
            this.tb_v = new System.Windows.Forms.TextBox();
            this.tb_pv = new System.Windows.Forms.TextBox();
            this.tb_p = new System.Windows.Forms.TextBox();
            this.l_popis = new System.Windows.Forms.Label();
            this.gb_obor.SuspendLayout();
            this.gb_základ.SuspendLayout();
            this.gb_vyuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_obor
            // 
            this.gb_obor.Controls.Add(this.rtb_praxe);
            this.gb_obor.Controls.Add(this.gb_základ);
            this.gb_obor.Controls.Add(this.gb_vyuc);
            this.gb_obor.Controls.Add(this.l_popis);
            this.gb_obor.Location = new System.Drawing.Point(1, -2);
            this.gb_obor.Name = "gb_obor";
            this.gb_obor.Size = new System.Drawing.Size(383, 224);
            this.gb_obor.TabIndex = 1;
            this.gb_obor.TabStop = false;
            this.gb_obor.Text = "Informace oboru";
            // 
            // rtb_praxe
            // 
            this.rtb_praxe.BackColor = System.Drawing.Color.White;
            this.rtb_praxe.Location = new System.Drawing.Point(6, 141);
            this.rtb_praxe.Name = "rtb_praxe";
            this.rtb_praxe.ReadOnly = true;
            this.rtb_praxe.Size = new System.Drawing.Size(371, 76);
            this.rtb_praxe.TabIndex = 22;
            this.rtb_praxe.Text = "";
            // 
            // gb_základ
            // 
            this.gb_základ.Controls.Add(this.tb_zkratka);
            this.gb_základ.Controls.Add(this.l_zkratka);
            this.gb_základ.Controls.Add(this.l_kredity);
            this.gb_základ.Controls.Add(this.tb_rok);
            this.gb_základ.Location = new System.Drawing.Point(6, 19);
            this.gb_základ.Name = "gb_základ";
            this.gb_základ.Size = new System.Drawing.Size(199, 77);
            this.gb_základ.TabIndex = 21;
            this.gb_základ.TabStop = false;
            this.gb_základ.Text = "Základní informace";
            // 
            // tb_zkratka
            // 
            this.tb_zkratka.BackColor = System.Drawing.Color.White;
            this.tb_zkratka.Location = new System.Drawing.Point(93, 19);
            this.tb_zkratka.Name = "tb_zkratka";
            this.tb_zkratka.ReadOnly = true;
            this.tb_zkratka.Size = new System.Drawing.Size(100, 20);
            this.tb_zkratka.TabIndex = 7;
            // 
            // l_zkratka
            // 
            this.l_zkratka.AutoSize = true;
            this.l_zkratka.Location = new System.Drawing.Point(40, 22);
            this.l_zkratka.Name = "l_zkratka";
            this.l_zkratka.Size = new System.Drawing.Size(47, 13);
            this.l_zkratka.TabIndex = 0;
            this.l_zkratka.Text = "Zkratka:";
            // 
            // l_kredity
            // 
            this.l_kredity.AutoSize = true;
            this.l_kredity.Location = new System.Drawing.Point(6, 48);
            this.l_kredity.Name = "l_kredity";
            this.l_kredity.Size = new System.Drawing.Size(81, 13);
            this.l_kredity.TabIndex = 1;
            this.l_kredity.Text = "Rok(označení):";
            // 
            // tb_rok
            // 
            this.tb_rok.BackColor = System.Drawing.Color.White;
            this.tb_rok.Location = new System.Drawing.Point(93, 45);
            this.tb_rok.Name = "tb_rok";
            this.tb_rok.ReadOnly = true;
            this.tb_rok.Size = new System.Drawing.Size(100, 20);
            this.tb_rok.TabIndex = 8;
            // 
            // gb_vyuc
            // 
            this.gb_vyuc.Controls.Add(this.label3);
            this.gb_vyuc.Controls.Add(this.label4);
            this.gb_vyuc.Controls.Add(this.label5);
            this.gb_vyuc.Controls.Add(this.label2);
            this.gb_vyuc.Controls.Add(this.tb_s);
            this.gb_vyuc.Controls.Add(this.tb_v);
            this.gb_vyuc.Controls.Add(this.tb_pv);
            this.gb_vyuc.Controls.Add(this.tb_p);
            this.gb_vyuc.Location = new System.Drawing.Point(211, 19);
            this.gb_vyuc.Name = "gb_vyuc";
            this.gb_vyuc.Size = new System.Drawing.Size(166, 116);
            this.gb_vyuc.TabIndex = 19;
            this.gb_vyuc.TabStop = false;
            this.gb_vyuc.Text = "Přehled potřebných kreditů";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Sporty:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Volitelné:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Povině-Volitelné:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Povinné:";
            // 
            // tb_s
            // 
            this.tb_s.BackColor = System.Drawing.Color.White;
            this.tb_s.Location = new System.Drawing.Point(103, 91);
            this.tb_s.Name = "tb_s";
            this.tb_s.ReadOnly = true;
            this.tb_s.Size = new System.Drawing.Size(57, 20);
            this.tb_s.TabIndex = 18;
            // 
            // tb_v
            // 
            this.tb_v.BackColor = System.Drawing.Color.White;
            this.tb_v.Location = new System.Drawing.Point(103, 65);
            this.tb_v.Name = "tb_v";
            this.tb_v.ReadOnly = true;
            this.tb_v.Size = new System.Drawing.Size(57, 20);
            this.tb_v.TabIndex = 17;
            // 
            // tb_pv
            // 
            this.tb_pv.BackColor = System.Drawing.Color.White;
            this.tb_pv.Location = new System.Drawing.Point(103, 39);
            this.tb_pv.Name = "tb_pv";
            this.tb_pv.ReadOnly = true;
            this.tb_pv.Size = new System.Drawing.Size(57, 20);
            this.tb_pv.TabIndex = 16;
            // 
            // tb_p
            // 
            this.tb_p.BackColor = System.Drawing.Color.White;
            this.tb_p.Location = new System.Drawing.Point(103, 13);
            this.tb_p.Name = "tb_p";
            this.tb_p.ReadOnly = true;
            this.tb_p.Size = new System.Drawing.Size(57, 20);
            this.tb_p.TabIndex = 15;
            // 
            // l_popis
            // 
            this.l_popis.AutoSize = true;
            this.l_popis.Location = new System.Drawing.Point(12, 125);
            this.l_popis.Name = "l_popis";
            this.l_popis.Size = new System.Drawing.Size(37, 13);
            this.l_popis.TabIndex = 6;
            this.l_popis.Text = "Praxe:";
            // 
            // VypisObor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_obor);
            this.Name = "VypisObor";
            this.Size = new System.Drawing.Size(386, 221);
            this.gb_obor.ResumeLayout(false);
            this.gb_obor.PerformLayout();
            this.gb_základ.ResumeLayout(false);
            this.gb_základ.PerformLayout();
            this.gb_vyuc.ResumeLayout(false);
            this.gb_vyuc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_obor;
        private System.Windows.Forms.RichTextBox rtb_praxe;
        private System.Windows.Forms.GroupBox gb_základ;
        private System.Windows.Forms.TextBox tb_zkratka;
        private System.Windows.Forms.Label l_zkratka;
        private System.Windows.Forms.Label l_kredity;
        private System.Windows.Forms.TextBox tb_rok;
        private System.Windows.Forms.GroupBox gb_vyuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_s;
        private System.Windows.Forms.TextBox tb_v;
        private System.Windows.Forms.TextBox tb_pv;
        private System.Windows.Forms.TextBox tb_p;
        private System.Windows.Forms.Label l_popis;
    }
}
