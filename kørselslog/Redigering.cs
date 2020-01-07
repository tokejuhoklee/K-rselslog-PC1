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



namespace kørselslog
{
    public partial class Redigering : Form
    {
        String credentials = "server=TAK;Initial Catalog=kørsel;User ID=bruger;Password = stop;";
        String gammelMærke ;
        String gammelModel ;
        String gammelNummerplade ;
        String gammelKørteKm ;
        String gammelNavn;
        String gammelEfternavn;
        String gammelAktivitet;

        public Redigering()
        {
            InitializeComponent();
        }
        private void Redigering_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kørselDataSet.bil' table. You can move, or remove it, as needed.
            this.bilTableAdapter.Fill(this.kørselDataSet.bil);
            // TODO: This line of code loads data into the 'kørselDataSet.bruger' table. You can move, or remove it, as needed.
            this.brugerTableAdapter.Fill(this.kørselDataSet.bruger);
            try
            {
                // TODO: This line of code loads data into the 'kørselDataSet.bil' table. You can move, or remove it, as needed.
                this.bilTableAdapter.Fill(this.kørselDataSet.bil);
                // TODO: This line of code loads data into the 'kørselDataSet.bruger' table. You can move, or remove it, as needed.
                this.brugerTableAdapter.Fill(this.kørselDataSet.bruger);
               
                 gammelMærke = Convert.ToString(this.kørselDataSet.bil.Rows[bil.SelectedIndex]["mærke"]);
                 gammelModel = Convert.ToString(this.kørselDataSet.bil.Rows[bil.SelectedIndex]["model"]);
                 gammelNummerplade = Convert.ToString(this.kørselDataSet.bil.Rows[bil.SelectedIndex]["nummerplade"]);
                 gammelKørteKm = Convert.ToString(this.kørselDataSet.bil.Rows[bil.SelectedIndex]["kmKørt"]);
                 gammelNavn = Convert.ToString(this.kørselDataSet.bruger.Rows[Brugere.SelectedIndex]["fornavn"]);
                 gammelEfternavn =  Convert.ToString(this.kørselDataSet.bruger.Rows[Brugere.SelectedIndex]["efternavn"]);
            }
            catch (Exception es) { MessageBox.Show(es.Message); }
        }
        private void brugerValg(object sender, EventArgs e)
        {
            try
            {
                if (Brugere.SelectedIndex > 0)
                {
                    forNavnMenu.Text = "Navn:        " + Convert.ToString(this.kørselDataSet.bruger.Rows[Brugere.SelectedIndex]["fornavn"]);
                    efterNavnMenu.Text = "Efternavn: " + Convert.ToString(this.kørselDataSet.bruger.Rows[Brugere.SelectedIndex]["efternavn"]);
                    kørteKm.Text = "Kørte KM: " + Convert.ToString(this.kørselDataSet.bruger.Rows[Brugere.SelectedIndex]["kmKørt"]);
                    aktivBox.Checked = Convert.ToBoolean(this.kørselDataSet.bruger.Rows[Brugere.SelectedIndex]["aktiv"]);
                }
                if (Brugere.SelectedIndex == 0)
                {
                    forNavnMenu.Text = "Navn:        " + Convert.ToString(this.kørselDataSet.bruger.Rows[0]["fornavn"]);
                    efterNavnMenu.Text = "Efternavn: " + Convert.ToString(this.kørselDataSet.bruger.Rows[0]["efternavn"]);
                    kørteKm.Text = "Kørte KM: " + Convert.ToString(this.kørselDataSet.bruger.Rows[0]["kmKørt"]);
                    aktivBox.Checked = Convert.ToBoolean(this.kørselDataSet.bruger.Rows[0]["aktiv"]);
                }
            }
            catch (Exception es) { MessageBox.Show(es.Message); }
        }
        private void bilValg(object sender, EventArgs e)
        {
            try
            {
                if (bil.SelectedIndex > 0)
                {
                    bilfabrikantNavn.Text = "Mærke:              " + Convert.ToString(this.kørselDataSet.bil.Rows[bil.SelectedIndex]["mærke"]);
                    modelNavn.Text = "Model:                " + Convert.ToString(this.kørselDataSet.bil.Rows[bil.SelectedIndex]["model"]);
                    nummerpladeNavn.Text = "Nummerplade:    " + Convert.ToString(this.kørselDataSet.bil.Rows[bil.SelectedIndex]["nummerplade"]);
                    kmKørtBilLabel.Text = "Kilometer kørt:    " + Convert.ToString(this.kørselDataSet.bil.Rows[bil.SelectedIndex]["kmKørt"]);

                }
                if (bil.SelectedIndex == 0)
                {
                    bilfabrikantNavn.Text = "Mærke:              " + Convert.ToString(this.kørselDataSet.bil.Rows[0]["mærke"]);
                    modelNavn.Text = "Model:                " + Convert.ToString(this.kørselDataSet.bil.Rows[0]["model"]);
                    nummerpladeNavn.Text = "Nummerplade:    " + Convert.ToString(this.kørselDataSet.bil.Rows[0]["nummerplade"]);
                    kmKørtBilLabel.Text = "Kilometer kørt:    " + Convert.ToString(this.kørselDataSet.bil.Rows[0]["kmKørt"]);
                }
            }
            catch (Exception es) { MessageBox.Show(es.Message); }
        }
        private void godkendBruger_Click(object sender, EventArgs e)
        {
            string tilLog="";

            SqlConnection connect = new SqlConnection(credentials);
            SqlCommand fornavnEdit = new SqlCommand("UPDATE bruger SET fornavn= @value WHERE brugerNr = @brugervalg;", connect);
            SqlCommand efternavnEdit = new SqlCommand("UPDATE bruger SET efternavn = @value WHERE brugerNr = @brugervalg;", connect);
            fornavnEdit.Parameters.AddWithValue("@value", forNavnRedigering.Text);
            efternavnEdit.Parameters.AddWithValue("@value", redigeringEfternavn.Text);

            fornavnEdit.Parameters.AddWithValue("@brugervalg", Convert.ToInt32(Brugere.SelectedIndex + 1));
            efternavnEdit.Parameters.AddWithValue("@brugervalg", Convert.ToInt32(Brugere.SelectedIndex + 1));
            connect.Open();
            fornavnEdit.ExecuteNonQuery();
            efternavnEdit.ExecuteNonQuery();
            connect.Dispose();

            if (gammelNavn != forNavnRedigering.Text)
            {
                tilLog = tilLog + gammelNavn + ", er blevet redigeret til: " + forNavnRedigering.Text + ",  ";
            }
            if (gammelEfternavn != redigeringEfternavn.Text)
            {
                tilLog = tilLog + gammelEfternavn + ", er blevet redigeret til: " + redigeringEfternavn.Text + ",   ";
            }
            tilLog = tilLog + "på bruger nr:" + Convert.ToInt32(Brugere.SelectedIndex + 1);

         


            this.brugerTableAdapter.Fill(this.kørselDataSet.bruger);
            forNavnMenu.Text = "Navn:        " + Convert.ToString(this.kørselDataSet.bruger.Rows[Brugere.SelectedIndex]["fornavn"]);
            efterNavnMenu.Text = "Efternavn: " + Convert.ToString(this.kørselDataSet.bruger.Rows[Brugere.SelectedIndex]["efternavn"]);
            brugerValg(sender, e);
            log.nyLogRedigering(tilLog);
            this.DialogResult = DialogResult.No;

        }

