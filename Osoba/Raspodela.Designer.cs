
namespace Osoba
{
    partial class Raspodela
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
            this.cbGodina = new System.Windows.Forms.ComboBox();
            this.cbPredmet = new System.Windows.Forms.ComboBox();
            this.cbProfesor = new System.Windows.Forms.ComboBox();
            this.cbOdeljenje = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btFirst = new System.Windows.Forms.Button();
            this.btPrev = new System.Windows.Forms.Button();
            this.btDodaj = new System.Windows.Forms.Button();
            this.btIzmeni = new System.Windows.Forms.Button();
            this.btObrisi = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.btLast = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbGodina
            // 
            this.cbGodina.FormattingEnabled = true;
            this.cbGodina.Location = new System.Drawing.Point(296, 129);
            this.cbGodina.Name = "cbGodina";
            this.cbGodina.Size = new System.Drawing.Size(209, 21);
            this.cbGodina.TabIndex = 1;
            // 
            // cbPredmet
            // 
            this.cbPredmet.FormattingEnabled = true;
            this.cbPredmet.Location = new System.Drawing.Point(296, 237);
            this.cbPredmet.Name = "cbPredmet";
            this.cbPredmet.Size = new System.Drawing.Size(209, 21);
            this.cbPredmet.TabIndex = 3;
            // 
            // cbProfesor
            // 
            this.cbProfesor.FormattingEnabled = true;
            this.cbProfesor.Location = new System.Drawing.Point(296, 183);
            this.cbProfesor.Name = "cbProfesor";
            this.cbProfesor.Size = new System.Drawing.Size(209, 21);
            this.cbProfesor.TabIndex = 4;
            // 
            // cbOdeljenje
            // 
            this.cbOdeljenje.FormattingEnabled = true;
            this.cbOdeljenje.Location = new System.Drawing.Point(296, 291);
            this.cbOdeljenje.Name = "cbOdeljenje";
            this.cbOdeljenje.Size = new System.Drawing.Size(209, 21);
            this.cbOdeljenje.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Godina:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Profesor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Predmet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Odeljenje:";
            // 
            // btFirst
            // 
            this.btFirst.Location = new System.Drawing.Point(65, 362);
            this.btFirst.Name = "btFirst";
            this.btFirst.Size = new System.Drawing.Size(75, 28);
            this.btFirst.TabIndex = 11;
            this.btFirst.Text = "<<";
            this.btFirst.UseVisualStyleBackColor = true;
            this.btFirst.Click += new System.EventHandler(this.btFirst_Click);
            // 
            // btPrev
            // 
            this.btPrev.Location = new System.Drawing.Point(164, 362);
            this.btPrev.Name = "btPrev";
            this.btPrev.Size = new System.Drawing.Size(75, 28);
            this.btPrev.TabIndex = 12;
            this.btPrev.Text = "<";
            this.btPrev.UseVisualStyleBackColor = true;
            this.btPrev.Click += new System.EventHandler(this.btPrev_Click);
            // 
            // btDodaj
            // 
            this.btDodaj.Location = new System.Drawing.Point(263, 362);
            this.btDodaj.Name = "btDodaj";
            this.btDodaj.Size = new System.Drawing.Size(75, 28);
            this.btDodaj.TabIndex = 13;
            this.btDodaj.Text = "Dodaj";
            this.btDodaj.UseVisualStyleBackColor = true;
            this.btDodaj.Click += new System.EventHandler(this.btDodaj_Click);
            // 
            // btIzmeni
            // 
            this.btIzmeni.Location = new System.Drawing.Point(362, 362);
            this.btIzmeni.Name = "btIzmeni";
            this.btIzmeni.Size = new System.Drawing.Size(75, 28);
            this.btIzmeni.TabIndex = 14;
            this.btIzmeni.Text = "Izmeni";
            this.btIzmeni.UseVisualStyleBackColor = true;
            this.btIzmeni.Click += new System.EventHandler(this.btIzmeni_Click);
            // 
            // btObrisi
            // 
            this.btObrisi.Location = new System.Drawing.Point(461, 362);
            this.btObrisi.Name = "btObrisi";
            this.btObrisi.Size = new System.Drawing.Size(75, 28);
            this.btObrisi.TabIndex = 15;
            this.btObrisi.Text = "Obrisi";
            this.btObrisi.UseVisualStyleBackColor = true;
            this.btObrisi.Click += new System.EventHandler(this.btObrisi_Click);
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(560, 362);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(75, 28);
            this.btNext.TabIndex = 16;
            this.btNext.Text = ">";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btLast
            // 
            this.btLast.Location = new System.Drawing.Point(659, 362);
            this.btLast.Name = "btLast";
            this.btLast.Size = new System.Drawing.Size(75, 28);
            this.btLast.TabIndex = 17;
            this.btLast.Text = ">>";
            this.btLast.UseVisualStyleBackColor = true;
            this.btLast.Click += new System.EventHandler(this.btLast_Click);
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Location = new System.Drawing.Point(296, 75);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(209, 20);
            this.tbID.TabIndex = 18;
            // 
            // Raspodela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.btLast);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btObrisi);
            this.Controls.Add(this.btIzmeni);
            this.Controls.Add(this.btDodaj);
            this.Controls.Add(this.btPrev);
            this.Controls.Add(this.btFirst);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbOdeljenje);
            this.Controls.Add(this.cbProfesor);
            this.Controls.Add(this.cbPredmet);
            this.Controls.Add(this.cbGodina);
            this.Name = "Raspodela";
            this.Text = "Raspodela";
            this.Load += new System.EventHandler(this.Raspodela_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbGodina;
        private System.Windows.Forms.ComboBox cbPredmet;
        private System.Windows.Forms.ComboBox cbProfesor;
        private System.Windows.Forms.ComboBox cbOdeljenje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btFirst;
        private System.Windows.Forms.Button btPrev;
        private System.Windows.Forms.Button btDodaj;
        private System.Windows.Forms.Button btIzmeni;
        private System.Windows.Forms.Button btObrisi;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btLast;
        private System.Windows.Forms.TextBox tbID;
    }
}