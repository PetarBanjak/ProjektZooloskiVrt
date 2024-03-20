namespace Projekt___Zooloski_vrt
{
    partial class Zaposlenici_adder
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
            this.zivotinja_add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.godine = new System.Windows.Forms.TextBox();
            this.radni_polozaj = new System.Windows.Forms.TextBox();
            this.prezime = new System.Windows.Forms.TextBox();
            this.ime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // zivotinja_add
            // 
            this.zivotinja_add.Location = new System.Drawing.Point(612, 212);
            this.zivotinja_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zivotinja_add.Name = "zivotinja_add";
            this.zivotinja_add.Size = new System.Drawing.Size(125, 62);
            this.zivotinja_add.TabIndex = 21;
            this.zivotinja_add.Text = "Dodaj";
            this.zivotinja_add.UseVisualStyleBackColor = true;
            this.zivotinja_add.Click += new System.EventHandler(this.zivotinja_add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 393);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Radni položaj";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 277);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Godine";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ime";
            // 
            // godine
            // 
            this.godine.Location = new System.Drawing.Point(307, 277);
            this.godine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.godine.Name = "godine";
            this.godine.Size = new System.Drawing.Size(132, 22);
            this.godine.TabIndex = 15;
            // 
            // radni_polozaj
            // 
            this.radni_polozaj.Location = new System.Drawing.Point(307, 393);
            this.radni_polozaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radni_polozaj.Name = "radni_polozaj";
            this.radni_polozaj.Size = new System.Drawing.Size(132, 22);
            this.radni_polozaj.TabIndex = 14;
            // 
            // prezime
            // 
            this.prezime.Location = new System.Drawing.Point(307, 171);
            this.prezime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prezime.Name = "prezime";
            this.prezime.Size = new System.Drawing.Size(132, 22);
            this.prezime.TabIndex = 12;
            // 
            // ime
            // 
            this.ime.Location = new System.Drawing.Point(307, 57);
            this.ime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ime.Name = "ime";
            this.ime.Size = new System.Drawing.Size(132, 22);
            this.ime.TabIndex = 11;
            // 
            // Zaposlenici_adder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.zivotinja_add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.godine);
            this.Controls.Add(this.radni_polozaj);
            this.Controls.Add(this.prezime);
            this.Controls.Add(this.ime);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Zaposlenici_adder";
            this.Text = "Zaposlenici_adder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button zivotinja_add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox godine;
        private System.Windows.Forms.TextBox radni_polozaj;
        private System.Windows.Forms.TextBox prezime;
        private System.Windows.Forms.TextBox ime;
    }
}