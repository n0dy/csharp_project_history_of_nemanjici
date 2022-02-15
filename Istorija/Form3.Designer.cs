namespace Istorija
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lblKviz = new System.Windows.Forms.Label();
            this.lblNazad = new System.Windows.Forms.Label();
            this.lblPitanje = new System.Windows.Forms.Label();
            this.lblOdg1 = new System.Windows.Forms.Label();
            this.lblOdg2 = new System.Windows.Forms.Label();
            this.lblOdg3 = new System.Windows.Forms.Label();
            this.lblOdg4 = new System.Windows.Forms.Label();
            this.pBoxIzlaz = new System.Windows.Forms.PictureBox();
            this.pBoxDoleOkvir = new System.Windows.Forms.PictureBox();
            this.pBoxLevoOkvir = new System.Windows.Forms.PictureBox();
            this.pBoxDesniOkvir = new System.Windows.Forms.PictureBox();
            this.pBoxGoreOkvir = new System.Windows.Forms.PictureBox();
            this.lblRezultati = new System.Windows.Forms.Label();
            this.timerPitanja = new System.Windows.Forms.Timer(this.components);
            this.lblInfo = new System.Windows.Forms.Label();
            this.timerBrojac = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxIzlaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDoleOkvir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLevoOkvir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDesniOkvir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGoreOkvir)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKviz
            // 
            this.lblKviz.BackColor = System.Drawing.Color.Gray;
            this.lblKviz.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKviz.ForeColor = System.Drawing.Color.White;
            this.lblKviz.Location = new System.Drawing.Point(0, 3);
            this.lblKviz.Name = "lblKviz";
            this.lblKviz.Size = new System.Drawing.Size(217, 25);
            this.lblKviz.TabIndex = 14;
            this.lblKviz.Text = "Kviz";
            this.lblKviz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNazad
            // 
            this.lblNazad.BackColor = System.Drawing.Color.Maroon;
            this.lblNazad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNazad.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazad.ForeColor = System.Drawing.Color.White;
            this.lblNazad.Location = new System.Drawing.Point(342, 3);
            this.lblNazad.Name = "lblNazad";
            this.lblNazad.Size = new System.Drawing.Size(113, 24);
            this.lblNazad.TabIndex = 31;
            this.lblNazad.Text = "Nazad";
            this.lblNazad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNazad.Click += new System.EventHandler(this.lblNazad_Click);
            // 
            // lblPitanje
            // 
            this.lblPitanje.BackColor = System.Drawing.Color.Maroon;
            this.lblPitanje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPitanje.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPitanje.ForeColor = System.Drawing.Color.White;
            this.lblPitanje.Location = new System.Drawing.Point(51, 70);
            this.lblPitanje.Name = "lblPitanje";
            this.lblPitanje.Size = new System.Drawing.Size(400, 100);
            this.lblPitanje.TabIndex = 32;
            this.lblPitanje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOdg1
            // 
            this.lblOdg1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOdg1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOdg1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdg1.ForeColor = System.Drawing.Color.White;
            this.lblOdg1.Location = new System.Drawing.Point(55, 234);
            this.lblOdg1.Name = "lblOdg1";
            this.lblOdg1.Size = new System.Drawing.Size(180, 50);
            this.lblOdg1.TabIndex = 33;
            this.lblOdg1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOdg1.Click += new System.EventHandler(this.lblOdg1_Click);
            // 
            // lblOdg2
            // 
            this.lblOdg2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOdg2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOdg2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdg2.ForeColor = System.Drawing.Color.White;
            this.lblOdg2.Location = new System.Drawing.Point(271, 234);
            this.lblOdg2.Name = "lblOdg2";
            this.lblOdg2.Size = new System.Drawing.Size(180, 50);
            this.lblOdg2.TabIndex = 34;
            this.lblOdg2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOdg2.Click += new System.EventHandler(this.lblOdg2_Click);
            // 
            // lblOdg3
            // 
            this.lblOdg3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOdg3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOdg3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdg3.ForeColor = System.Drawing.Color.White;
            this.lblOdg3.Location = new System.Drawing.Point(55, 305);
            this.lblOdg3.Name = "lblOdg3";
            this.lblOdg3.Size = new System.Drawing.Size(180, 50);
            this.lblOdg3.TabIndex = 35;
            this.lblOdg3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOdg3.Click += new System.EventHandler(this.lblOdg3_Click);
            // 
            // lblOdg4
            // 
            this.lblOdg4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOdg4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOdg4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOdg4.ForeColor = System.Drawing.Color.White;
            this.lblOdg4.Location = new System.Drawing.Point(271, 305);
            this.lblOdg4.Name = "lblOdg4";
            this.lblOdg4.Size = new System.Drawing.Size(180, 50);
            this.lblOdg4.TabIndex = 36;
            this.lblOdg4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOdg4.Click += new System.EventHandler(this.lblOdg4_Click);
            // 
            // pBoxIzlaz
            // 
            this.pBoxIzlaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pBoxIzlaz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBoxIzlaz.Location = new System.Drawing.Point(461, 3);
            this.pBoxIzlaz.Name = "pBoxIzlaz";
            this.pBoxIzlaz.Size = new System.Drawing.Size(24, 24);
            this.pBoxIzlaz.TabIndex = 15;
            this.pBoxIzlaz.TabStop = false;
            this.pBoxIzlaz.Click += new System.EventHandler(this.pBoxIzlaz_Click);
            // 
            // pBoxDoleOkvir
            // 
            this.pBoxDoleOkvir.BackColor = System.Drawing.Color.Gray;
            this.pBoxDoleOkvir.Location = new System.Drawing.Point(0, 485);
            this.pBoxDoleOkvir.Name = "pBoxDoleOkvir";
            this.pBoxDoleOkvir.Size = new System.Drawing.Size(500, 15);
            this.pBoxDoleOkvir.TabIndex = 13;
            this.pBoxDoleOkvir.TabStop = false;
            // 
            // pBoxLevoOkvir
            // 
            this.pBoxLevoOkvir.BackColor = System.Drawing.Color.Gray;
            this.pBoxLevoOkvir.Location = new System.Drawing.Point(0, 0);
            this.pBoxLevoOkvir.Name = "pBoxLevoOkvir";
            this.pBoxLevoOkvir.Size = new System.Drawing.Size(15, 500);
            this.pBoxLevoOkvir.TabIndex = 12;
            this.pBoxLevoOkvir.TabStop = false;
            // 
            // pBoxDesniOkvir
            // 
            this.pBoxDesniOkvir.BackColor = System.Drawing.Color.Gray;
            this.pBoxDesniOkvir.Location = new System.Drawing.Point(485, 0);
            this.pBoxDesniOkvir.Name = "pBoxDesniOkvir";
            this.pBoxDesniOkvir.Size = new System.Drawing.Size(15, 500);
            this.pBoxDesniOkvir.TabIndex = 11;
            this.pBoxDesniOkvir.TabStop = false;
            // 
            // pBoxGoreOkvir
            // 
            this.pBoxGoreOkvir.BackColor = System.Drawing.Color.Gray;
            this.pBoxGoreOkvir.Location = new System.Drawing.Point(0, 0);
            this.pBoxGoreOkvir.Name = "pBoxGoreOkvir";
            this.pBoxGoreOkvir.Size = new System.Drawing.Size(500, 30);
            this.pBoxGoreOkvir.TabIndex = 10;
            this.pBoxGoreOkvir.TabStop = false;
            // 
            // lblRezultati
            // 
            this.lblRezultati.BackColor = System.Drawing.Color.Maroon;
            this.lblRezultati.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRezultati.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRezultati.ForeColor = System.Drawing.Color.White;
            this.lblRezultati.Location = new System.Drawing.Point(51, 422);
            this.lblRezultati.Name = "lblRezultati";
            this.lblRezultati.Size = new System.Drawing.Size(400, 36);
            this.lblRezultati.TabIndex = 37;
            this.lblRezultati.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerPitanja
            // 
            this.timerPitanja.Enabled = true;
            this.timerPitanja.Interval = 10000;
            this.timerPitanja.Tick += new System.EventHandler(this.timerPitanja_Tick);
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblInfo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Red;
            this.lblInfo.Location = new System.Drawing.Point(166, 33);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(180, 37);
            this.lblInfo.TabIndex = 38;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerBrojac
            // 
            this.timerBrojac.Enabled = true;
            this.timerBrojac.Interval = 1000;
            this.timerBrojac.Tick += new System.EventHandler(this.timerBrojac_Tick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblRezultati);
            this.Controls.Add(this.lblOdg4);
            this.Controls.Add(this.lblOdg3);
            this.Controls.Add(this.lblOdg2);
            this.Controls.Add(this.lblOdg1);
            this.Controls.Add(this.lblPitanje);
            this.Controls.Add(this.lblNazad);
            this.Controls.Add(this.pBoxIzlaz);
            this.Controls.Add(this.lblKviz);
            this.Controls.Add(this.pBoxDoleOkvir);
            this.Controls.Add(this.pBoxLevoOkvir);
            this.Controls.Add(this.pBoxDesniOkvir);
            this.Controls.Add(this.pBoxGoreOkvir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nemanjići";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxIzlaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDoleOkvir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxLevoOkvir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxDesniOkvir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGoreOkvir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxGoreOkvir;
        private System.Windows.Forms.PictureBox pBoxDesniOkvir;
        private System.Windows.Forms.PictureBox pBoxLevoOkvir;
        private System.Windows.Forms.PictureBox pBoxDoleOkvir;
        private System.Windows.Forms.Label lblKviz;
        private System.Windows.Forms.PictureBox pBoxIzlaz;
        private System.Windows.Forms.Label lblNazad;
        private System.Windows.Forms.Label lblPitanje;
        private System.Windows.Forms.Label lblOdg1;
        private System.Windows.Forms.Label lblOdg2;
        private System.Windows.Forms.Label lblOdg3;
        private System.Windows.Forms.Label lblOdg4;
        private System.Windows.Forms.Label lblRezultati;
        private System.Windows.Forms.Timer timerPitanja;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Timer timerBrojac;
    }
}