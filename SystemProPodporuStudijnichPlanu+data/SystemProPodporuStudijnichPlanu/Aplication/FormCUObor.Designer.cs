namespace SystemProPodporuStudijnichPlanu.Aplication
{
    partial class FormCUObor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCUObor));
            this.bt_close = new System.Windows.Forms.Button();
            this.bt_ok = new System.Windows.Forms.Button();
            this.gb_obor = new System.Windows.Forms.GroupBox();
            this.nud_vs = new System.Windows.Forms.NumericUpDown();
            this.nud_v = new System.Windows.Forms.NumericUpDown();
            this.nud_pv = new System.Windows.Forms.NumericUpDown();
            this.nud_p = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_rok = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.l_email = new System.Windows.Forms.Label();
            this.l_zkr = new System.Windows.Forms.Label();
            this.l_id = new System.Windows.Forms.Label();
            this.tb_zkr = new System.Windows.Forms.TextBox();
            this.tb_nazev = new System.Windows.Forms.TextBox();
            this.rtb_praxe = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gb_obor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_vs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_v)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_p)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_close
            // 
            this.bt_close.BackColor = System.Drawing.Color.Red;
            this.bt_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_close.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_close.Location = new System.Drawing.Point(230, 189);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(69, 23);
            this.bt_close.TabIndex = 3;
            this.bt_close.Text = "Zavřít";
            this.bt_close.UseVisualStyleBackColor = false;
            this.bt_close.Click += new System.EventHandler(this.Bt_close_Click);
            // 
            // bt_ok
            // 
            this.bt_ok.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_ok.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.bt_ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_ok.Location = new System.Drawing.Point(169, 189);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(63, 23);
            this.bt_ok.TabIndex = 2;
            this.bt_ok.Text = "Ok";
            this.bt_ok.UseVisualStyleBackColor = false;
            this.bt_ok.Click += new System.EventHandler(this.Bt_ok_Click);
            // 
            // gb_obor
            // 
            this.gb_obor.Controls.Add(this.label6);
            this.gb_obor.Controls.Add(this.rtb_praxe);
            this.gb_obor.Controls.Add(this.nud_vs);
            this.gb_obor.Controls.Add(this.nud_v);
            this.gb_obor.Controls.Add(this.nud_pv);
            this.gb_obor.Controls.Add(this.nud_p);
            this.gb_obor.Controls.Add(this.label5);
            this.gb_obor.Controls.Add(this.label4);
            this.gb_obor.Controls.Add(this.label3);
            this.gb_obor.Controls.Add(this.label1);
            this.gb_obor.Controls.Add(this.bt_close);
            this.gb_obor.Controls.Add(this.bt_ok);
            this.gb_obor.Controls.Add(this.label2);
            this.gb_obor.Controls.Add(this.tb_rok);
            this.gb_obor.Controls.Add(this.tb_id);
            this.gb_obor.Controls.Add(this.l_email);
            this.gb_obor.Controls.Add(this.l_zkr);
            this.gb_obor.Controls.Add(this.l_id);
            this.gb_obor.Controls.Add(this.tb_zkr);
            this.gb_obor.Controls.Add(this.tb_nazev);
            this.gb_obor.Location = new System.Drawing.Point(4, 2);
            this.gb_obor.Name = "gb_obor";
            this.gb_obor.Size = new System.Drawing.Size(469, 218);
            this.gb_obor.TabIndex = 12;
            this.gb_obor.TabStop = false;
            this.gb_obor.Text = "Obor";
            this.gb_obor.Enter += new System.EventHandler(this.Gb_obor_Enter);
            // 
            // nud_vs
            // 
            this.nud_vs.Location = new System.Drawing.Point(395, 97);
            this.nud_vs.Name = "nud_vs";
            this.nud_vs.Size = new System.Drawing.Size(59, 20);
            this.nud_vs.TabIndex = 20;
            this.nud_vs.ValueChanged += new System.EventHandler(this.Nud_vs_ValueChanged);
            // 
            // nud_v
            // 
            this.nud_v.Location = new System.Drawing.Point(395, 71);
            this.nud_v.Name = "nud_v";
            this.nud_v.Size = new System.Drawing.Size(59, 20);
            this.nud_v.TabIndex = 19;
            this.nud_v.ValueChanged += new System.EventHandler(this.Nud_v_ValueChanged);
            // 
            // nud_pv
            // 
            this.nud_pv.Location = new System.Drawing.Point(395, 45);
            this.nud_pv.Name = "nud_pv";
            this.nud_pv.Size = new System.Drawing.Size(59, 20);
            this.nud_pv.TabIndex = 18;
            this.nud_pv.ValueChanged += new System.EventHandler(this.Nud_pv_ValueChanged);
            // 
            // nud_p
            // 
            this.nud_p.Location = new System.Drawing.Point(395, 19);
            this.nud_p.Name = "nud_p";
            this.nud_p.Size = new System.Drawing.Size(59, 20);
            this.nud_p.TabIndex = 17;
            this.nud_p.ValueChanged += new System.EventHandler(this.Nud_p_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Volitelných sportů:";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Volitelných předmětů:";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Povinně-volitelných předmětů:";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Povinných předmětů:";
            this.label1.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Rok:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // tb_rok
            // 
            this.tb_rok.Location = new System.Drawing.Point(67, 97);
            this.tb_rok.Name = "tb_rok";
            this.tb_rok.Size = new System.Drawing.Size(138, 20);
            this.tb_rok.TabIndex = 10;
            this.tb_rok.TextChanged += new System.EventHandler(this.Tb_rok_TextChanged);
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(67, 19);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(63, 20);
            this.tb_id.TabIndex = 6;
            this.tb_id.TextChanged += new System.EventHandler(this.Tb_id_TextChanged);
            // 
            // l_email
            // 
            this.l_email.AutoSize = true;
            this.l_email.Location = new System.Drawing.Point(20, 74);
            this.l_email.Name = "l_email";
            this.l_email.Size = new System.Drawing.Size(41, 13);
            this.l_email.TabIndex = 9;
            this.l_email.Text = "Název:";
            this.l_email.Click += new System.EventHandler(this.L_email_Click);
            // 
            // l_zkr
            // 
            this.l_zkr.AutoSize = true;
            this.l_zkr.Location = new System.Drawing.Point(14, 48);
            this.l_zkr.Name = "l_zkr";
            this.l_zkr.Size = new System.Drawing.Size(47, 13);
            this.l_zkr.TabIndex = 8;
            this.l_zkr.Text = "Zkratka:";
            this.l_zkr.Click += new System.EventHandler(this.L_zkr_Click);
            // 
            // l_id
            // 
            this.l_id.AutoSize = true;
            this.l_id.Location = new System.Drawing.Point(40, 22);
            this.l_id.Name = "l_id";
            this.l_id.Size = new System.Drawing.Size(21, 13);
            this.l_id.TabIndex = 7;
            this.l_id.Text = "ID:";
            this.l_id.Click += new System.EventHandler(this.L_id_Click);
            // 
            // tb_zkr
            // 
            this.tb_zkr.Location = new System.Drawing.Point(67, 45);
            this.tb_zkr.Name = "tb_zkr";
            this.tb_zkr.Size = new System.Drawing.Size(138, 20);
            this.tb_zkr.TabIndex = 4;
            this.tb_zkr.TextChanged += new System.EventHandler(this.Tb_zkr_TextChanged);
            // 
            // tb_nazev
            // 
            this.tb_nazev.Location = new System.Drawing.Point(67, 71);
            this.tb_nazev.Name = "tb_nazev";
            this.tb_nazev.Size = new System.Drawing.Size(138, 20);
            this.tb_nazev.TabIndex = 5;
            this.tb_nazev.TextChanged += new System.EventHandler(this.Tb_nazev_TextChanged);
            // 
            // rtb_praxe
            // 
            this.rtb_praxe.Location = new System.Drawing.Point(67, 142);
            this.rtb_praxe.Name = "rtb_praxe";
            this.rtb_praxe.Size = new System.Drawing.Size(386, 41);
            this.rtb_praxe.TabIndex = 21;
            this.rtb_praxe.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Informace o praxi";
            // 
            // FormCUObor
            // 
            this.AcceptButton = this.bt_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CancelButton = this.bt_close;
            this.ClientSize = new System.Drawing.Size(476, 232);
            this.Controls.Add(this.gb_obor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCUObor";
            this.Text = "FormCUObor";
            this.gb_obor.ResumeLayout(false);
            this.gb_obor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_vs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_v)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_p)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.GroupBox gb_obor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_rok;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label l_email;
        private System.Windows.Forms.Label l_zkr;
        private System.Windows.Forms.Label l_id;
        private System.Windows.Forms.TextBox tb_zkr;
        private System.Windows.Forms.TextBox tb_nazev;
        private System.Windows.Forms.NumericUpDown nud_vs;
        private System.Windows.Forms.NumericUpDown nud_v;
        private System.Windows.Forms.NumericUpDown nud_pv;
        private System.Windows.Forms.NumericUpDown nud_p;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtb_praxe;
    }
}