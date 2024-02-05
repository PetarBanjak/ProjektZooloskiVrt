namespace Projekt___Zooloski_vrt
{
    partial class Zivotinje
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
            this.edit2 = new System.Windows.Forms.Button();
            this.delete2 = new System.Windows.Forms.Button();
            this.add3 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // edit2
            // 
            this.edit2.Location = new System.Drawing.Point(371, 192);
            this.edit2.Name = "edit2";
            this.edit2.Size = new System.Drawing.Size(89, 23);
            this.edit2.TabIndex = 13;
            this.edit2.Text = "Uredi";
            this.edit2.UseVisualStyleBackColor = true;
            // 
            // delete2
            // 
            this.delete2.Location = new System.Drawing.Point(371, 268);
            this.delete2.Name = "delete2";
            this.delete2.Size = new System.Drawing.Size(89, 23);
            this.delete2.TabIndex = 12;
            this.delete2.Text = "Obriši";
            this.delete2.UseVisualStyleBackColor = true;
            // 
            // add3
            // 
            this.add3.Location = new System.Drawing.Point(371, 125);
            this.add3.Name = "add3";
            this.add3.Size = new System.Drawing.Size(89, 23);
            this.add3.TabIndex = 11;
            this.add3.Text = "Dodaj";
            this.add3.UseVisualStyleBackColor = true;
            this.add3.Click += new System.EventHandler(this.add3_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(88, 81);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(197, 277);
            this.listBox2.TabIndex = 10;
            // 
            // Zivotinje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.edit2);
            this.Controls.Add(this.delete2);
            this.Controls.Add(this.add3);
            this.Controls.Add(this.listBox2);
            this.Name = "Zivotinje";
            this.Text = "Zivotinje";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button edit2;
        private System.Windows.Forms.Button delete2;
        private System.Windows.Forms.Button add3;
        private System.Windows.Forms.ListBox listBox2;
    }
}