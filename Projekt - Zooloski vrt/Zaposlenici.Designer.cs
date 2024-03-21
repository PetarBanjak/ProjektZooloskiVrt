namespace Projekt___Zooloski_vrt
{
    partial class Zaposlenici
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
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.filter = new System.Windows.Forms.ComboBox();
            this.rasponFiltera = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(96, 95);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(261, 340);
            this.listBox2.TabIndex = 6;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(777, 95);
            this.add.Margin = new System.Windows.Forms.Padding(4);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(119, 70);
            this.add.TabIndex = 7;
            this.add.Text = "Dodaj";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(777, 286);
            this.delete.Margin = new System.Windows.Forms.Padding(4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(119, 72);
            this.delete.TabIndex = 8;
            this.delete.Text = "Obriši";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(777, 192);
            this.edit.Margin = new System.Windows.Forms.Padding(4);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(119, 72);
            this.edit.TabIndex = 9;
            this.edit.Text = "Uredi";
            this.edit.UseVisualStyleBackColor = true;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(470, 34);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(167, 22);
            this.searchBox.TabIndex = 10;
            this.searchBox.Text = "Search";
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // filter
            // 
            this.filter.FormattingEnabled = true;
            this.filter.Items.AddRange(new object[] {
            "Ime",
            "Prezime",
            "Godine",
            "Radni položaj"});
            this.filter.Location = new System.Drawing.Point(470, 95);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(167, 24);
            this.filter.TabIndex = 11;
            this.filter.SelectedIndexChanged += new System.EventHandler(this.filter_SelectedIndexChanged);
            // 
            // rasponFiltera
            // 
            this.rasponFiltera.Location = new System.Drawing.Point(470, 202);
            this.rasponFiltera.Name = "rasponFiltera";
            this.rasponFiltera.Size = new System.Drawing.Size(167, 22);
            this.rasponFiltera.TabIndex = 12;
            // 
            // Zaposlenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.rasponFiltera);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.listBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Zaposlenici";
            this.Text = "Zaposlenici";
            this.Load += new System.EventHandler(this.Zaposlenici_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.ComboBox filter;
        private System.Windows.Forms.TextBox rasponFiltera;
    }
}