        private void godkendBil_Click(object sender, EventArgs e)
        {
            string tilLog="";
            
            SqlConnection connect = new SqlConnection(credentials);
            SqlCommand nyMærke = new SqlCommand("UPDATE bil SET mærke = @value WHERE bilNr = @bilvalg;", connect);
            SqlCommand nyModel = new SqlCommand("UPDATE bil SET model = @value WHERE bilNr= @bilvalg;", connect);
            SqlCommand nyNummerplade = new SqlCommand("UPDATE bil SET nummerplade = @value WHERE bilNr= @bilvalg;", connect);
            SqlCommand nyKørteKm = new SqlCommand("UPDATE bil SET kmKørt = @value WHERE bilNr = @bilvalg;", connect);
            nyMærke.Parameters.AddWithValue("@value", redigeringMærke.Text);
            nyModel.Parameters.AddWithValue("@value", redigeringModel.Text);
            nyNummerplade.Parameters.AddWithValue("@value", redigeringNummerplade.Text);
            nyKørteKm.Parameters.AddWithValue("@value", redigeringKørteKm.Text);

            nyMærke.Parameters.AddWithValue("@bilvalg", Convert.ToInt32(bil.SelectedIndex + 1));
            nyModel.Parameters.AddWithValue("@bilvalg", Convert.ToInt32(bil.SelectedIndex + 1));
            nyNummerplade.Parameters.AddWithValue("@bilvalg", Convert.ToInt32(bil.SelectedIndex + 1));
            nyKørteKm.Parameters.AddWithValue("@bilvalg", Convert.ToInt32(bil.SelectedIndex + 1));
            connect.Open();
            nyMærke.ExecuteNonQuery();
            nyModel.ExecuteNonQuery();
            nyNummerplade.ExecuteNonQuery();
            nyKørteKm.ExecuteNonQuery();
            connect.Dispose();


                if (gammelMærke != redigeringMærke.Text)
                {
                    tilLog = tilLog + gammelMærke+", er blevet redigeret til: "+ redigeringMærke.Text+",    ";
                }
                if (gammelModel != redigeringModel.Text)
                {
                    tilLog = tilLog + gammelModel+", er blevet redigeret til: " + redigeringMærke.Text + ", ";
                }
                if (gammelNummerplade != redigeringNummerplade.Text)
                {
                    tilLog = tilLog + gammelNummerplade+", er blevet redigeret til: " + redigeringMærke.Text + ",   ";
                }
                if (gammelKørteKm != redigeringKørteKm.Text)
                {
                    tilLog = tilLog + gammelKørteKm+", er blevet redigeret til: " + redigeringMærke.Text + ",   ";
                }
            tilLog = tilLog + "på bil nr:" + Convert.ToInt32(bil.SelectedIndex + 1);


            this.bilTableAdapter.Fill(this.kørselDataSet.bil);
            bilValg(sender, e);
            log.nyLogRedigering(tilLog);
            this.DialogResult = DialogResult.No;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int check;
            if (aktivBox.Checked == true)
            {
                check = 1;
            }
            else check = 0;

            SqlConnection connect = new SqlConnection(credentials);
            SqlCommand aktivBruger = new SqlCommand("UPDATE bruger SET aktiv = @value WHERE brugerNr = @brugerValg;", connect);
            aktivBruger.Parameters.AddWithValue("@value", check);
            aktivBruger.Parameters.AddWithValue("@brugerValg", Convert.ToInt32(Brugere.SelectedIndex + 1));
            connect.Open();
            aktivBruger.ExecuteNonQuery();
            connect.Dispose();


        }
    }
}
