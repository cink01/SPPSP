namespace SystemProPodporuStudijnichPlanu.Aplication
{
    partial class FormCUGarant
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
            this.bt_close = new System.Windows.Forms.Button();
            this.bt_ok = new System.Windows.Forms.Button();
            this.gb_garant = new System.Windows.Forms.GroupBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.l_email = new System.Windows.Forms.Label();
            this.l_zkr = new System.Windows.Forms.Label();
            this.l_id = new System.Windows.Forms.Label();
            this.tb_jm = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cmb_katedra = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_garant.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_close
            // 
            this.bt_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_close.Location = new System.Drawing.Point(372, 58);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(75, 23);
            this.bt_close.TabIndex = 3;
            this.bt_close.Text = "Zavřít";
            this.bt_close.UseVisualStyleBackColor = true;
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(291, 58);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(75, 23);
            this.bt_ok.TabIndex = 2;
            this.bt_ok.Text = "Ok";
            this.bt_ok.UseVisualStyleBackColor = true;
            // 
            // gb_garant
            // 
            this.gb_garant.Controls.Add(this.label3);
            this.gb_garant.Controls.Add(this.bt_close);
            this.gb_garant.Controls.Add(this.cmb_katedra);
            this.gb_garant.Controls.Add(this.bt_ok);
            this.gb_garant.Controls.Add(this.label1);
            this.gb_garant.Controls.Add(this.label2);
            this.gb_garant.Controls.Add(this.textBox1);
            this.gb_garant.Controls.Add(this.textBox2);
            this.gb_garant.Controls.Add(this.tb_id);
            this.gb_garant.Controls.Add(this.l_email);
            this.gb_garant.Controls.Add(this.l_zkr);
            this.gb_garant.Controls.Add(this.l_id);
            this.gb_garant.Controls.Add(this.tb_jm);
            this.gb_garant.Controls.Add(this.tb_email);
            this.gb_garant.Location = new System.Drawing.Point(2, 2);
            this.gb_garant.Name = "gb_garant";
            this.gb_garant.Size = new System.Drawing.Size(776, 94);
            this.gb_garant.TabIndex = 11;
            this.gb_garant.TabStop = false;
            this.gb_garant.Text = "Garant";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(6, 32);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(48, 20);
            this.tb_id.TabIndex = 6;
            // 
            // l_email
            // 
            this.l_email.AutoSize = true;
            this.l_email.Location = new System.Drawing.Point(254, 18);
            this.l_email.Name = "l_email";
            this.l_email.Size = new System.Drawing.Size(31, 13);
            this.l_email.TabIndex = 9;
            this.l_email.Text = "email";
            // 
            // l_zkr
            // 
            this.l_zkr.AutoSize = true;
            this.l_zkr.Location = new System.Drawing.Point(104, 18);
            this.l_zkr.Name = "l_zkr";
            this.l_zkr.Size = new System.Drawing.Size(35, 13);
            this.l_zkr.TabIndex = 8;
            this.l_zkr.Text = "jméno";
            // 
            // l_id
            // 
            this.l_id.AutoSize = true;
            this.l_id.Location = new System.Drawing.Point(20, 16);
            this.l_id.Name = "l_id";
            this.l_id.Size = new System.Drawing.Size(18, 13);
            this.l_id.TabIndex = 7;
            this.l_id.Text = "ID";
            // 
            // tb_jm
            // 
            this.tb_jm.Location = new System.Drawing.Point(60, 32);
            this.tb_jm.Name = "tb_jm";
            this.tb_jm.Size = new System.Drawing.Size(138, 20);
            this.tb_jm.TabIndex = 4;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(204, 32);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(138, 20);
            this.tb_email.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(542, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "jméno";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(348, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(492, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(138, 20);
            this.textBox2.TabIndex = 11;
            // 
            // cmb_katedra
            // 
            this.cmb_katedra.FormattingEnabled = true;
            this.cmb_katedra.Location = new System.Drawing.Point(636, 31);
            this.cmb_katedra.Name = "cmb_katedra";
            this.cmb_katedra.Size = new System.Drawing.Size(134, 21);
            this.cmb_katedra.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(683, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Katedra";
            // 
            // FormCUGarant
            // 
            this.AcceptButton = this.bt_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.bt_close;
            this.ClientSize = new System.Drawing.Size(780, 101);
            this.Controls.Add(this.gb_garant);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCUGarant";
            this.Text = "FormCUGarant";
            this.gb_garant.ResumeLayout(false);
            this.gb_garant.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.GroupBox gb_garant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_katedra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label l_email;
        private System.Windows.Forms.Label l_zkr;
        private System.Windows.Forms.Label l_id;
        private System.Windows.Forms.TextBox tb_jm;
        private System.Windows.Forms.TextBox tb_email;
    }
}