using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prepare
{
    public partial class organizator : Form
    {
        public organizator()
        {
            InitializeComponent();
        }

        private void organizator_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'user127_dbDataSet.Auser1' table. You can move, or remove it, as needed.
            this.auser1TableAdapter.Fill(this.user127_dbDataSet.Auser1);

        }

        private void editorgbtn_Click(object sender, EventArgs e)
        {
            this.auser1TableAdapter.Update(this.user127_dbDataSet.Auser1);
        }

        private void deleteorgbtn_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.Remove(dataGridView1.Rows[a]);
            this.auser1TableAdapter.Update(this.user127_dbDataSet.Auser1);
        }
    }
}
