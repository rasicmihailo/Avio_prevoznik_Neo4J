namespace AvioPrevoznik
{
    partial class OdaberiKlasu
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
            this.cmbPrtljag = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbKlasa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbSedista = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCeneKarata = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbPrtljag
            // 
            this.cmbPrtljag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrtljag.FormattingEnabled = true;
            this.cmbPrtljag.Items.AddRange(new object[] {
            "0-10",
            "10-20",
            "20-35"});
            this.cmbPrtljag.Location = new System.Drawing.Point(153, 62);
            this.cmbPrtljag.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPrtljag.Name = "cmbPrtljag";
            this.cmbPrtljag.Size = new System.Drawing.Size(209, 24);
            this.cmbPrtljag.TabIndex = 13;
            this.cmbPrtljag.SelectedIndexChanged += new System.EventHandler(this.cmbPrtljag_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Velicina prtljaga(kg):";
            // 
            // cmbKlasa
            // 
            this.cmbKlasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKlasa.FormattingEnabled = true;
            this.cmbKlasa.Items.AddRange(new object[] {
            "Businees",
            "Economy"});
            this.cmbKlasa.Location = new System.Drawing.Point(153, 15);
            this.cmbKlasa.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKlasa.Name = "cmbKlasa";
            this.cmbKlasa.Size = new System.Drawing.Size(209, 24);
            this.cmbKlasa.TabIndex = 11;
            this.cmbKlasa.SelectedIndexChanged += new System.EventHandler(this.cmbKlasa_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Odaberite klasu:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(83, 244);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 37);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(262, 244);
            this.btnOtkazi.Margin = new System.Windows.Forms.Padding(4);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(100, 37);
            this.btnOtkazi.TabIndex = 15;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(153, 111);
            this.txtCena.Margin = new System.Windows.Forms.Padding(4);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(95, 22);
            this.txtCena.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(60, 171);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Broj sedista:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 111);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Ukupna cena karte:";
            // 
            // cmbSedista
            // 
            this.cmbSedista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSedista.FormattingEnabled = true;
            this.cmbSedista.Location = new System.Drawing.Point(153, 168);
            this.cmbSedista.Name = "cmbSedista";
            this.cmbSedista.Size = new System.Drawing.Size(95, 24);
            this.cmbSedista.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Cene karata:";
            // 
            // cmbCeneKarata
            // 
            this.cmbCeneKarata.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCeneKarata.FormattingEnabled = true;
            this.cmbCeneKarata.Location = new System.Drawing.Point(353, 111);
            this.cmbCeneKarata.Name = "cmbCeneKarata";
            this.cmbCeneKarata.Size = new System.Drawing.Size(95, 24);
            this.cmbCeneKarata.TabIndex = 29;
            // 
            // OdaberiKlasu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 300);
            this.Controls.Add(this.cmbCeneKarata);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSedista);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cmbPrtljag);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbKlasa);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(478, 347);
            this.MinimumSize = new System.Drawing.Size(478, 347);
            this.Name = "OdaberiKlasu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OdaberiKlasu";
            this.Load += new System.EventHandler(this.OdaberiKlasu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPrtljag;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbKlasa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbSedista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCeneKarata;
    }
}