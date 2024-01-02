namespace Projekt___Zooloski_vrt
{
    partial class nastamba
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
            this.zaposlenici = new System.Windows.Forms.Button();
            this.zivotinje = new System.Windows.Forms.Button();
            this.twoListBox = new System.Windows.Forms.Button();
            this.edit3 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.listBoxNastamba = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // zaposlenici
            // 
            this.zaposlenici.Location = new System.Drawing.Point(91, 57);
            this.zaposlenici.Name = "zaposlenici";
            this.zaposlenici.Size = new System.Drawing.Size(75, 23);
            this.zaposlenici.TabIndex = 0;
            this.zaposlenici.Text = "Zaposlenici";
            this.zaposlenici.UseVisualStyleBackColor = true;
            this.zaposlenici.Click += new System.EventHandler(this.zaposlenici_Click);
            // 
            // zivotinje
            // 
            this.zivotinje.Location = new System.Drawing.Point(233, 57);
            this.zivotinje.Name = "zivotinje";
            this.zivotinje.Size = new System.Drawing.Size(75, 23);
            this.zivotinje.TabIndex = 1;
            this.zivotinje.Text = "Životinje";
            this.zivotinje.UseVisualStyleBackColor = true;
            this.zivotinje.Click += new System.EventHandler(this.zivotinje_Click);
            // 
            // twoListBox
            // 
            this.twoListBox.Location = new System.Drawing.Point(472, 142);
            this.twoListBox.Name = "twoListBox";
            this.twoListBox.Size = new System.Drawing.Size(127, 23);
            this.twoListBox.TabIndex = 2;
            this.twoListBox.Text = "Zivotinje i zaposlenici";
            this.twoListBox.UseVisualStyleBackColor = true;
            this.twoListBox.Click += new System.EventHandler(this.twoListBox_Click);
            // 
            // edit3
            // 
            this.edit3.Location = new System.Drawing.Point(472, 206);
            this.edit3.Name = "edit3";
            this.edit3.Size = new System.Drawing.Size(127, 23);
            this.edit3.TabIndex = 3;
            this.edit3.Text = "Uredi";
            this.edit3.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(472, 279);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(127, 23);
            this.exit.TabIndex = 4;
            this.exit.Text = "Izlaz";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // listBoxNastamba
            // 
            this.listBoxNastamba.FormattingEnabled = true;
            this.listBoxNastamba.Location = new System.Drawing.Point(91, 142);
            this.listBoxNastamba.Name = "listBoxNastamba";
            this.listBoxNastamba.Size = new System.Drawing.Size(287, 160);
            this.listBoxNastamba.TabIndex = 5;
            // 
            // nastamba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxNastamba);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.edit3);
            this.Controls.Add(this.twoListBox);
            this.Controls.Add(this.zivotinje);
            this.Controls.Add(this.zaposlenici);
            this.Name = "nastamba";
            this.Text = "Nastamba";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button zaposlenici;
        private System.Windows.Forms.Button zivotinje;
        private System.Windows.Forms.Button twoListBox;
        private System.Windows.Forms.Button edit3;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.ListBox listBoxNastamba;
    }
}

