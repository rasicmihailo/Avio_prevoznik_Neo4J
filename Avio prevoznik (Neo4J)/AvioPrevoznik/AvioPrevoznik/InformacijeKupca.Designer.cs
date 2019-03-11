namespace AvioPrevoznik
{
    partial class InformacijeKupca
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
            this.txtPasos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrezimeKupca = new System.Windows.Forms.TextBox();
            this.txtImeKupca = new System.Windows.Forms.TextBox();
            this.prez = new System.Windows.Forms.Label();
            this.ime = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPasos
            // 
            this.txtPasos.Location = new System.Drawing.Point(176, 84);
            this.txtPasos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPasos.Name = "txtPasos";
            this.txtPasos.Size = new System.Drawing.Size(209, 22);
            this.txtPasos.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Unesite broj pasosa:";
            // 
            // txtPrezimeKupca
            // 
            this.txtPrezimeKupca.Location = new System.Drawing.Point(176, 48);
            this.txtPrezimeKupca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrezimeKupca.Name = "txtPrezimeKupca";
            this.txtPrezimeKupca.Size = new System.Drawing.Size(209, 22);
            this.txtPrezimeKupca.TabIndex = 9;
            // 
            // txtImeKupca
            // 
            this.txtImeKupca.Location = new System.Drawing.Point(176, 15);
            this.txtImeKupca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtImeKupca.Name = "txtImeKupca";
            this.txtImeKupca.Size = new System.Drawing.Size(209, 22);
            this.txtImeKupca.TabIndex = 8;
            // 
            // prez
            // 
            this.prez.AutoSize = true;
            this.prez.Location = new System.Drawing.Point(9, 48);
            this.prez.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prez.Name = "prez";
            this.prez.Size = new System.Drawing.Size(156, 17);
            this.prez.TabIndex = 7;
            this.prez.Text = "Unesite prezime kupca:";
            // 
            // ime
            // 
            this.ime.AutoSize = true;
            this.ime.Location = new System.Drawing.Point(36, 15);
            this.ime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ime.Name = "ime";
            this.ime.Size = new System.Drawing.Size(128, 17);
            this.ime.TabIndex = 6;
            this.ime.Text = "Unesite ime kupca:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(73, 143);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 41);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(256, 143);
            this.btnOtkazi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(100, 41);
            this.btnOtkazi.TabIndex = 13;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // InformacijeKupca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 201);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtPasos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrezimeKupca);
            this.Controls.Add(this.txtImeKupca);
            this.Controls.Add(this.prez);
            this.Controls.Add(this.ime);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InformacijeKupca";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "c";
            this.Load += new System.EventHandler(this.InformacijeKupca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPasos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrezimeKupca;
        private System.Windows.Forms.TextBox txtImeKupca;
        private System.Windows.Forms.Label prez;
        private System.Windows.Forms.Label ime;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnOtkazi;
    }
}