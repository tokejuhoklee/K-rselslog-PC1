using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class indtastBruger : Form
    {
        public string forNavnIndtast { get; set; }
        public string efterNavnIndtast { get; set; }
        public indtastBruger()
        {
            InitializeComponent();

        }



        private void fornavn_Click(object sender, EventArgs e)
        {

        }



        private void efternavn_Click(object sender, EventArgs e)
        {

        }

        private void indtastNavn_TextChanged(object sender, EventArgs e)
        {
            forNavnIndtast = indtastNavn.Text;

        }

        private void indtastEfternavn_TextChanged(object sender, EventArgs e)
        {
            efterNavnIndtast = indtastEfternavn.Text;
        }

        private void indsend_Click(object sender, EventArgs e)
        {

            this.forNavnIndtast = indtastNavn.Text;
            this.efterNavnIndtast = indtastEfternavn.Text; //example
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
