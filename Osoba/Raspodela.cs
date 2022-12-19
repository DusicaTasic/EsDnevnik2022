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
    public partial class Raspodela : Form
    {
        DataTable raspodela;
        int BrojSloga = 0;

        public Raspodela()
        {
            InitializeComponent();
        }        

        private void Data_Load()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM raspodela", veza);
            raspodela = new DataTable();
            adapter.Fill(raspodela);
        }

        private void Raspodela_Load(object sender, EventArgs e)
        {
            Data_Load();
            ComboFill();
        }

        private void ComboFill()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter;
            DataTable dtGodina, dtNastavnik, dtPredmet, dtOdeljenje;

            adapter = new SqlDataAdapter("SELECT * FROM skolska_godina", veza);
            dtGodina = new DataTable();
            adapter.Fill(dtGodina);

            dtNastavnik = new DataTable();
            adapter = new SqlDataAdapter("SELECT id, ime + ' ' + prezime as naziv from osoba WHERE uloga = 2", veza);
            adapter.Fill(dtNastavnik);

            dtPredmet = new DataTable();
            adapter = new SqlDataAdapter("SELECT id, naziv FROM predmet", veza);
            adapter.Fill(dtPredmet);

            dtOdeljenje = new DataTable();
            adapter = new SqlDataAdapter("SELECT id, STR(razred) + '-' + indeks as naziv FROM odeljenje", veza);
            adapter.Fill(dtOdeljenje);

            cbGodina.DataSource = dtGodina;
            cbGodina.ValueMember = "id";
            cbGodina.DisplayMember = "naziv";

            cbProfesor.DataSource = dtNastavnik;
            cbProfesor.ValueMember = "id";
            cbProfesor.DisplayMember = "naziv";

            cbPredmet.DataSource = dtPredmet;
            cbPredmet.ValueMember = "id";
            cbPredmet.DisplayMember = "naziv";

            cbOdeljenje.DataSource = dtOdeljenje;
            cbOdeljenje.ValueMember = "id";
            cbOdeljenje.DisplayMember = "naziv";

            if (raspodela.Rows.Count == 0)
            {
                tbID.Text = "";
                cbGodina.SelectedValue = "";
                cbProfesor.SelectedValue = "";
                cbPredmet.SelectedValue = "";
                cbOdeljenje.SelectedValue = "";
            }
            else
            {
                tbID.Text = raspodela.Rows[BrojSloga]["id"].ToString();
                cbGodina.SelectedValue = raspodela.Rows[BrojSloga]["godina_id"];
                cbProfesor.SelectedValue = raspodela.Rows[BrojSloga]["nastavnik_id"];
                cbPredmet.SelectedValue = raspodela.Rows[BrojSloga]["predmet_id"];
                cbOdeljenje.SelectedValue = raspodela.Rows[BrojSloga]["odeljenje_id"];
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
            if (BrojSloga == raspodela.Rows.Count - 1)
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
        private void btFirst_Click(object sender, EventArgs e)
        {
            BrojSloga = 0;
            ComboFill();
        }

        private void btPrev_Click(object sender, EventArgs e)
        {
            BrojSloga--;
            ComboFill();
        }
        private void btNext_Click(object sender, EventArgs e)
        {
            BrojSloga++;
            ComboFill();
        }

        private void btLast_Click(object sender, EventArgs e)
        {
            BrojSloga = raspodela.Rows.Count - 1;
            ComboFill();
        }

        private void btObrisi_Click(object sender, EventArgs e)
        {
            string Naredba = "DELETE FROM raspodela WHERE id = " + tbID.Text;
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
                ComboFill();
            }
        }

        private void btDodaj_Click(object sender, EventArgs e)
        {
            StringBuilder Naredba = new StringBuilder("INSERT INTO raspodela (godina_id, nastavnik_id, predmet_id, odeljenje_id) VALUES('");
            Naredba.Append(cbGodina.SelectedValue + "', '");
            Naredba.Append(cbProfesor.SelectedValue + "', '");
            Naredba.Append(cbPredmet.SelectedValue + "', '");
            Naredba.Append(cbOdeljenje.SelectedValue + "')");
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
            BrojSloga = raspodela.Rows.Count - 1;
            ComboFill();
        }

        private void btIzmeni_Click(object sender, EventArgs e)
        {
            StringBuilder Naredba = new StringBuilder("UPDATE raspodela SET ");
            Naredba.Append("godina_id = '" + cbGodina.SelectedValue + "', ");
            Naredba.Append("nastavnik_id = '" + cbProfesor.SelectedValue + "', ");
            Naredba.Append("predmet_id = '" + cbPredmet.SelectedValue + "', ");
            Naredba.Append("odeljenje_id = '" + cbOdeljenje.SelectedValue + "' ");
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
            ComboFill();
        }
    }
}
