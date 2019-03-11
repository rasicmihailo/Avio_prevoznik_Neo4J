namespace AvioPrevoznik
{
    partial class PregledajRadnike
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
            this.btnOtpusti = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.listViewRadnici = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnOtpusti
            // 
            this.btnOtpusti.Location = new System.Drawing.Point(12, 188);
            this.btnOtpusti.Name = "btnOtpusti";
            this.btnOtpusti.Size = new System.Drawing.Size(92, 45);
            this.btnOtpusti.TabIndex = 1;
            this.btnOtpusti.Text = "Otpusti radnika";
            this.btnOtpusti.UseVisualStyleBackColor = true;
            this.btnOtpusti.Click += new System.EventHandler(this.btnOtpusti_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(277, 187);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(103, 46);
            this.btnOtkazi.TabIndex = 2;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // listViewRadnici
            // 
            this.listViewRadnici.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewRadnici.FullRowSelect = true;
            this.listViewRadnici.Location = new System.Drawing.Point(13, 22);
            this.listViewRadnici.Margin = new System.Windows.Forms.Padding(4);
            this.listViewRadnici.Name = "listViewRadnici";
            this.listViewRadnici.Size = new System.Drawing.Size(367, 138);
            this.listViewRadnici.TabIndex = 25;
            this.listViewRadnici.UseCompatibleStateImageBehavior = false;
            this.listViewRadnici.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 28;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime";
            this.columnHeader2.Width = 85;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prezime";
            this.columnHeader3.Width = 83;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Korisnicko";
            this.columnHeader4.Width = 80;
            // 
            // PregledajRadnike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 252);
            this.Controls.Add(this.listViewRadnici);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnOtpusti);
            this.MaximumSize = new System.Drawing.Size(428, 299);
            this.MinimumSize = new System.Drawing.Size(428, 299);
            this.Name = "PregledajRadnike";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregledaj radnike";
            this.Load += new System.EventHandler(this.PregledajRadnike_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOtpusti;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.ListView listViewRadnici;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}