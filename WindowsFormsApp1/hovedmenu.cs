using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class hovedmenu : Form
    {
        String credentials = "server=TAK;Initial Catalog=kørsel;User ID=bruger;Password = stop;MultipleActiveResultSets=true";
        string udskrivv;
        private int SelectedBrugerNr;

        public hovedmenu()
        {
            InitializeComponent();

        }

       
        public void hovedmenu_Load(object sender, EventArgs e)
        {

            try
            {
               this.bilTableAdapter.Fill(this.kørselDataSet.bil);
                this.brugerTableAdapter.Fill(this.kørselDataSet.bruger);
            }
            catch(Exception es) { MessageBox.Show(es.Message); }


          //  SelectedBrugerNr = Convert.ToInt32(Brugere.SelectedValue);

        }
        private void brugerValg(object sender, EventArgs e)
        {

            forNavnMenu.Text = Convert.ToString(this.kørselDataSet.bruger.Rows[Brugere.SelectedIndex]["fornavn"]);
            efterNavnMenu.Text = Convert.ToString(this.kørselDataSet.bruger.Rows[Brugere.SelectedIndex]["efternavn"]);
            
        }


        private void redigering_Click(object sender, EventArgs e)
        {

        }

        private void oversigt_Click(object sender, EventArgs e)
        {

        }

        private void ShowMyMessage(object sender, EventArgs e)
        {
            MessageBox.Show("This is my message");
        }

        private void ny_bil_Click(object sender, EventArgs e)
        {
            string fornavn="tom";
            string efternavn="tom";
            using (var form = new indtastBruger())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    fornavn = form.forNavnIndtast;
                    efternavn = form.efterNavnIndtast;

                }
            }
            SqlConnection connect = new SqlConnection(credentials);
            SqlCommand cmd = new SqlCommand("INSERT INTO bruger (fornavn,efternavn) VALUES (@fornavn, @efternavn)", connect);
            cmd.Parameters.AddWithValue("@fornavn", fornavn);
            cmd.Parameters.AddWithValue("@efternavn", efternavn);

            connect.Open();
            cmd.ExecuteNonQuery();
            this.brugerTableAdapter.Fill(this.kørselDataSet.bruger);
            connect.Dispose();



        }

        private void KM_input_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(credentials);
            DateTime dateTimeVariable = DateTime.Now;
            SqlCommand cmd = new SqlCommand("INSERT INTO log (opretForbindelse) VALUES (@value)", connect);
            cmd.Parameters.AddWithValue("@value", dateTimeVariable);
            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Dispose();


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





        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(udskrivv);
         

        }

        






        private void sletadata_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(Brugere.SelectedValue) >= 1)
            {
                SqlConnection connect = new SqlConnection(credentials);
                SqlCommand cmd = new SqlCommand("DELETE FROM bruger where brugerNr = @Id", connect);
                cmd.Parameters.AddWithValue("@Id", Brugere.SelectedValue);
                connect.Open();
                cmd.ExecuteNonQuery();
                this.brugerTableAdapter.Fill(this.kørselDataSet.bruger);
                connect.Dispose();

            }
        }
    }   
}
