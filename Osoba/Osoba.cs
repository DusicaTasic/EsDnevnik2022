using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Osoba
{
    public partial class Osoba : Form
    {
        int BrojSloga = 0;
        DataTable tabela;

        public Osoba()
        {
            InitializeComponent();
        }

        private void Data_Load()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM osoba", veza);
            tabela = new DataTable();
            adapter.Fill(tabela);
        }

        private void TxtLoad()
        {
            if (tabela.Rows.Count == 0)
            {
                tbID.Text = "";
                tbIme.Text = "";
                tbPrezime.Text = "";
                tbAdresa.Text = "";
                tbJMBG.Text = "";
                tbEmail.Text = "";
                tbLozinka.Text = "";
                tbUloga.Text = "";
                btObrisi.Enabled = false;
            }
            else
            {
                tbID.Text = tabela.Rows[BrojSloga]["id"].ToString();
                tbIme.Text = tabela.Rows[BrojSloga]["ime"].ToString();
                tbPrezime.Text = tabela.Rows[BrojSloga]["prezime"].ToString();
                tbAdresa.Text = tabela.Rows[BrojSloga]["adresa"].ToString();
                tbJMBG.Text = tabela.Rows[BrojSloga]["jmbg"].ToString();
                tbEmail.Text = tabela.Rows[BrojSloga]["email"].ToString();
                tbLozinka.Text = tabela.Rows[BrojSloga]["pass"].ToString();
                tbUloga.Text = tabela.Rows[BrojSloga]["uloga"].ToString();
                btObrisi.Enabled = true;
            }    
            if (BrojSloga == 0)
            {
                btPrev.Enabled = false;
                btFirst.Enabled = false;
            }
            else
            {
                btPrev.Enabled = true;
                btFirst.Enabled = true;
            }
            if (BrojSloga == tabela.Rows.Count - 1)
            {
                btNext.Enabled = false;
                btLast.Enabled = false;
            }
            else
            {
                btNext.Enabled = true;
                btLast.Enabled = true;
            }
        }

        private void Osoba_Load(object sender, EventArgs e)
        {
            Data_Load();
            TxtLoad();
        }

        private void btFirst_Click(object sender, EventArgs e)
        {
            BrojSloga = 0;
            TxtLoad();
        }

        private void btPrev_Click(object sender, EventArgs e)
        {
            BrojSloga--;
            TxtLoad();
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            BrojSloga++;
            TxtLoad();
        }

        private void btLast_Click(object sender, EventArgs e)
        {
            BrojSloga = tabela.Rows.Count - 1;
            TxtLoad();
        }

        private void btDodaj_Click(object sender, EventArgs e)
        {
            StringBuilder Naredba = new StringBuilder("INSERT INTO osoba (ime, prezime, adresa, jmbg, email, pass, uloga) VALUES('");
            Naredba.Append(tbIme.Text + "', '");
            Naredba.Append(tbPrezime.Text + "', '");
            Naredba.Append(tbAdresa.Text + "', '");
            Naredba.Append(tbJMBG.Text + "', '");
            Naredba.Append(tbEmail.Text + "', '");
            Naredba.Append(tbLozinka.Text + "', '");
            Naredba.Append(tbUloga.Text + "')");
            SqlConnection veza = Konekcija.Connect();
            SqlCommand Komanda = new SqlCommand(Naredba.ToString(), veza);
            try
            {
                veza.Open();
                Komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }
            Data_Load();
            BrojSloga = tabela.Rows.Count - 1;
            TxtLoad();
        }

        private void btIzmeni_Click(object sender, EventArgs e)
        {
            StringBuilder Naredba = new StringBuilder("UPDATE osoba SET");
            Naredba.Append("ime = '" + tbIme.Text + "', ");
            Naredba.Append("prezime = '" + tbPrezime.Text + "', ");
            Naredba.Append("adresa = '" + tbAdresa.Text + "', ");
            Naredba.Append("jmbg = '" + tbJMBG.Text + "', ");
            Naredba.Append("email = '" + tbEmail.Text + "', ");
            Naredba.Append("pass = '" + tbLozinka.Text + "', ");
            Naredba.Append("uloga = '" + tbUloga.Text + "' ");
            Naredba.Append("WHERE id = " + tbID.Text);
            SqlConnection veza = Konekcija.Connect();
            SqlCommand Komanda = new SqlCommand(Naredba.ToString(), veza);
            try
            {
                veza.Open();
                Komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }
            Data_Load();
            TxtLoad();
        }

        private void btObrisi_Click(object sender, EventArgs e)
        {
            string Naredba = "DELETE FROM osoba WHERE id = " + tbID.Text;
            SqlConnection veza = Konekcija.Connect();
            SqlCommand Komanda = new SqlCommand(Naredba.ToString(), veza);
            Boolean Brisano = false;
            try
            {
                veza.Open();
                Komanda.ExecuteNonQuery();
                veza.Close();
                Brisano = true;
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }
            if (Brisano)
            {
                Data_Load();
                if (BrojSloga > 0) BrojSloga--;
                TxtLoad();
            }
            
        }
    }
}
