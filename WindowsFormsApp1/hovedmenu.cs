using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class hovedmenu : Form
    {
        String credentials = "server=TAK;Initial Catalog=kørsel;User ID=bruger;Password = stop;";
        int valgtBil;
        int valgtBruger;
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
                if (Brugere.SelectedIndex > 0)
                {
                    forNavnMenu.Text = "Navn:        " + Convert.ToString(this.kørselDataSet.bruger.Rows[Brugere.SelectedIndex]["fornavn"]);
                    efterNavnMenu.Text = "Efternavn: " + Convert.ToString(this.kørselDataSet.bruger.Rows[Brugere.SelectedIndex]["efternavn"]);
                    kørteKm.Text = "Kørte KM: " + Convert.ToString(this.kørselDataSet.bruger.Rows[Brugere.SelectedIndex]["kmKørt"]);

                }
                if (Brugere.SelectedIndex == 0)
                {
                    forNavnMenu.Text = "Navn:        " + Convert.ToString(this.kørselDataSet.bruger.Rows[0]["fornavn"]);
                    efterNavnMenu.Text = "Efternavn: " + Convert.ToString(this.kørselDataSet.bruger.Rows[0]["efternavn"]);
                    kørteKm.Text = "Kørte KM: " + Convert.ToString(this.kørselDataSet.bruger.Rows[0]["kmKørt"]);

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

        private void redigering_Click(object sender, EventArgs e)
        {
            using (var form = new Redigering())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.Yes)
                {
                    //fornavn = form.forNavnIndtast;
                    //efternavn = form.efterNavnIndtast;

                    //SqlConnection connect = new SqlConnection(credentials);
                    //SqlCommand cmd = new SqlCommand("INSERT INTO bruger (fornavn,efternavn,kmKørt,aktiv) VALUES (@fornavn, @efternavn,@kmKørt,(1))", connect);
                    //cmd.Parameters.AddWithValue("@fornavn", fornavn);
                    //cmd.Parameters.AddWithValue("@efternavn", efternavn);
                    //cmd.Parameters.AddWithValue("@kmKørt", 0);


                    //connect.Open();
                    //cmd.ExecuteNonQuery();
                    //this.brugerTableAdapter.Fill(this.kørselDataSet.bruger);
                    //connect.Dispose();

                }

            }
        }
        private void update()
        {



            
        }
        private void oversigt_Click(object sender, EventArgs e)
        {

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

            cmd.Parameters.AddWithValue("@brugervalg", Convert.ToInt32(Brugere.SelectedIndex+1));
            cmd1.Parameters.AddWithValue("@bilvalg", Convert.ToInt32(bil.SelectedIndex+1));
            int tempbruger = Convert.ToInt32(Brugere.SelectedIndex + 1);
            int tempbil = Convert.ToInt32(bil.SelectedIndex + 1);
            try
            {
                connect.Open();
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                connect.Dispose();
            }
            catch (Exception es) { MessageBox.Show(es.Message); }

            try
            {
               this.bilTableAdapter.Fill(this.kørselDataSet.bil);
               this.brugerTableAdapter.Fill(this.kørselDataSet.bruger);
               Brugere.SelectedIndex = tempbruger -1;
               bil.SelectedIndex = tempbil-1;
                if (bil.SelectedIndex == 0)
                {
                    bilfabrikantNavn.Text = "Mærke:              " + Convert.ToString(this.kørselDataSet.bil.Rows[0]["mærke"]);
                    modelNavn.Text = "Model:                " + Convert.ToString(this.kørselDataSet.bil.Rows[0]["model"]);
                    nummerpladeNavn.Text = "Nummerplade:    " + Convert.ToString(this.kørselDataSet.bil.Rows[0]["nummerplade"]);
                    kmKørtBilLabel.Text = "Kilometer kørt:    " + Convert.ToString(this.kørselDataSet.bil.Rows[0]["kmKørt"]);

                }
                if (Brugere.SelectedIndex == 0)
                {
                    forNavnMenu.Text = "Navn:        " + Convert.ToString(this.kørselDataSet.bruger.Rows[0]["fornavn"]);
                    efterNavnMenu.Text = "Efternavn: " + Convert.ToString(this.kørselDataSet.bruger.Rows[0]["efternavn"]);
                    kørteKm.Text = "Kørte KM: " + Convert.ToString(this.kørselDataSet.bruger.Rows[0]["kmKørt"]);

                }
            }
            catch (Exception es) { MessageBox.Show(es.Message); }
            //nylog(cmd);
            //nylog(cmd1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try

            {

                String query = "insert into";
                SqlConnection connect = new SqlConnection(credentials);
                SqlCommand cmd = new SqlCommand(query, connect);
                connect.Open();
                MessageBox.Show("Du er nu forbundet til serveren");
                connect.Dispose();


            }

            catch (Exception es)

            {

                MessageBox.Show(es.Message);



            }
        }













        private void sletadata_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(Brugere.SelectedValue) >= 1)
            {
                //SqlConnection connect = new SqlConnection(credentials);
                //SqlCommand cmd = new SqlCommand("DELETE FROM bruger where brugerNr = @Id", connect);
                //cmd.Parameters.AddWithValue("@Id", Brugere.SelectedValue);
                //connect.Open();
                //cmd.ExecuteNonQuery();
                //this.brugerTableAdapter.Fill(this.kørselDataSet.bruger);
                //connect.Dispose();

            }
        }
    

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void kørteKm_Click(object sender, EventArgs e)
        {

        }








        public void nyLogBilOpret()
        {
            SqlConnection connect = new SqlConnection(credentials);
            DateTime dateTimeVariable = DateTime.Now;
            SqlCommand cmd = new SqlCommand("INSERT INTO log (kmKørtBruger,kmKørtBil,opretBruger,opretBil,opretForbindelse) VALUES (kmKørtBruger,kmKørtBil,opretBruger,opretBil,@tid)", connect);
            cmd.Parameters.AddWithValue("@kmKørtBruger", dateTimeVariable);
            cmd.Parameters.AddWithValue("@kmKørtBil", dateTimeVariable);
            cmd.Parameters.AddWithValue("@opretBruger", dateTimeVariable);
            cmd.Parameters.AddWithValue("@opretBil", dateTimeVariable);
            cmd.Parameters.AddWithValue("@tid", dateTimeVariable);
            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Dispose();
        }
        public void nyLogBrugerOpret()
        {
            SqlConnection connect = new SqlConnection(credentials);
            DateTime dateTimeVariable = DateTime.Now;
            SqlCommand cmd = new SqlCommand("INSERT INTO log (kmKørtBruger,kmKørtBil,opretBruger,opretBil,opretForbindelse) VALUES (kmKørtBruger,kmKørtBil,opretBruger,opretBil,@tid)", connect);
            cmd.Parameters.AddWithValue("@kmKørtBruger", dateTimeVariable);
            cmd.Parameters.AddWithValue("@kmKørtBil", dateTimeVariable);
            cmd.Parameters.AddWithValue("@opretBruger", dateTimeVariable);
            cmd.Parameters.AddWithValue("@opretBil", dateTimeVariable);
            cmd.Parameters.AddWithValue("@tid", dateTimeVariable);
            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Dispose();
        }
        public void nyLogKmKørt()
        {
            SqlConnection connect = new SqlConnection(credentials);
            DateTime dateTimeVariable = DateTime.Now;
            SqlCommand cmd = new SqlCommand("INSERT INTO log (kmKørtBruger,kmKørtBil,opretBruger,opretBil,opretForbindelse) VALUES (kmKørtBruger,kmKørtBil,opretBruger,opretBil,@tid)", connect);
            cmd.Parameters.AddWithValue("@kmKørtBruger", dateTimeVariable);
            cmd.Parameters.AddWithValue("@kmKørtBil", dateTimeVariable);
            cmd.Parameters.AddWithValue("@opretBruger", dateTimeVariable);
            cmd.Parameters.AddWithValue("@opretBil", dateTimeVariable);
            cmd.Parameters.AddWithValue("@tid", dateTimeVariable);
            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Dispose();
        }
        public void nyLogRedigering()
        {
            SqlConnection connect = new SqlConnection(credentials);
            DateTime dateTimeVariable = DateTime.Now;
            SqlCommand cmd = new SqlCommand("INSERT INTO log (kmKørtBruger,kmKørtBil,opretBruger,opretBil,opretForbindelse) VALUES (kmKørtBruger,kmKørtBil,opretBruger,opretBil,@tid)", connect);
            cmd.Parameters.AddWithValue("@kmKørtBruger", dateTimeVariable);
            cmd.Parameters.AddWithValue("@kmKørtBil", dateTimeVariable);
            cmd.Parameters.AddWithValue("@opretBruger", dateTimeVariable);
            cmd.Parameters.AddWithValue("@opretBil", dateTimeVariable);
            cmd.Parameters.AddWithValue("@tid", dateTimeVariable);
            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Dispose();
        }
    }
}


       

