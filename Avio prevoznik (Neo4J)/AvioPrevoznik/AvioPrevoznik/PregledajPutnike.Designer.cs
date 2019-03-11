namespace AvioPrevoznik
{
    partial class PregledajPutnike
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
            this.listViewPutnici = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnIzbrisiPutnika = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewPutnici
            // 
            this.listViewPutnici.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewPutnici.FullRowSelect = true;
            this.listViewPutnici.Location = new System.Drawing.Point(12, 12);
            this.listViewPutnici.Name = "listViewPutnici";
            this.listViewPutnici.Size = new System.Drawing.Size(322, 267);
            this.listViewPutnici.TabIndex = 0;
            this.listViewPutnici.UseCompatibleStateImageBehavior = false;
            this.listViewPutnici.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prezime";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 80;
            // 
            // btnIzbrisiPutnika
            // 
            this.btnIzbrisiPutnika.Location = new System.Drawing.Point(12, 285);
            this.btnIzbrisiPutnika.Name = "btnIzbrisiPutnika";
            this.btnIzbrisiPutnika.Size = new System.Drawing.Size(108, 49);
            this.btnIzbrisiPutnika.TabIndex = 1;
            this.btnIzbrisiPutnika.Text = "Izbrisi putnika";
            this.btnIzbrisiPutnika.UseVisualStyleBackColor = true;
            this.btnIzbrisiPutnika.Click += new System.EventHandler(this.btnIzbrisiPutnika_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(226, 285);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(108, 49);
            this.btnOtkazi.TabIndex = 2;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // PregledajPutnike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 346);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnIzbrisiPutnika);
            this.Controls.Add(this.listViewPutnici);
            this.MaximumSize = new System.Drawing.Size(378, 393);
            this.MinimumSize = new System.Drawing.Size(378, 393);
            this.Name = "PregledajPutnike";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uvid u putnike";
            this.Load += new System.EventHandler(this.PregledajPutnike_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewPutnici;
        private System.Windows.Forms.Button btnIzbrisiPutnika;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}