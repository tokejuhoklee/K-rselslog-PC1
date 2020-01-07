using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace kørselslog
{
    public partial class hovedmenu : Form
    {
        String credentials = "server=TAK;Initial Catalog=kørsel;User ID=bruger;Password = stop;";
        public hovedmenu()
        {
            InitializeComponent();

        }
        public void hovedmenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kørselDataSet2.bruger' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'kørselDataSet2.bil' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'kørselDataSet.bil' table. You can move, or remove it, as needed.
            // this.bilTableAdapter.Fill(this.kørselDataSet.bil);
            // TODO: This line of code loads data into the 'kørselDataSet1.bruger' table. You can move, or remove it, as needed.
            //   this.brugerTableAdapter.Fill(this.kørselDataSet.bruger);

            try
            {
                this.bilTableAdapter.Fill(this.kørselDataSet.bil);
                this.brugerTableAdapter.Fill(this.kørselDataSet.bruger);

            }
            catch (Exception es) { MessageBox.Show(es.Message); }
        }
        private void brugerValg(object sender, EventArgs e)
        {
            try
            {

                if (Convert.ToInt32(Brugere.SelectedValue) > 0)
                {
                    forNavnMenu.Text = "Navn:        " + Convert.ToString(this.kørselDataSet.bruger.Rows[Convert.ToInt32(Brugere.SelectedValue)-1]["fornavn"]);
                    efterNavnMenu.Text = "Efternavn: " + Convert.ToString(this.kørselDataSet.bruger.Rows[Convert.ToInt32(Brugere.SelectedValue)-1]["efternavn"]);
                    kørteKm.Text = "Kørte KM: " + Convert.ToString(this.kørselDataSet.bruger.Rows[Convert.ToInt32(Brugere.SelectedValue)-1]["kmKørt"]);
                }
                if (Convert.ToInt32(Brugere.SelectedValue) == 0)
                {
                    forNavnMenu.Text = "Navn:        " + Convert.ToString(this.kørselDataSet.bruger.Rows[0]["fornavn"]);
                    efterNavnMenu.Text = "Efternavn: " + Convert.ToString(this.kørselDataSet.bruger.Rows[0]["efternavn"]);
                    kørteKm.Text = "Kørte KM: " + Convert.ToString(this.kørselDataSet.bruger.Rows[0]["kmKørt"]);
                }
            }
            catch (Exception es) { MessageBox.Show(es.Message+1); }
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
            catch (Exception es) { MessageBox.Show(es.Message+2); }
        }

        private void redigering_Click(object sender, EventArgs e)
        {
            using (var form = new Redigering())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.No)
                {
                    hovedmenu_Load(sender, e);
                }
            }
        }

        private void ny_bil_Click(object sender, EventArgs e)
        {

            string fornavn = "tom";
            string efternavn = "tom";
            string model;
            string fabrikant;
            string nummerplade;
            using (var form = new indtastBruger())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    fornavn = form.forNavnIndtast;
                    efternavn = form.efterNavnIndtast;

                    SqlConnection connect = new SqlConnection(credentials);
                    SqlCommand cmd = new SqlCommand("INSERT INTO bruger (fornavn,efternavn,kmKørt,aktiv) VALUES (@fornavn, @efternavn,@kmKørt,(1))", connect);
                    cmd.Parameters.AddWithValue("@fornavn", fornavn);
                    cmd.Parameters.AddWithValue("@efternavn", efternavn);
                    cmd.Parameters.AddWithValue("@kmKørt", 0);

                    connect.Open();
                    cmd.ExecuteNonQuery();
                    this.brugerTableAdapter.Fill(this.kørselDataSet.bruger);
                    connect.Dispose();
                    log.nyLogBrugerOpret(fornavn + ' ' + efternavn);
                }
                if (result == DialogResult.No)
                {
                    model = form.bilModel;
                    fabrikant = form.fabrikant;
                    nummerplade = form.nummerplade;

                    SqlConnection connect = new SqlConnection(credentials);
                    SqlCommand cmd = new SqlCommand("INSERT INTO bil (model, nummerplade, mærke) VALUES (@model, @nummerplade, @mærke)", connect);
                    cmd.Parameters.AddWithValue("@model", model);
                    cmd.Parameters.AddWithValue("@mærke", fabrikant);
                    cmd.Parameters.AddWithValue("@nummerplade", nummerplade);

                    connect.Open();
                    cmd.ExecuteNonQuery();
                    this.bilTableAdapter.Fill(this.kørselDataSet.bil);
                    connect.Dispose();
                    log.nyLogBilOpret(nummerplade+' '+ fabrikant+ ' ' + model);
                    
                }
            }
        }

        private void KM_input_Click(object sender, EventArgs e)
        {

            int insertBruger = Convert.ToInt32(this.kørselDataSet.bruger.Rows[Brugere.SelectedIndex]["kmKørt"]) + Convert.ToInt32(kmIndtast.Text);
            int insertBil = Convert.ToInt32(this.kørselDataSet.bil.Rows[bil.SelectedIndex]["kmKørt"]) + Convert.ToInt32(kmIndtast.Text);
            SqlConnection connect = new SqlConnection(credentials);
            SqlCommand cmd = new SqlCommand("UPDATE bruger SET kmKørt = @value WHERE brugerNr = @brugervalg;", connect);
            SqlCommand cmd1 = new SqlCommand("UPDATE bil SET kmKørt = @value WHERE bilNr = @bilvalg;", connect);
            cmd.Parameters.AddWithValue("@value", insertBruger);
            cmd1.Parameters.AddWithValue("@value", insertBil);

            cmd.Parameters.AddWithValue("@brugervalg", Convert.ToInt32(Brugere.SelectedIndex + 1));
            cmd1.Parameters.AddWithValue("@bilvalg", Convert.ToInt32(bil.SelectedIndex + 1));
            int tempbruger = Convert.ToInt32(Brugere.SelectedValue);
            int tempbil = Convert.ToInt32(bil.SelectedIndex);
            
            try
            {
                connect.Open();
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                connect.Dispose();






                test.Text = Convert.ToString(Brugere.SelectedValue);


                //if (bil.SelectedIndex == 0)
                //{
                //    bilfabrikantNavn.Text = "Mærke:              " + Convert.ToString(this.kørselDataSet.bil.Rows[0]["mærke"]);
                //    modelNavn.Text = "Model:                " + Convert.ToString(this.kørselDataSet.bil.Rows[0]["model"]);
                //    nummerpladeNavn.Text = "Nummerplade:    " + Convert.ToString(this.kørselDataSet.bil.Rows[0]["nummerplade"]);
                //    kmKørtBilLabel.Text = "Kilometer kørt:    " + Convert.ToString(this.kørselDataSet.bil.Rows[0]["kmKørt"]);


                //}


                if (Convert.ToInt32(Brugere.SelectedValue) == 0)
                {
                    forNavnMenu.Text = "Navn:        " + Convert.ToString(this.kørselDataSet.bruger.Rows[0]["fornavn"]);
                    efterNavnMenu.Text = "Efternavn: " + Convert.ToString(this.kørselDataSet.bruger.Rows[0]["efternavn"]);
                    kørteKm.Text = "Kørte KM: " + Convert.ToString(this.kørselDataSet.bruger.Rows[0]["kmKørt"]);

                }

                log.nyLogKmKørt(Convert.ToInt32(kmIndtast.Text));
                

            }

            catch (Exception es) { MessageBox.Show(es.Message+4); }


            MessageBox.Show(Convert.ToString(Brugere.SelectedValue));



           // this.bilTableAdapter.Fill(this.kørselDataSet.bil);
            this.brugerTableAdapter.Fill(this.kørselDataSet.bruger);
            
            bil.SelectedIndex = tempbil;
            Brugere.SelectedValue = tempbruger;


            // hovedmenu_Load(sender, e);


        }




        private void toggleInaktiv_CheckedChanged_1(object sender, EventArgs e)
        {
            if (toggleInaktiv.Checked == true)
            {
                toggleInaktiv.Checked = true;
                this.brugerBindingSource.Filter = "";
                this.brugerTableAdapter.Fill(this.kørselDataSet.bruger);

            }
            else this.brugerBindingSource.Filter = "aktiv = 1";
        }
    }
}