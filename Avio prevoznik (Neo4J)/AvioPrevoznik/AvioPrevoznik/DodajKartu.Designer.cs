namespace AvioPrevoznik
{
    partial class DodajKartu
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtPolazak = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOdrediste = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.datePolazak = new System.Windows.Forms.DateTimePicker();
            this.listViewLetovi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPronadji = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.listViewPresedanja = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnIzmeniPodatke = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mesto polaska:";
            // 
            // txtPolazak
            // 
            this.txtPolazak.Location = new System.Drawing.Point(152, 15);
            this.txtPolazak.Margin = new System.Windows.Forms.Padding(4);
            this.txtPolazak.Name = "txtPolazak";
            this.txtPolazak.Size = new System.Drawing.Size(296, 22);
            this.txtPolazak.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Destinacija:";
            // 
            // txtOdrediste
            // 
            this.txtOdrediste.Location = new System.Drawing.Point(152, 52);
            this.txtOdrediste.Margin = new System.Windows.Forms.Padding(4);
            this.txtOdrediste.Name = "txtOdrediste";
            this.txtOdrediste.Size = new System.Drawing.Size(296, 22);
            this.txtOdrediste.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Datum polaska:";
            // 
            // datePolazak
            // 
            this.datePolazak.Location = new System.Drawing.Point(152, 86);
            this.datePolazak.Margin = new System.Windows.Forms.Padding(4);
            this.datePolazak.Name = "datePolazak";
            this.datePolazak.Size = new System.Drawing.Size(244, 22);
            this.datePolazak.TabIndex = 15;
            // 
            // listViewLetovi
            // 
            this.listViewLetovi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader13});
            this.listViewLetovi.FullRowSelect = true;
            this.listViewLetovi.Location = new System.Drawing.Point(16, 135);
            this.listViewLetovi.Margin = new System.Windows.Forms.Padding(4);
            this.listViewLetovi.Name = "listViewLetovi";
            this.listViewLetovi.Size = new System.Drawing.Size(694, 138);
            this.listViewLetovi.TabIndex = 24;
            this.listViewLetovi.UseCompatibleStateImageBehavior = false;
            this.listViewLetovi.View = System.Windows.Forms.View.Details;
            this.listViewLetovi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewLetovi_MouseClick);
            this.listViewLetovi.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewLetovi_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 28;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Datum Polaska";
            this.columnHeader2.Width = 85;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Vreme Polaska";
            this.columnHeader3.Width = 83;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Vreme Letenja";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Polazak";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Destinacija";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 75;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Direktan Let";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader13.Width = 70;
            // 
            // btnPronadji
            // 
            this.btnPronadji.Location = new System.Drawing.Point(136, 311);
            this.btnPronadji.Margin = new System.Windows.Forms.Padding(4);
            this.btnPronadji.Name = "btnPronadji";
            this.btnPronadji.Size = new System.Drawing.Size(100, 48);
            this.btnPronadji.TabIndex = 25;
            this.btnPronadji.Text = "Pronadji";
            this.btnPronadji.UseVisualStyleBackColor = true;
            this.btnPronadji.Click += new System.EventHandler(this.btnPronadji_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(377, 311);
            this.btnOtkazi.Margin = new System.Windows.Forms.Padding(4);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(100, 48);
            this.btnOtkazi.TabIndex = 26;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // listViewPresedanja
            // 
            this.listViewPresedanja.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.listViewPresedanja.FullRowSelect = true;
            this.listViewPresedanja.Location = new System.Drawing.Point(19, 395);
            this.listViewPresedanja.Margin = new System.Windows.Forms.Padding(4);
            this.listViewPresedanja.Name = "listViewPresedanja";
            this.listViewPresedanja.Size = new System.Drawing.Size(694, 138);
            this.listViewPresedanja.TabIndex = 27;
            this.listViewPresedanja.UseCompatibleStateImageBehavior = false;
            this.listViewPresedanja.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ID";
            this.columnHeader7.Width = 28;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Datum Polaska";
            this.columnHeader8.Width = 85;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Vreme Polaska";
            this.columnHeader9.Width = 83;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Vreme Letenja";
            this.columnHeader10.Width = 80;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Polazak";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 85;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Destinacija";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 80;
            // 
            // btnIzmeniPodatke
            // 
            this.btnIzmeniPodatke.Location = new System.Drawing.Point(577, 15);
            this.btnIzmeniPodatke.Name = "btnIzmeniPodatke";
            this.btnIzmeniPodatke.Size = new System.Drawing.Size(133, 54);
            this.btnIzmeniPodatke.TabIndex = 28;
            this.btnIzmeniPodatke.Text = "Izmeni svoje podatke";
            this.btnIzmeniPodatke.UseVisualStyleBackColor = true;
            this.btnIzmeniPodatke.Click += new System.EventHandler(this.btnIzmeniPodatke_Click);
            // 
            // DodajKartu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 546);
            this.Controls.Add(this.btnIzmeniPodatke);
            this.Controls.Add(this.listViewPresedanja);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnPronadji);
            this.Controls.Add(this.listViewLetovi);
            this.Controls.Add(this.datePolazak);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOdrediste);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPolazak);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(741, 593);
            this.MinimumSize = new System.Drawing.Size(741, 593);
            this.Name = "DodajKartu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DodajKartu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPolazak;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOdrediste;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datePolazak;
        private System.Windows.Forms.ListView listViewLetovi;
        private System.Windows.Forms.Button btnPronadji;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ListView listViewPresedanja;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Button btnIzmeniPodatke;
    }
}