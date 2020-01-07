using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kørselslog
{
    public partial class oversigt : Form
    {
        public oversigt()
        {
            InitializeComponent();
            this.logTableAdapter.Fill(this.kørselDataSet.log);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

     

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void oversigt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kørselDataSet.log' table. You can move, or remove it, as needed.
            this.logTableAdapter.Fill(this.kørselDataSet.log);

        }
    }
}
