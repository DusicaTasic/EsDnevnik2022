
namespace Osoba
{
    partial class Osoba
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
            this.btFirst = new System.Windows.Forms.Button();
            this.btPrev = new System.Windows.Forms.Button();
            this.btDodaj = new System.Windows.Forms.Button();
            this.btIzmeni = new System.Windows.Forms.Button();
            this.btObrisi = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.btLast = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.tbJMBG = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbLozinka = new System.Windows.Forms.TextBox();
            this.tbUloga = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btFirst
            // 
            this.btFirst.Location = new System.Drawing.Point(41, 348);
            this.btFirst.Name = "btFirst";
            this.btFirst.Size = new System.Drawing.Size(75, 23);
            this.btFirst.TabIndex = 0;
            this.btFirst.Text = "<<";
            this.btFirst.UseVisualStyleBackColor = true;
            this.btFirst.Click += new System.EventHandler(this.btFirst_Click);
            // 
            // btPrev
            // 
            this.btPrev.Location = new System.Drawing.Point(122, 348);
            this.btPrev.Name = "btPrev";
            this.btPrev.Size = new System.Drawing.Size(75, 23);
            this.btPrev.TabIndex = 1;
            this.btPrev.Text = "<";
            this.btPrev.UseVisualStyleBackColor = true;
            this.btPrev.Click += new System.EventHandler(this.btPrev_Click);
            // 
            // btDodaj
            // 
            this.btDodaj.Location = new System.Drawing.Point(203, 348);
            this.btDodaj.Name = "btDodaj";
            this.btDodaj.Size = new System.Drawing.Size(75, 23);
            this.btDodaj.TabIndex = 2;
            this.btDodaj.Text = "Dodaj";
            this.btDodaj.UseVisualStyleBackColor = true;
            this.btDodaj.Click += new System.EventHandler(this.btDodaj_Click);
            // 
            // btIzmeni
            // 
            this.btIzmeni.Location = new System.Drawing.Point(284, 348);
            this.btIzmeni.Name = "btIzmeni";
            this.btIzmeni.Size = new System.Drawing.Size(75, 23);
            this.btIzmeni.TabIndex = 3;
            this.btIzmeni.Text = "Izmeni";
            this.btIzmeni.UseVisualStyleBackColor = true;
            this.btIzmeni.Click += new System.EventHandler(this.btIzmeni_Click);
            // 
            // btObrisi
            // 
            this.btObrisi.Location = new System.Drawing.Point(365, 348);
            this.btObrisi.Name = "btObrisi";
            this.btObrisi.Size = new System.Drawing.Size(75, 23);
            this.btObrisi.TabIndex = 4;
            this.btObrisi.Text = "Orbisi";
            this.btObrisi.UseVisualStyleBackColor = true;
            this.btObrisi.Click += new System.EventHandler(this.btObrisi_Click);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(446, 348);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(75, 23);
            this.btNext.TabIndex = 5;
            this.btNext.Text = ">";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btLast
            // 
            this.btLast.Location = new System.Drawing.Point(527, 348);
            this.btLast.Name = "btLast";
            this.btLast.Size = new System.Drawing.Size(75, 23);
            this.btLast.TabIndex = 6;
            this.btLast.Text = ">>";
            this.btLast.UseVisualStyleBackColor = true;
            this.btLast.Click += new System.EventHandler(this.btLast_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prezime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Adresa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "JMBG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "E-mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(144, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Lozinka";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(144, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Uloga";
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Location = new System.Drawing.Point(203, 114);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(237, 20);
            this.tbID.TabIndex = 15;
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(203, 140);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(237, 20);
            this.tbIme.TabIndex = 16;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(203, 166);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(237, 20);
            this.tbPrezime.TabIndex = 17;
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(203, 192);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(237, 20);
            this.tbAdresa.TabIndex = 18;
            // 
            // tbJMBG
            // 
            this.tbJMBG.Location = new System.Drawing.Point(203, 218);
            this.tbJMBG.Name = "tbJMBG";
            this.tbJMBG.Size = new System.Drawing.Size(237, 20);
            this.tbJMBG.TabIndex = 19;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(203, 244);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(237, 20);
            this.tbEmail.TabIndex = 20;
            // 
            // tbLozinka
            // 
            this.tbLozinka.Location = new System.Drawing.Point(203, 270);
            this.tbLozinka.Name = "tbLozinka";
            this.tbLozinka.Size = new System.Drawing.Size(237, 20);
            this.tbLozinka.TabIndex = 21;
            // 
            // tbUloga
            // 
            this.tbUloga.Location = new System.Drawing.Point(203, 296);
            this.tbUloga.Name = "tbUloga";
            this.tbUloga.Size = new System.Drawing.Size(237, 20);
            this.tbUloga.TabIndex = 22;
            // 
            // Osoba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 450);
            this.Controls.Add(this.tbUloga);
            this.Controls.Add(this.tbLozinka);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbJMBG);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btLast);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btObrisi);
            this.Controls.Add(this.btIzmeni);
            this.Controls.Add(this.btDodaj);
            this.Controls.Add(this.btPrev);
            this.Controls.Add(this.btFirst);
            this.Name = "Osoba";
            this.Text = "Osoba";
            this.Load += new System.EventHandler(this.Osoba_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btFirst;
        private System.Windows.Forms.Button btPrev;
        private System.Windows.Forms.Button btDodaj;
        private System.Windows.Forms.Button btIzmeni;
        private System.Windows.Forms.Button btObrisi;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btLast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.TextBox tbJMBG;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbLozinka;
        private System.Windows.Forms.TextBox tbUloga;
    }
}

