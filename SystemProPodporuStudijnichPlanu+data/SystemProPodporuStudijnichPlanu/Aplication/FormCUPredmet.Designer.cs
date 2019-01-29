namespace SystemProPodporuStudijnichPlanu.Aplication
{
    partial class FormCUPredmet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCUPredmet));
            this.nud_cvk = new System.Windows.Forms.NumericUpDown();
            this.nud_lab = new System.Windows.Forms.NumericUpDown();
            this.nud_cv = new System.Windows.Forms.NumericUpDown();
            this.nud_p = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_close = new System.Windows.Forms.Button();
            this.bt_ok = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.l_email = new System.Windows.Forms.Label();
            this.l_zkr = new System.Windows.Forms.Label();
            this.l_id = new System.Windows.Forms.Label();
            this.tb_zkr = new System.Windows.Forms.TextBox();
            this.gb_predmet = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_jazyk = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rtb_popis = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_zakončení = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_povinnost = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_orig = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_kredity = new System.Windows.Forms.Label();
            this.nud_semestr = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_obor = new System.Windows.Forms.ComboBox();
            this.cb_garant = new System.Windows.Forms.ComboBox();
            this.nud_kredit = new System.Windows.Forms.NumericUpDown();
            this.tb_nazev = new System.Windows.Forms.TextBox();
            this.databaseAppDataSet = new SystemProPodporuStudijnichPlanu.DatabaseAppDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cvk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_lab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_p)).BeginInit();
            this.gb_predmet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_semestr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_kredit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseAppDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // nud_cvk
            // 
            this.nud_cvk.Location = new System.Drawing.Point(331, 192);
            this.nud_cvk.Name = "nud_cvk";
            this.nud_cvk.Size = new System.Drawing.Size(69, 20);
            this.nud_cvk.TabIndex = 20;
            // 
            // nud_lab
            // 
            this.nud_lab.Location = new System.Drawing.Point(331, 166);
            this.nud_lab.Name = "nud_lab";
            this.nud_lab.Size = new System.Drawing.Size(69, 20);
            this.nud_lab.TabIndex = 19;
            // 
            // nud_cv
            // 
            this.nud_cv.Location = new System.Drawing.Point(331, 140);
            this.nud_cv.Name = "nud_cv";
            this.nud_cv.Size = new System.Drawing.Size(69, 20);
            this.nud_cv.TabIndex = 18;
            // 
            // nud_p
            // 
            this.nud_p.Location = new System.Drawing.Point(331, 114);
            this.nud_p.Name = "nud_p";
            this.nud_p.Size = new System.Drawing.Size(69, 20);
            this.nud_p.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Cvičení kombi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Laboratoře:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cvičení:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Přednášky:";
            // 
            // bt_close
            // 
            this.bt_close.BackColor = System.Drawing.Color.Red;
            this.bt_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_close.Location = new System.Drawing.Point(546, 230);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(70, 23);
            this.bt_close.TabIndex = 3;
            this.bt_close.Text = "Zavřít";
            this.bt_close.UseVisualStyleBackColor = false;
            this.bt_close.Click += new System.EventHandler(this.Bt_close_Click);
            // 
            // bt_ok
            // 
            this.bt_ok.BackColor = System.Drawing.Color.Lime;
            this.bt_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_ok.Location = new System.Drawing.Point(478, 230);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(70, 23);
            this.bt_ok.TabIndex = 2;
            this.bt_ok.Text = "Ok";
            this.bt_ok.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Garant:";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(74, 19);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(69, 20);
            this.tb_id.TabIndex = 6;
            // 
            // l_email
            // 
            this.l_email.AutoSize = true;
            this.l_email.Location = new System.Drawing.Point(28, 74);
            this.l_email.Name = "l_email";
            this.l_email.Size = new System.Drawing.Size(41, 13);
            this.l_email.TabIndex = 9;
            this.l_email.Text = "Název:";
            // 
            // l_zkr
            // 
            this.l_zkr.AutoSize = true;
            this.l_zkr.Location = new System.Drawing.Point(22, 48);
            this.l_zkr.Name = "l_zkr";
            this.l_zkr.Size = new System.Drawing.Size(47, 13);
            this.l_zkr.TabIndex = 8;
            this.l_zkr.Text = "Zkratka:";
            // 
            // l_id
            // 
            this.l_id.AutoSize = true;
            this.l_id.Location = new System.Drawing.Point(48, 22);
            this.l_id.Name = "l_id";
            this.l_id.Size = new System.Drawing.Size(21, 13);
            this.l_id.TabIndex = 7;
            this.l_id.Text = "ID:";
            // 
            // tb_zkr
            // 
            this.tb_zkr.Location = new System.Drawing.Point(74, 45);
            this.tb_zkr.Name = "tb_zkr";
            this.tb_zkr.Size = new System.Drawing.Size(139, 20);
            this.tb_zkr.TabIndex = 4;
            // 
            // gb_predmet
            // 
            this.gb_predmet.Controls.Add(this.label12);
            this.gb_predmet.Controls.Add(this.tb_jazyk);
            this.gb_predmet.Controls.Add(this.label11);
            this.gb_predmet.Controls.Add(this.rtb_popis);
            this.gb_predmet.Controls.Add(this.label10);
            this.gb_predmet.Controls.Add(this.cb_zakončení);
            this.gb_predmet.Controls.Add(this.label9);
            this.gb_predmet.Controls.Add(this.cb_povinnost);
            this.gb_predmet.Controls.Add(this.label8);
            this.gb_predmet.Controls.Add(this.tb_orig);
            this.gb_predmet.Controls.Add(this.label7);
            this.gb_predmet.Controls.Add(this.lb_kredity);
            this.gb_predmet.Controls.Add(this.nud_semestr);
            this.gb_predmet.Controls.Add(this.label6);
            this.gb_predmet.Controls.Add(this.cb_obor);
            this.gb_predmet.Controls.Add(this.cb_garant);
            this.gb_predmet.Controls.Add(this.nud_kredit);
            this.gb_predmet.Controls.Add(this.nud_cvk);
            this.gb_predmet.Controls.Add(this.nud_lab);
            this.gb_predmet.Controls.Add(this.nud_cv);
            this.gb_predmet.Controls.Add(this.nud_p);
            this.gb_predmet.Controls.Add(this.label5);
            this.gb_predmet.Controls.Add(this.label4);
            this.gb_predmet.Controls.Add(this.label3);
            this.gb_predmet.Controls.Add(this.label1);
            this.gb_predmet.Controls.Add(this.bt_close);
            this.gb_predmet.Controls.Add(this.bt_ok);
            this.gb_predmet.Controls.Add(this.label2);
            this.gb_predmet.Controls.Add(this.tb_id);
            this.gb_predmet.Controls.Add(this.l_email);
            this.gb_predmet.Controls.Add(this.l_zkr);
            this.gb_predmet.Controls.Add(this.l_id);
            this.gb_predmet.Controls.Add(this.tb_zkr);
            this.gb_predmet.Controls.Add(this.tb_nazev);
            this.gb_predmet.Location = new System.Drawing.Point(3, 0);
            this.gb_predmet.Name = "gb_predmet";
            this.gb_predmet.Size = new System.Drawing.Size(696, 258);
            this.gb_predmet.TabIndex = 13;
            this.gb_predmet.TabStop = false;
            this.gb_predmet.Text = "Předmět";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 233);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "Jazyk:";
            // 
            // tb_jazyk
            // 
            this.tb_jazyk.Location = new System.Drawing.Point(75, 230);
            this.tb_jazyk.Name = "tb_jazyk";
            this.tb_jazyk.Size = new System.Drawing.Size(139, 20);
            this.tb_jazyk.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(407, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Popis:";
            // 
            // rtb_popis
            // 
            this.rtb_popis.Location = new System.Drawing.Point(410, 47);
            this.rtb_popis.Name = "rtb_popis";
            this.rtb_popis.Size = new System.Drawing.Size(278, 177);
            this.rtb_popis.TabIndex = 34;
            this.rtb_popis.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Zakončení:";
            // 
            // cb_zakončení
            // 
            this.cb_zakončení.FormattingEnabled = true;
            this.cb_zakončení.Items.AddRange(new object[] {
            "Zkouška",
            "Zápočet"});
            this.cb_zakončení.Location = new System.Drawing.Point(75, 204);
            this.cb_zakončení.Name = "cb_zakončení";
            this.cb_zakončení.Size = new System.Drawing.Size(139, 21);
            this.cb_zakončení.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Povinnost:";
            // 
            // cb_povinnost
            // 
            this.cb_povinnost.FormattingEnabled = true;
            this.cb_povinnost.Items.AddRange(new object[] {
            "Povinný předmět",
            "Volitelný předmět",
            "Povinně volitelný",
            "Cizí jazyk"});
            this.cb_povinnost.Location = new System.Drawing.Point(75, 177);
            this.cb_povinnost.Name = "cb_povinnost";
            this.cb_povinnost.Size = new System.Drawing.Size(139, 21);
            this.cb_povinnost.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Orig. ID:";
            // 
            // tb_orig
            // 
            this.tb_orig.Location = new System.Drawing.Point(75, 151);
            this.tb_orig.Name = "tb_orig";
            this.tb_orig.Size = new System.Drawing.Size(139, 20);
            this.tb_orig.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(277, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Semestr:";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // lb_kredity
            // 
            this.lb_kredity.AutoSize = true;
            this.lb_kredity.Location = new System.Drawing.Point(283, 64);
            this.lb_kredity.Name = "lb_kredity";
            this.lb_kredity.Size = new System.Drawing.Size(42, 13);
            this.lb_kredity.TabIndex = 26;
            this.lb_kredity.Text = "Kredity:";
            this.lb_kredity.Click += new System.EventHandler(this.Lb_kredity_Click);
            // 
            // nud_semestr
            // 
            this.nud_semestr.Location = new System.Drawing.Point(331, 88);
            this.nud_semestr.Name = "nud_semestr";
            this.nud_semestr.Size = new System.Drawing.Size(69, 20);
            this.nud_semestr.TabIndex = 25;
            this.nud_semestr.ValueChanged += new System.EventHandler(this.NumericUpDown2_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Obor:";
            // 
            // cb_obor
            // 
            this.cb_obor.FormattingEnabled = true;
            this.cb_obor.Location = new System.Drawing.Point(75, 124);
            this.cb_obor.Name = "cb_obor";
            this.cb_obor.Size = new System.Drawing.Size(139, 21);
            this.cb_obor.TabIndex = 23;
            // 
            // cb_garant
            // 
            this.cb_garant.FormattingEnabled = true;
            this.cb_garant.Location = new System.Drawing.Point(75, 97);
            this.cb_garant.Name = "cb_garant";
            this.cb_garant.Size = new System.Drawing.Size(139, 21);
            this.cb_garant.TabIndex = 22;
            // 
            // nud_kredit
            // 
            this.nud_kredit.Location = new System.Drawing.Point(331, 62);
            this.nud_kredit.Name = "nud_kredit";
            this.nud_kredit.Size = new System.Drawing.Size(69, 20);
            this.nud_kredit.TabIndex = 21;
            this.nud_kredit.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // tb_nazev
            // 
            this.tb_nazev.Location = new System.Drawing.Point(74, 71);
            this.tb_nazev.Name = "tb_nazev";
            this.tb_nazev.Size = new System.Drawing.Size(139, 20);
            this.tb_nazev.TabIndex = 5;
            // 
            // databaseAppDataSet
            // 
            this.databaseAppDataSet.DataSetName = "DatabaseAppDataSet";
            this.databaseAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormCUPredmet
            // 
            this.AcceptButton = this.bt_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CancelButton = this.bt_close;
            this.ClientSize = new System.Drawing.Size(703, 264);
            this.Controls.Add(this.gb_predmet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCUPredmet";
            this.Text = "FormCUPredmet";
            ((System.ComponentModel.ISupportInitialize)(this.nud_cvk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_lab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_p)).EndInit();
            this.gb_predmet.ResumeLayout(false);
            this.gb_predmet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_semestr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_kredit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseAppDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nud_cvk;
        private System.Windows.Forms.NumericUpDown nud_lab;
        private System.Windows.Forms.NumericUpDown nud_cv;
        private System.Windows.Forms.NumericUpDown nud_p;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label l_email;
        private System.Windows.Forms.Label l_zkr;
        private System.Windows.Forms.Label l_id;
        private System.Windows.Forms.TextBox tb_zkr;
        private System.Windows.Forms.GroupBox gb_predmet;
        private System.Windows.Forms.TextBox tb_orig;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_kredity;
        private System.Windows.Forms.NumericUpDown nud_semestr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_obor;
        private System.Windows.Forms.ComboBox cb_garant;
        private System.Windows.Forms.NumericUpDown nud_kredit;
        private System.Windows.Forms.TextBox tb_nazev;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox rtb_popis;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_zakončení;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_povinnost;
        private DatabaseAppDataSet databaseAppDataSet;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_jazyk;
    }
}