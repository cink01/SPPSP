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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCUGarant));
            this.bt_close = new System.Windows.Forms.Button();
            this.bt_ok = new System.Windows.Forms.Button();
            this.gb_garant = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_katedra = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_tel = new System.Windows.Forms.TextBox();
            this.tb_konz = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.l_email = new System.Windows.Forms.Label();
            this.l_zkr = new System.Windows.Forms.Label();
            this.l_id = new System.Windows.Forms.Label();
            this.tb_jm = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.errorProvider_EMAIL = new System.Windows.Forms.ErrorProvider(this.components);
            this.gb_garant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_EMAIL)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_close
            // 
            this.bt_close.BackColor = System.Drawing.Color.Red;
            this.bt_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_close.Location = new System.Drawing.Point(143, 193);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(80, 23);
            this.bt_close.TabIndex = 7;
            this.bt_close.Text = "Zavřít";
            this.bt_close.UseVisualStyleBackColor = false;
            this.bt_close.Click += new System.EventHandler(this.Bt_close_Click);
            // 
            // bt_ok
            // 
            this.bt_ok.BackColor = System.Drawing.Color.Lime;
            this.bt_ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_ok.Location = new System.Drawing.Point(53, 193);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(84, 23);
            this.bt_ok.TabIndex = 6;
            this.bt_ok.Text = "Ok";
            this.bt_ok.UseVisualStyleBackColor = false;
            this.bt_ok.Click += new System.EventHandler(this.Bt_ok_Click);
            // 
            // gb_garant
            // 
            this.gb_garant.Controls.Add(this.label3);
            this.gb_garant.Controls.Add(this.cmb_katedra);
            this.gb_garant.Controls.Add(this.label1);
            this.gb_garant.Controls.Add(this.label2);
            this.gb_garant.Controls.Add(this.tb_tel);
            this.gb_garant.Controls.Add(this.tb_konz);
            this.gb_garant.Controls.Add(this.tb_id);
            this.gb_garant.Controls.Add(this.l_email);
            this.gb_garant.Controls.Add(this.l_zkr);
            this.gb_garant.Controls.Add(this.l_id);
            this.gb_garant.Controls.Add(this.tb_jm);
            this.gb_garant.Controls.Add(this.tb_email);
            this.gb_garant.Location = new System.Drawing.Point(12, 12);
            this.gb_garant.Name = "gb_garant";
            this.gb_garant.Size = new System.Drawing.Size(269, 175);
            this.gb_garant.TabIndex = 11;
            this.gb_garant.TabStop = false;
            this.gb_garant.Text = "Garant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Katedra:";
            // 
            // cmb_katedra
            // 
            this.cmb_katedra.FormattingEnabled = true;
            this.cmb_katedra.Location = new System.Drawing.Point(117, 144);
            this.cmb_katedra.Name = "cmb_katedra";
            this.cmb_katedra.Size = new System.Drawing.Size(138, 21);
            this.cmb_katedra.TabIndex = 5;
            this.cmb_katedra.DropDown += new System.EventHandler(this.Kat_Hledani);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Konzultační hodiny:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Telefon:";
            // 
            // tb_tel
            // 
            this.tb_tel.Location = new System.Drawing.Point(117, 92);
            this.tb_tel.Name = "tb_tel";
            this.tb_tel.Size = new System.Drawing.Size(138, 20);
            this.tb_tel.TabIndex = 3;
            // 
            // tb_konz
            // 
            this.tb_konz.Location = new System.Drawing.Point(117, 118);
            this.tb_konz.Name = "tb_konz";
            this.tb_konz.Size = new System.Drawing.Size(138, 20);
            this.tb_konz.TabIndex = 4;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(117, 14);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(48, 20);
            this.tb_id.TabIndex = 0;
            // 
            // l_email
            // 
            this.l_email.AutoSize = true;
            this.l_email.Location = new System.Drawing.Point(76, 69);
            this.l_email.Name = "l_email";
            this.l_email.Size = new System.Drawing.Size(35, 13);
            this.l_email.TabIndex = 9;
            this.l_email.Text = "Email:";
            // 
            // l_zkr
            // 
            this.l_zkr.AutoSize = true;
            this.l_zkr.Location = new System.Drawing.Point(70, 43);
            this.l_zkr.Name = "l_zkr";
            this.l_zkr.Size = new System.Drawing.Size(41, 13);
            this.l_zkr.TabIndex = 8;
            this.l_zkr.Text = "Jméno:";
            // 
            // l_id
            // 
            this.l_id.AutoSize = true;
            this.l_id.Location = new System.Drawing.Point(90, 17);
            this.l_id.Name = "l_id";
            this.l_id.Size = new System.Drawing.Size(21, 13);
            this.l_id.TabIndex = 7;
            this.l_id.Text = "ID:";
            // 
            // tb_jm
            // 
            this.tb_jm.Location = new System.Drawing.Point(117, 40);
            this.tb_jm.Name = "tb_jm";
            this.tb_jm.Size = new System.Drawing.Size(138, 20);
            this.tb_jm.TabIndex = 1;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(117, 66);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(138, 20);
            this.tb_email.TabIndex = 2;
            this.tb_email.Validating += new System.ComponentModel.CancelEventHandler(this.Tb_email_Validating);
            // 
            // errorProvider_EMAIL
            // 
            this.errorProvider_EMAIL.ContainerControl = this;
            // 
            // FormCUGarant
            // 
            this.AcceptButton = this.bt_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CancelButton = this.bt_close;
            this.ClientSize = new System.Drawing.Size(291, 224);
            this.Controls.Add(this.gb_garant);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.bt_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCUGarant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormCUGarant";
            this.gb_garant.ResumeLayout(false);
            this.gb_garant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_EMAIL)).EndInit();
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
        private System.Windows.Forms.TextBox tb_tel;
        private System.Windows.Forms.TextBox tb_konz;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label l_email;
        private System.Windows.Forms.Label l_zkr;
        private System.Windows.Forms.Label l_id;
        private System.Windows.Forms.TextBox tb_jm;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.ErrorProvider errorProvider_EMAIL;
    }
}