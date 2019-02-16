namespace SystemProPodporuStudijnichPlanu.Komponenty
{
    partial class VypisPopisPredmet
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
            this.gb_popis_pr = new System.Windows.Forms.GroupBox();
            this.rtb_popis = new System.Windows.Forms.RichTextBox();
            this.gb_základ = new System.Windows.Forms.GroupBox();
            this.tb_kredity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.l_prerek = new System.Windows.Forms.Label();
            this.tb_jazyk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_prerek = new System.Windows.Forms.TextBox();
            this.tb_zakonc = new System.Windows.Forms.TextBox();
            this.tb_povinn = new System.Windows.Forms.TextBox();
            this.tb_semestr = new System.Windows.Forms.TextBox();
            this.tb_zkratka = new System.Windows.Forms.TextBox();
            this.l_povinnost = new System.Windows.Forms.Label();
            this.l_kredity = new System.Windows.Forms.Label();
            this.l_zkratka = new System.Windows.Forms.Label();
            this.gb_vyuc = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_laborator = new System.Windows.Forms.TextBox();
            this.tb_kombi = new System.Windows.Forms.TextBox();
            this.tb_cviceni = new System.Windows.Forms.TextBox();
            this.tb_prednaska = new System.Windows.Forms.TextBox();
            this.l_popis = new System.Windows.Forms.Label();
            this.tb_garant = new System.Windows.Forms.TextBox();
            this.l_garant = new System.Windows.Forms.Label();
            this.gb_popis_pr.SuspendLayout();
            this.gb_základ.SuspendLayout();
            this.gb_vyuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_popis_pr
            // 
            this.gb_popis_pr.Controls.Add(this.rtb_popis);
            this.gb_popis_pr.Controls.Add(this.gb_základ);
            this.gb_popis_pr.Controls.Add(this.gb_vyuc);
            this.gb_popis_pr.Controls.Add(this.l_popis);
            this.gb_popis_pr.Controls.Add(this.tb_garant);
            this.gb_popis_pr.Controls.Add(this.l_garant);
            this.gb_popis_pr.Location = new System.Drawing.Point(3, 3);
            this.gb_popis_pr.Name = "gb_popis_pr";
            this.gb_popis_pr.Size = new System.Drawing.Size(383, 337);
            this.gb_popis_pr.TabIndex = 0;
            this.gb_popis_pr.TabStop = false;
            this.gb_popis_pr.Text = "Detaily vybraného předmětu";
            this.gb_popis_pr.Enter += new System.EventHandler(this.Gb_popis_pr_Enter);
            // 
            // rtb_popis
            // 
            this.rtb_popis.Location = new System.Drawing.Point(185, 83);
            this.rtb_popis.Name = "rtb_popis";
            this.rtb_popis.Size = new System.Drawing.Size(194, 249);
            this.rtb_popis.TabIndex = 22;
            this.rtb_popis.Text = "";
            // 
            // gb_základ
            // 
            this.gb_základ.Controls.Add(this.tb_kredity);
            this.gb_základ.Controls.Add(this.label7);
            this.gb_základ.Controls.Add(this.label6);
            this.gb_základ.Controls.Add(this.l_prerek);
            this.gb_základ.Controls.Add(this.tb_jazyk);
            this.gb_základ.Controls.Add(this.label1);
            this.gb_základ.Controls.Add(this.tb_prerek);
            this.gb_základ.Controls.Add(this.tb_zakonc);
            this.gb_základ.Controls.Add(this.tb_povinn);
            this.gb_základ.Controls.Add(this.tb_semestr);
            this.gb_základ.Controls.Add(this.tb_zkratka);
            this.gb_základ.Controls.Add(this.l_povinnost);
            this.gb_základ.Controls.Add(this.l_kredity);
            this.gb_základ.Controls.Add(this.l_zkratka);
            this.gb_základ.Location = new System.Drawing.Point(6, 19);
            this.gb_základ.Name = "gb_základ";
            this.gb_základ.Size = new System.Drawing.Size(177, 190);
            this.gb_základ.TabIndex = 21;
            this.gb_základ.TabStop = false;
            this.gb_základ.Text = "Základní informace";
            // 
            // tb_kredity
            // 
            this.tb_kredity.Location = new System.Drawing.Point(73, 64);
            this.tb_kredity.Name = "tb_kredity";
            this.tb_kredity.Size = new System.Drawing.Size(100, 20);
            this.tb_kredity.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Kredity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Jazyk:";
            // 
            // l_prerek
            // 
            this.l_prerek.AutoSize = true;
            this.l_prerek.Location = new System.Drawing.Point(2, 145);
            this.l_prerek.Name = "l_prerek";
            this.l_prerek.Size = new System.Drawing.Size(65, 13);
            this.l_prerek.TabIndex = 5;
            this.l_prerek.Text = "Prerekvizita:";
            // 
            // tb_jazyk
            // 
            this.tb_jazyk.Location = new System.Drawing.Point(73, 168);
            this.tb_jazyk.Name = "tb_jazyk";
            this.tb_jazyk.Size = new System.Drawing.Size(100, 20);
            this.tb_jazyk.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Zakončení:";
            // 
            // tb_prerek
            // 
            this.tb_prerek.Location = new System.Drawing.Point(73, 142);
            this.tb_prerek.Name = "tb_prerek";
            this.tb_prerek.Size = new System.Drawing.Size(100, 20);
            this.tb_prerek.TabIndex = 12;
            // 
            // tb_zakonc
            // 
            this.tb_zakonc.Location = new System.Drawing.Point(73, 116);
            this.tb_zakonc.Name = "tb_zakonc";
            this.tb_zakonc.Size = new System.Drawing.Size(100, 20);
            this.tb_zakonc.TabIndex = 11;
            // 
            // tb_povinn
            // 
            this.tb_povinn.Location = new System.Drawing.Point(73, 90);
            this.tb_povinn.Name = "tb_povinn";
            this.tb_povinn.Size = new System.Drawing.Size(100, 20);
            this.tb_povinn.TabIndex = 10;
            // 
            // tb_semestr
            // 
            this.tb_semestr.Location = new System.Drawing.Point(73, 38);
            this.tb_semestr.Name = "tb_semestr";
            this.tb_semestr.Size = new System.Drawing.Size(100, 20);
            this.tb_semestr.TabIndex = 8;
            // 
            // tb_zkratka
            // 
            this.tb_zkratka.Location = new System.Drawing.Point(73, 12);
            this.tb_zkratka.Name = "tb_zkratka";
            this.tb_zkratka.Size = new System.Drawing.Size(100, 20);
            this.tb_zkratka.TabIndex = 7;
            // 
            // l_povinnost
            // 
            this.l_povinnost.AutoSize = true;
            this.l_povinnost.Location = new System.Drawing.Point(10, 93);
            this.l_povinnost.Name = "l_povinnost";
            this.l_povinnost.Size = new System.Drawing.Size(57, 13);
            this.l_povinnost.TabIndex = 3;
            this.l_povinnost.Text = "Povinnost:";
            // 
            // l_kredity
            // 
            this.l_kredity.AutoSize = true;
            this.l_kredity.Location = new System.Drawing.Point(19, 41);
            this.l_kredity.Name = "l_kredity";
            this.l_kredity.Size = new System.Drawing.Size(48, 13);
            this.l_kredity.TabIndex = 1;
            this.l_kredity.Text = "Semestr:";
            // 
            // l_zkratka
            // 
            this.l_zkratka.AutoSize = true;
            this.l_zkratka.Location = new System.Drawing.Point(20, 16);
            this.l_zkratka.Name = "l_zkratka";
            this.l_zkratka.Size = new System.Drawing.Size(47, 13);
            this.l_zkratka.TabIndex = 0;
            this.l_zkratka.Text = "Zkratka:";
            // 
            // gb_vyuc
            // 
            this.gb_vyuc.Controls.Add(this.label3);
            this.gb_vyuc.Controls.Add(this.label4);
            this.gb_vyuc.Controls.Add(this.label5);
            this.gb_vyuc.Controls.Add(this.label2);
            this.gb_vyuc.Controls.Add(this.tb_laborator);
            this.gb_vyuc.Controls.Add(this.tb_kombi);
            this.gb_vyuc.Controls.Add(this.tb_cviceni);
            this.gb_vyuc.Controls.Add(this.tb_prednaska);
            this.gb_vyuc.Location = new System.Drawing.Point(6, 215);
            this.gb_vyuc.Name = "gb_vyuc";
            this.gb_vyuc.Size = new System.Drawing.Size(177, 116);
            this.gb_vyuc.TabIndex = 19;
            this.gb_vyuc.TabStop = false;
            this.gb_vyuc.Text = "Týdenní dotace hodin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Laboratoře:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Kombi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Cvičení:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Přednášky:";
            // 
            // tb_laborator
            // 
            this.tb_laborator.Location = new System.Drawing.Point(73, 91);
            this.tb_laborator.Name = "tb_laborator";
            this.tb_laborator.Size = new System.Drawing.Size(100, 20);
            this.tb_laborator.TabIndex = 18;
            // 
            // tb_kombi
            // 
            this.tb_kombi.Location = new System.Drawing.Point(73, 65);
            this.tb_kombi.Name = "tb_kombi";
            this.tb_kombi.Size = new System.Drawing.Size(100, 20);
            this.tb_kombi.TabIndex = 17;
            // 
            // tb_cviceni
            // 
            this.tb_cviceni.Location = new System.Drawing.Point(73, 39);
            this.tb_cviceni.Name = "tb_cviceni";
            this.tb_cviceni.Size = new System.Drawing.Size(100, 20);
            this.tb_cviceni.TabIndex = 16;
            // 
            // tb_prednaska
            // 
            this.tb_prednaska.Location = new System.Drawing.Point(73, 13);
            this.tb_prednaska.Name = "tb_prednaska";
            this.tb_prednaska.Size = new System.Drawing.Size(100, 20);
            this.tb_prednaska.TabIndex = 15;
            // 
            // l_popis
            // 
            this.l_popis.AutoSize = true;
            this.l_popis.Location = new System.Drawing.Point(185, 67);
            this.l_popis.Name = "l_popis";
            this.l_popis.Size = new System.Drawing.Size(36, 13);
            this.l_popis.TabIndex = 6;
            this.l_popis.Text = "Popis:";
            // 
            // tb_garant
            // 
            this.tb_garant.Location = new System.Drawing.Point(185, 44);
            this.tb_garant.Name = "tb_garant";
            this.tb_garant.Size = new System.Drawing.Size(194, 20);
            this.tb_garant.TabIndex = 9;
            // 
            // l_garant
            // 
            this.l_garant.AutoSize = true;
            this.l_garant.Location = new System.Drawing.Point(185, 28);
            this.l_garant.Name = "l_garant";
            this.l_garant.Size = new System.Drawing.Size(42, 13);
            this.l_garant.TabIndex = 2;
            this.l_garant.Text = "Garant:";
            // 
            // VypisPopisPredmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_popis_pr);
            this.Name = "VypisPopisPredmet";
            this.Size = new System.Drawing.Size(388, 341);
            this.gb_popis_pr.ResumeLayout(false);
            this.gb_popis_pr.PerformLayout();
            this.gb_základ.ResumeLayout(false);
            this.gb_základ.PerformLayout();
            this.gb_vyuc.ResumeLayout(false);
            this.gb_vyuc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_popis_pr;
        private System.Windows.Forms.Label l_kredity;
        private System.Windows.Forms.Label l_zkratka;
        private System.Windows.Forms.GroupBox gb_základ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label l_prerek;
        private System.Windows.Forms.TextBox tb_jazyk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_prerek;
        private System.Windows.Forms.TextBox tb_zakonc;
        private System.Windows.Forms.TextBox tb_povinn;
        private System.Windows.Forms.TextBox tb_garant;
        private System.Windows.Forms.TextBox tb_semestr;
        private System.Windows.Forms.TextBox tb_zkratka;
        private System.Windows.Forms.Label l_popis;
        private System.Windows.Forms.Label l_povinnost;
        private System.Windows.Forms.Label l_garant;
        private System.Windows.Forms.GroupBox gb_vyuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_laborator;
        private System.Windows.Forms.TextBox tb_kombi;
        private System.Windows.Forms.TextBox tb_cviceni;
        private System.Windows.Forms.TextBox tb_prednaska;
        private System.Windows.Forms.RichTextBox rtb_popis;
        private System.Windows.Forms.TextBox tb_kredity;
        private System.Windows.Forms.Label label7;
    }
}
