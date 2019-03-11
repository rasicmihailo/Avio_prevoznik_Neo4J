namespace AvioPrevoznik
{
    partial class Logovanje
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
            this.lblKorisnicko = new System.Windows.Forms.Label();
            this.lblSifra = new System.Windows.Forms.Label();
            this.btnPrijaviSe = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.txtKorisnicko = new System.Windows.Forms.TextBox();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.btnRegistracija = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKorisnicko
            // 
            this.lblKorisnicko.AutoSize = true;
            this.lblKorisnicko.Location = new System.Drawing.Point(16, 48);
            this.lblKorisnicko.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKorisnicko.Name = "lblKorisnicko";
            this.lblKorisnicko.Size = new System.Drawing.Size(103, 17);
            this.lblKorisnicko.TabIndex = 0;
            this.lblKorisnicko.Text = "Korisnicko ime:";
            // 
            // lblSifra
            // 
            this.lblSifra.AutoSize = true;
            this.lblSifra.Location = new System.Drawing.Point(16, 82);
            this.lblSifra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(41, 17);
            this.lblSifra.TabIndex = 1;
            this.lblSifra.Text = "Sifra:";
            // 
            // btnPrijaviSe
            // 
            this.btnPrijaviSe.Location = new System.Drawing.Point(153, 132);
            this.btnPrijaviSe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrijaviSe.Name = "btnPrijaviSe";
            this.btnPrijaviSe.Size = new System.Drawing.Size(100, 47);
            this.btnPrijaviSe.TabIndex = 2;
            this.btnPrijaviSe.Text = "Prijavi se";
            this.btnPrijaviSe.UseVisualStyleBackColor = true;
            this.btnPrijaviSe.Click += new System.EventHandler(this.btnPrijaviSe_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(291, 132);
            this.btnOtkazi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(100, 47);
            this.btnOtkazi.TabIndex = 3;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // txtKorisnicko
            // 
            this.txtKorisnicko.Location = new System.Drawing.Point(128, 44);
            this.txtKorisnicko.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKorisnicko.Name = "txtKorisnicko";
            this.txtKorisnicko.Size = new System.Drawing.Size(261, 22);
            this.txtKorisnicko.TabIndex = 4;
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(128, 82);
            this.txtSifra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(261, 22);
            this.txtSifra.TabIndex = 5;
            this.txtSifra.UseSystemPasswordChar = true;
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.Location = new System.Drawing.Point(19, 132);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(100, 47);
            this.btnRegistracija.TabIndex = 6;
            this.btnRegistracija.Text = "Registracija\r\n admina";
            this.btnRegistracija.UseVisualStyleBackColor = true;
            this.btnRegistracija.Click += new System.EventHandler(this.btnRegistracija_Click);
            // 
            // Logovanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 193);
            this.Controls.Add(this.btnRegistracija);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.txtKorisnicko);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnPrijaviSe);
            this.Controls.Add(this.lblSifra);
            this.Controls.Add(this.lblKorisnicko);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(439, 240);
            this.Name = "Logovanje";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logovanje";
            this.Load += new System.EventHandler(this.Logovanje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKorisnicko;
        private System.Windows.Forms.Label lblSifra;
        private System.Windows.Forms.Button btnPrijaviSe;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.TextBox txtKorisnicko;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.Button btnRegistracija;
    }
}