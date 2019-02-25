namespace SystemProPodporuStudijnichPlanu.Aplication
{
    partial class FormCUKatedra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCUKatedra));
            this.bt_close = new System.Windows.Forms.Button();
            this.bt_ok = new System.Windows.Forms.Button();
            this.tb_zkr = new System.Windows.Forms.TextBox();
            this.tb_název = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.l_id = new System.Windows.Forms.Label();
            this.l_zkr = new System.Windows.Forms.Label();
            this.l_nazev = new System.Windows.Forms.Label();
            this.gb_katedra = new System.Windows.Forms.GroupBox();
            this.gb_katedra.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_close
            // 
            this.bt_close.BackColor = System.Drawing.Color.Red;
            this.bt_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_close.Location = new System.Drawing.Point(102, 90);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(75, 23);
            this.bt_close.TabIndex = 3;
            this.bt_close.Text = "Zavřít";
            this.bt_close.UseVisualStyleBackColor = false;
            this.bt_close.Click += new System.EventHandler(this.Bt_close_Click);
            // 
            // bt_ok
            // 
            this.bt_ok.BackColor = System.Drawing.Color.Lime;
            this.bt_ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_ok.Location = new System.Drawing.Point(18, 90);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(75, 23);
            this.bt_ok.TabIndex = 2;
            this.bt_ok.Text = "Ok";
            this.bt_ok.UseVisualStyleBackColor = false;
            this.bt_ok.Click += new System.EventHandler(this.Bt_ok_Click);
            // 
            // tb_zkr
            // 
            this.tb_zkr.Location = new System.Drawing.Point(54, 64);
            this.tb_zkr.Name = "tb_zkr";
            this.tb_zkr.Size = new System.Drawing.Size(138, 20);
            this.tb_zkr.TabIndex = 4;
            // 
            // tb_název
            // 
            this.tb_název.Location = new System.Drawing.Point(54, 38);
            this.tb_název.Name = "tb_název";
            this.tb_název.Size = new System.Drawing.Size(138, 20);
            this.tb_název.TabIndex = 5;
            // 
            // tb_id
            // 
            this.tb_id.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_id.Location = new System.Drawing.Point(54, 15);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(48, 20);
            this.tb_id.TabIndex = 6;
            // 
            // l_id
            // 
            this.l_id.AutoSize = true;
            this.l_id.Location = new System.Drawing.Point(30, 18);
            this.l_id.Name = "l_id";
            this.l_id.Size = new System.Drawing.Size(21, 13);
            this.l_id.TabIndex = 7;
            this.l_id.Text = "ID:";
            // 
            // l_zkr
            // 
            this.l_zkr.AutoSize = true;
            this.l_zkr.Location = new System.Drawing.Point(6, 41);
            this.l_zkr.Name = "l_zkr";
            this.l_zkr.Size = new System.Drawing.Size(47, 13);
            this.l_zkr.TabIndex = 8;
            this.l_zkr.Text = "Zkratka:";
            // 
            // l_nazev
            // 
            this.l_nazev.AutoSize = true;
            this.l_nazev.Location = new System.Drawing.Point(12, 67);
            this.l_nazev.Name = "l_nazev";
            this.l_nazev.Size = new System.Drawing.Size(41, 13);
            this.l_nazev.TabIndex = 9;
            this.l_nazev.Text = "Název:";
            // 
            // gb_katedra
            // 
            this.gb_katedra.BackColor = System.Drawing.Color.Transparent;
            this.gb_katedra.Controls.Add(this.tb_id);
            this.gb_katedra.Controls.Add(this.l_nazev);
            this.gb_katedra.Controls.Add(this.bt_ok);
            this.gb_katedra.Controls.Add(this.l_zkr);
            this.gb_katedra.Controls.Add(this.bt_close);
            this.gb_katedra.Controls.Add(this.l_id);
            this.gb_katedra.Controls.Add(this.tb_zkr);
            this.gb_katedra.Controls.Add(this.tb_název);
            this.gb_katedra.Location = new System.Drawing.Point(12, 12);
            this.gb_katedra.Name = "gb_katedra";
            this.gb_katedra.Size = new System.Drawing.Size(200, 124);
            this.gb_katedra.TabIndex = 10;
            this.gb_katedra.TabStop = false;
            this.gb_katedra.Text = "Katedra";
            // 
            // FormCUKatedra
            // 
            this.AcceptButton = this.bt_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CancelButton = this.bt_close;
            this.ClientSize = new System.Drawing.Size(223, 147);
            this.Controls.Add(this.gb_katedra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCUKatedra";
            this.Text = "FormCUKatedra";
            this.gb_katedra.ResumeLayout(false);
            this.gb_katedra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.TextBox tb_zkr;
        private System.Windows.Forms.TextBox tb_název;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label l_id;
        private System.Windows.Forms.Label l_zkr;
        private System.Windows.Forms.Label l_nazev;
        private System.Windows.Forms.GroupBox gb_katedra;
    }
}