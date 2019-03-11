namespace AvioPrevoznik
{
    partial class Letovi
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
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DATUM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VREME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodajRadnike = new System.Windows.Forms.Button();
            this.btnPregledajRadnike = new System.Windows.Forms.Button();
            this.btnPregledajLet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(575, 80);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 51);
            this.button4.TabIndex = 15;
            this.button4.Text = "Avioni";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(575, 13);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(151, 48);
            this.button5.TabIndex = 14;
            this.button5.Text = "Aerodromi";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(368, 412);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 43);
            this.button3.TabIndex = 13;
            this.button3.Text = "Izbrisi";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(203, 412);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 43);
            this.button2.TabIndex = 12;
            this.button2.Text = "Azuriraj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 412);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 43);
            this.button1.TabIndex = 11;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.OD,
            this.DO,
            this.DATUM,
            this.VREME});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(23, 13);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(528, 368);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 34;
            // 
            // OD
            // 
            this.OD.Text = "OD";
            this.OD.Width = 99;
            // 
            // DO
            // 
            this.DO.Text = "DO";
            this.DO.Width = 113;
            // 
            // DATUM
            // 
            this.DATUM.Text = "DATUM";
            this.DATUM.Width = 70;
            // 
            // VREME
            // 
            this.VREME.Text = "VREME";
            this.VREME.Width = 73;
            // 
            // btnDodajRadnike
            // 
            this.btnDodajRadnike.Location = new System.Drawing.Point(572, 157);
            this.btnDodajRadnike.Name = "btnDodajRadnike";
            this.btnDodajRadnike.Size = new System.Drawing.Size(151, 53);
            this.btnDodajRadnike.TabIndex = 16;
            this.btnDodajRadnike.Text = "Dodaj \r\nradnika";
            this.btnDodajRadnike.UseVisualStyleBackColor = true;
            this.btnDodajRadnike.Click += new System.EventHandler(this.btnDodajRadnike_Click);
            // 
            // btnPregledajRadnike
            // 
            this.btnPregledajRadnike.Location = new System.Drawing.Point(575, 247);
            this.btnPregledajRadnike.Name = "btnPregledajRadnike";
            this.btnPregledajRadnike.Size = new System.Drawing.Size(148, 50);
            this.btnPregledajRadnike.TabIndex = 17;
            this.btnPregledajRadnike.Text = "Pregledaj\r\nradnike";
            this.btnPregledajRadnike.UseVisualStyleBackColor = true;
            this.btnPregledajRadnike.Click += new System.EventHandler(this.btnPregledajRadnike_Click);
            // 
            // btnPregledajLet
            // 
            this.btnPregledajLet.Location = new System.Drawing.Point(575, 330);
            this.btnPregledajLet.Name = "btnPregledajLet";
            this.btnPregledajLet.Size = new System.Drawing.Size(148, 51);
            this.btnPregledajLet.TabIndex = 18;
            this.btnPregledajLet.Text = "Pregledaj putnike leta";
            this.btnPregledajLet.UseVisualStyleBackColor = true;
            this.btnPregledajLet.Click += new System.EventHandler(this.btnPregledajLet_Click);
            // 
            // Letovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 515);
            this.Controls.Add(this.btnPregledajLet);
            this.Controls.Add(this.btnPregledajRadnike);
            this.Controls.Add(this.btnDodajRadnike);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(768, 562);
            this.MinimumSize = new System.Drawing.Size(768, 562);
            this.Name = "Letovi";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Letovi";
            this.Load += new System.EventHandler(this.Letovi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader OD;
        private System.Windows.Forms.ColumnHeader DO;
        private System.Windows.Forms.ColumnHeader DATUM;
        private System.Windows.Forms.ColumnHeader VREME;
        private System.Windows.Forms.Button btnDodajRadnike;
        private System.Windows.Forms.Button btnPregledajRadnike;
        private System.Windows.Forms.Button btnPregledajLet;
    }
}

