using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class indtastBruger : Form
    {
        public string forNavnIndtast { get; set; }
        public string efterNavnIndtast { get; set; }
        public string bilModel { get; set; }
        public string nummerplade { get; set; }
        public string fabrikant { get; set; }
        public indtastBruger()
        {
            InitializeComponent();

        }


        private void indtastNavn_TextChanged(object sender, EventArgs e)
        {
            forNavnIndtast = indtastNavn.Text;

        }

        private void indtastEfternavn_TextChanged(object sender, EventArgs e)
        {
            efterNavnIndtast = indtastEfternavn.Text;
        }



        private void indsendBruger_Click(object sender, EventArgs e)
        {

            this.forNavnIndtast = indtastNavn.Text;
            this.efterNavnIndtast = indtastEfternavn.Text; 
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void indsendBil_Click(object sender, EventArgs e)
        {

            this.bilModel = indtastModel.Text;
            this.nummerplade= indtastNummerplade.Text;
            this.fabrikant = indtastFabrikant.Text;

            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void indtastFabrikant_TextChanged(object sender, EventArgs e)
        {
            fabrikant = indtastFabrikant.Text;

        }

        private void indtastNummerplade_TextChanged(object sender, EventArgs e)
        {
            nummerplade = indtastNummerplade.Text;

        }

        private void indtastModel_TextChanged(object sender, EventArgs e)
        {
            bilModel = indtastModel.Text;

        }
    }
}
