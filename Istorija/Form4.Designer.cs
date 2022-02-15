namespace Istorija
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.pBoxGoreOkvir = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pBoxIzlaz = new System.Windows.Forms.PictureBox();
            this.lblAdminPanel = new System.Windows.Forms.Label();
            this.rBoxPitanja = new System.Windows.Forms.RichTextBox();
            this.lblSacuvajPitanja = new System.Windows.Forms.Label();
            this.lblNazad = new System.Windows.Forms.Label();
            this.lblUpustvo = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGoreOkvir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxIzlaz)).BeginInit();
            this.SuspendLayout();
            // 
            // pBoxGoreOkvir
            // 
            this.pBoxGoreOkvir.BackColor = System.Drawing.Color.Gray;
            this.pBoxGoreOkvir.Location = new System.Drawing.Point(0, 0);
            this.pBoxGoreOkvir.Name = "pBoxGoreOkvir";
            this.pBoxGoreOkvir.Size = new System.Drawing.Size(600, 30);
            this.pBoxGoreOkvir.TabIndex = 3;
            this.pBoxGoreOkvir.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Location = new System.Drawing.Point(0, 485);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 15);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gray;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 500);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Gray;
            this.pictureBox3.Location = new System.Drawing.Point(585, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(15, 500);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pBoxIzlaz
            // 
            this.pBoxIzlaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pBoxIzlaz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBoxIzlaz.Location = new System.Drawing.Point(561, 3);
            this.pBoxIzlaz.Name = "pBoxIzlaz";
            this.pBoxIzlaz.Size = new System.Drawing.Size(24, 24);
            this.pBoxIzlaz.TabIndex = 7;
            this.pBoxIzlaz.TabStop = false;
            this.pBoxIzlaz.Click += new System.EventHandler(this.pBoxIzlaz_Click);
            // 
            // lblAdminPanel
            // 
            this.lblAdminPanel.BackColor = System.Drawing.Color.Gray;
            this.lblAdminPanel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminPanel.ForeColor = System.Drawing.Color.White;
            this.lblAdminPanel.Location = new System.Drawing.Point(0, 3);
            this.lblAdminPanel.Name = "lblAdminPanel";
            this.lblAdminPanel.Size = new System.Drawing.Size(217, 25);
            this.lblAdminPanel.TabIndex = 8;
            this.lblAdminPanel.Text = "Admin Panel";
            this.lblAdminPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rBoxPitanja
            // 
            this.rBoxPitanja.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.rBoxPitanja.Location = new System.Drawing.Point(21, 115);
            this.rBoxPitanja.Name = "rBoxPitanja";
            this.rBoxPitanja.Size = new System.Drawing.Size(558, 364);
            this.rBoxPitanja.TabIndex = 14;
            this.rBoxPitanja.Text = "";
            // 
            // lblSacuvajPitanja
            // 
            this.lblSacuvajPitanja.BackColor = System.Drawing.Color.Maroon;
            this.lblSacuvajPitanja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSacuvajPitanja.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSacuvajPitanja.ForeColor = System.Drawing.Color.White;
            this.lblSacuvajPitanja.Location = new System.Drawing.Point(21, 70);
            this.lblSacuvajPitanja.Name = "lblSacuvajPitanja";
            this.lblSacuvajPitanja.Size = new System.Drawing.Size(139, 42);
            this.lblSacuvajPitanja.TabIndex = 15;
            this.lblSacuvajPitanja.Text = "Sacuvaj pitanja";
            this.lblSacuvajPitanja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSacuvajPitanja.Click += new System.EventHandler(this.lblSacuvajPitanja_Click);
            // 
            // lblNazad
            // 
            this.lblNazad.BackColor = System.Drawing.Color.Maroon;
            this.lblNazad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNazad.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazad.ForeColor = System.Drawing.Color.White;
            this.lblNazad.Location = new System.Drawing.Point(442, 3);
            this.lblNazad.Name = "lblNazad";
            this.lblNazad.Size = new System.Drawing.Size(113, 24);
            this.lblNazad.TabIndex = 32;
            this.lblNazad.Text = "Nazad";
            this.lblNazad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNazad.Click += new System.EventHandler(this.lblNazad_Click);
            // 
            // lblUpustvo
            // 
            this.lblUpustvo.BackColor = System.Drawing.Color.Maroon;
            this.lblUpustvo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUpustvo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpustvo.ForeColor = System.Drawing.Color.White;
            this.lblUpustvo.Location = new System.Drawing.Point(166, 70);
            this.lblUpustvo.Name = "lblUpustvo";
            this.lblUpustvo.Size = new System.Drawing.Size(139, 42);
            this.lblUpustvo.TabIndex = 33;
            this.lblUpustvo.Text = "Upustvo";
            this.lblUpustvo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUpustvo.Click += new System.EventHandler(this.lblUpustvo_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInfo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblInfo.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(311, 33);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(268, 79);
            this.lblInfo.TabIndex = 35;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblUpustvo);
            this.Controls.Add(this.lblNazad);
            this.Controls.Add(this.lblSacuvajPitanja);
            this.Controls.Add(this.rBoxPitanja);
            this.Controls.Add(this.lblAdminPanel);
            this.Controls.Add(this.pBoxIzlaz);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pBoxGoreOkvir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nemanjići";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGoreOkvir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxIzlaz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxGoreOkvir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pBoxIzlaz;
        private System.Windows.Forms.Label lblAdminPanel;
        private System.Windows.Forms.RichTextBox rBoxPitanja;
        private System.Windows.Forms.Label lblSacuvajPitanja;
        private System.Windows.Forms.Label lblNazad;
        private System.Windows.Forms.Label lblUpustvo;
        private System.Windows.Forms.Label lblInfo;
    }
}