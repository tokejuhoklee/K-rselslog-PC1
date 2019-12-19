using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Redigering : Form
    {
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
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
