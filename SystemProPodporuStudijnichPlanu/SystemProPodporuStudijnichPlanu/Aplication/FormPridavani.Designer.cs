namespace SystemProPodporuStudijnichPlanu
{
    partial class FormPridavani
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
            this.lb_seznam = new System.Windows.Forms.ListBox();
            this.lb_pridat = new System.Windows.Forms.ListBox();
            this.bt_move_prid = new System.Windows.Forms.Button();
            this.bt_move_odb = new System.Windows.Forms.Button();
            this.bt_pridat = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_seznam
            // 
            this.lb_seznam.FormattingEnabled = true;
            this.lb_seznam.Location = new System.Drawing.Point(12, 43);
            this.lb_seznam.Name = "lb_seznam";
            this.lb_seznam.Size = new System.Drawing.Size(201, 329);
            this.lb_seznam.TabIndex = 0;
            // 
            // lb_pridat
            // 
            this.lb_pridat.FormattingEnabled = true;
            this.lb_pridat.Location = new System.Drawing.Point(306, 43);
            this.lb_pridat.Name = "lb_pridat";
            this.lb_pridat.Size = new System.Drawing.Size(201, 329);
            this.lb_pridat.TabIndex = 1;
            // 
            // bt_move_prid
            // 
            this.bt_move_prid.BackColor = System.Drawing.Color.Transparent;
            this.bt_move_prid.ForeColor = System.Drawing.Color.Transparent;
            this.bt_move_prid.Image = global::SystemProPodporuStudijnichPlanu.Properties.Resources.ButtonL53;
            this.bt_move_prid.Location = new System.Drawing.Point(230, 135);
            this.bt_move_prid.Name = "bt_move_prid";
            this.bt_move_prid.Size = new System.Drawing.Size(52, 49);
            this.bt_move_prid.TabIndex = 2;
            this.bt_move_prid.UseVisualStyleBackColor = false;
            this.bt_move_prid.Click += new System.EventHandler(this.bt_move_prid_Click);
            // 
            // bt_move_odb
            // 
            this.bt_move_odb.BackColor = System.Drawing.Color.Transparent;
            this.bt_move_odb.ForeColor = System.Drawing.Color.Transparent;
            this.bt_move_odb.Image = global::SystemProPodporuStudijnichPlanu.Properties.Resources.ButtonR53;
            this.bt_move_odb.Location = new System.Drawing.Point(230, 240);
            this.bt_move_odb.Name = "bt_move_odb";
            this.bt_move_odb.Size = new System.Drawing.Size(52, 49);
            this.bt_move_odb.TabIndex = 3;
            this.bt_move_odb.UseVisualStyleBackColor = false;
            this.bt_move_odb.Click += new System.EventHandler(this.bt_move_odb_Click);
            // 
            // bt_pridat
            // 
            this.bt_pridat.Location = new System.Drawing.Point(150, 404);
            this.bt_pridat.Name = "bt_pridat";
            this.bt_pridat.Size = new System.Drawing.Size(101, 34);
            this.bt_pridat.TabIndex = 4;
            this.bt_pridat.Text = "Přidat";
            this.bt_pridat.UseVisualStyleBackColor = true;
            this.bt_pridat.Click += new System.EventHandler(this.bt_pridat_Click);
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(268, 404);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(101, 34);
            this.bt_close.TabIndex = 5;
            this.bt_close.Text = "Zavřít";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // FormPridavani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.bt_pridat);
            this.Controls.Add(this.bt_move_odb);
            this.Controls.Add(this.bt_move_prid);
            this.Controls.Add(this.lb_pridat);
            this.Controls.Add(this.lb_seznam);
            this.Name = "FormPridavani";
            this.Text = "FormPridavani";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_seznam;
        private System.Windows.Forms.ListBox lb_pridat;
        private System.Windows.Forms.Button bt_move_prid;
        private System.Windows.Forms.Button bt_move_odb;
        private System.Windows.Forms.Button bt_pridat;
        private System.Windows.Forms.Button bt_close;
    }
}