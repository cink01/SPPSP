﻿namespace SystemProPodporuStudijnichPlanu.Aplication
{
    partial class FormCUZaznam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCUZaznam));
            this.nud_semestr = new System.Windows.Forms.NumericUpDown();
            this.cmb_obor = new System.Windows.Forms.ComboBox();
            this.bt_close = new System.Windows.Forms.Button();
            this.bt_ok = new System.Windows.Forms.Button();
            this.gb_Zaznam = new System.Windows.Forms.GroupBox();
            this.bt_info = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.l_email = new System.Windows.Forms.Label();
            this.l_zkr = new System.Windows.Forms.Label();
            this.l_id = new System.Windows.Forms.Label();
            this.tb_zkr = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_semestr)).BeginInit();
            this.gb_Zaznam.SuspendLayout();
            this.SuspendLayout();
            // 
            // nud_semestr
            // 
            this.nud_semestr.BackColor = System.Drawing.Color.White;
            this.nud_semestr.Location = new System.Drawing.Point(95, 44);
            this.nud_semestr.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nud_semestr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_semestr.Name = "nud_semestr";
            this.nud_semestr.Size = new System.Drawing.Size(48, 20);
            this.nud_semestr.TabIndex = 2;
            this.nud_semestr.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // cmb_obor
            // 
            this.cmb_obor.BackColor = System.Drawing.Color.White;
            this.cmb_obor.FormattingEnabled = true;
            this.cmb_obor.Location = new System.Drawing.Point(95, 96);
            this.cmb_obor.Name = "cmb_obor";
            this.cmb_obor.Size = new System.Drawing.Size(138, 21);
            this.cmb_obor.TabIndex = 3;
            this.cmb_obor.DropDown += new System.EventHandler(this.Cmb_obor_DropDown);
            this.cmb_obor.SelectedIndexChanged += new System.EventHandler(this.Cmb_obor_SelectedIndexChanged);
            // 
            // bt_close
            // 
            this.bt_close.BackColor = System.Drawing.Color.Red;
            this.bt_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_close.Location = new System.Drawing.Point(109, 123);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(80, 23);
            this.bt_close.TabIndex = 3;
            this.bt_close.Text = "Zavřít";
            this.bt_close.UseVisualStyleBackColor = false;
            // 
            // bt_ok
            // 
            this.bt_ok.BackColor = System.Drawing.Color.Lime;
            this.bt_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_ok.Location = new System.Drawing.Point(33, 123);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(84, 23);
            this.bt_ok.TabIndex = 2;
            this.bt_ok.Text = "Ok";
            this.bt_ok.UseVisualStyleBackColor = false;
            // 
            // gb_Zaznam
            // 
            this.gb_Zaznam.Controls.Add(this.bt_info);
            this.gb_Zaznam.Controls.Add(this.bt_close);
            this.gb_Zaznam.Controls.Add(this.cmb_obor);
            this.gb_Zaznam.Controls.Add(this.bt_ok);
            this.gb_Zaznam.Controls.Add(this.nud_semestr);
            this.gb_Zaznam.Controls.Add(this.label2);
            this.gb_Zaznam.Controls.Add(this.tb_id);
            this.gb_Zaznam.Controls.Add(this.l_email);
            this.gb_Zaznam.Controls.Add(this.l_zkr);
            this.gb_Zaznam.Controls.Add(this.l_id);
            this.gb_Zaznam.Controls.Add(this.tb_zkr);
            this.gb_Zaznam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gb_Zaznam.Location = new System.Drawing.Point(5, 2);
            this.gb_Zaznam.Name = "gb_Zaznam";
            this.gb_Zaznam.Size = new System.Drawing.Size(239, 159);
            this.gb_Zaznam.TabIndex = 12;
            this.gb_Zaznam.TabStop = false;
            this.gb_Zaznam.Text = "Záznam Plánu";
            // 
            // bt_info
            // 
            this.bt_info.BackColor = System.Drawing.Color.Azure;
            this.bt_info.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_info.Location = new System.Drawing.Point(98, 123);
            this.bt_info.Name = "bt_info";
            this.bt_info.Size = new System.Drawing.Size(19, 23);
            this.bt_info.TabIndex = 13;
            this.bt_info.Text = "?";
            this.bt_info.UseVisualStyleBackColor = false;
            this.bt_info.Visible = false;
            this.bt_info.Click += new System.EventHandler(this.Bt_info_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Obor:";
            // 
            // tb_id
            // 
            this.tb_id.BackColor = System.Drawing.Color.White;
            this.tb_id.Location = new System.Drawing.Point(95, 18);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(48, 20);
            this.tb_id.TabIndex = 6;
            this.tb_id.Text = "-";
            // 
            // l_email
            // 
            this.l_email.AutoSize = true;
            this.l_email.Location = new System.Drawing.Point(6, 46);
            this.l_email.Name = "l_email";
            this.l_email.Size = new System.Drawing.Size(83, 13);
            this.l_email.TabIndex = 9;
            this.l_email.Text = "Počet semestrů:";
            // 
            // l_zkr
            // 
            this.l_zkr.AutoSize = true;
            this.l_zkr.Location = new System.Drawing.Point(42, 73);
            this.l_zkr.Name = "l_zkr";
            this.l_zkr.Size = new System.Drawing.Size(47, 13);
            this.l_zkr.TabIndex = 8;
            this.l_zkr.Text = "Zkratka:";
            // 
            // l_id
            // 
            this.l_id.AutoSize = true;
            this.l_id.Location = new System.Drawing.Point(68, 21);
            this.l_id.Name = "l_id";
            this.l_id.Size = new System.Drawing.Size(21, 13);
            this.l_id.TabIndex = 7;
            this.l_id.Text = "ID:";
            // 
            // tb_zkr
            // 
            this.tb_zkr.BackColor = System.Drawing.Color.White;
            this.tb_zkr.Location = new System.Drawing.Point(95, 70);
            this.tb_zkr.Name = "tb_zkr";
            this.tb_zkr.Size = new System.Drawing.Size(138, 20);
            this.tb_zkr.TabIndex = 4;
            // 
            // FormCUZaznam
            // 
            this.AcceptButton = this.bt_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CancelButton = this.bt_close;
            this.ClientSize = new System.Drawing.Size(248, 166);
            this.Controls.Add(this.gb_Zaznam);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCUZaznam";
            this.Text = "FormCUZaznam";
            this.Load += new System.EventHandler(this.FormCUZaznam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_semestr)).EndInit();
            this.gb_Zaznam.ResumeLayout(false);
            this.gb_Zaznam.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nud_semestr;
        private System.Windows.Forms.ComboBox cmb_obor;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.GroupBox gb_Zaznam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label l_email;
        private System.Windows.Forms.Label l_zkr;
        private System.Windows.Forms.Label l_id;
        private System.Windows.Forms.TextBox tb_zkr;
        private System.Windows.Forms.Button bt_info;
    }
}