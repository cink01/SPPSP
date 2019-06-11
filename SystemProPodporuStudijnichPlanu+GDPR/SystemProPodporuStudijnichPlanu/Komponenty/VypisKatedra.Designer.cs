namespace SystemProPodporuStudijnichPlanu.Komponenty
{
    partial class VypisKatedra
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
            this.label3 = new System.Windows.Forms.Label();
            this.tb_zkratka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nazev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_pocG = new System.Windows.Forms.TextBox();
            this.gb_kat = new System.Windows.Forms.GroupBox();
            this.gb_kat.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Zkratka:";
            // 
            // tb_zkratka
            // 
            this.tb_zkratka.BackColor = System.Drawing.Color.White;
            this.tb_zkratka.Location = new System.Drawing.Point(9, 74);
            this.tb_zkratka.Name = "tb_zkratka";
            this.tb_zkratka.ReadOnly = true;
            this.tb_zkratka.Size = new System.Drawing.Size(85, 20);
            this.tb_zkratka.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Počet garantů:";
            // 
            // tb_nazev
            // 
            this.tb_nazev.BackColor = System.Drawing.Color.White;
            this.tb_nazev.Location = new System.Drawing.Point(9, 32);
            this.tb_nazev.Name = "tb_nazev";
            this.tb_nazev.ReadOnly = true;
            this.tb_nazev.Size = new System.Drawing.Size(206, 20);
            this.tb_nazev.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Název:";
            // 
            // tb_pocG
            // 
            this.tb_pocG.BackColor = System.Drawing.Color.White;
            this.tb_pocG.Location = new System.Drawing.Point(130, 74);
            this.tb_pocG.Name = "tb_pocG";
            this.tb_pocG.ReadOnly = true;
            this.tb_pocG.Size = new System.Drawing.Size(85, 20);
            this.tb_pocG.TabIndex = 4;
            // 
            // gb_kat
            // 
            this.gb_kat.Controls.Add(this.label3);
            this.gb_kat.Controls.Add(this.label2);
            this.gb_kat.Controls.Add(this.tb_nazev);
            this.gb_kat.Controls.Add(this.tb_zkratka);
            this.gb_kat.Controls.Add(this.label1);
            this.gb_kat.Controls.Add(this.tb_pocG);
            this.gb_kat.Location = new System.Drawing.Point(2, -2);
            this.gb_kat.Name = "gb_kat";
            this.gb_kat.Size = new System.Drawing.Size(222, 101);
            this.gb_kat.TabIndex = 9;
            this.gb_kat.TabStop = false;
            this.gb_kat.Text = "Informace katedry";
            // 
            // VypisKatedra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_kat);
            this.Name = "VypisKatedra";
            this.Size = new System.Drawing.Size(226, 102);
            this.gb_kat.ResumeLayout(false);
            this.gb_kat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_zkratka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nazev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_pocG;
        private System.Windows.Forms.GroupBox gb_kat;
    }
}
