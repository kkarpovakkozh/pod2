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
    public partial class avtorizacia : Form
    {
        public avtorizacia()
        {
            InitializeComponent();
        }

        private void avtorizacia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'user127_dbDataSet.Event' table. You can move, or remove it, as needed.
            this.eventTableAdapter.Fill(this.user127_dbDataSet.Event);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.eventTableAdapter.Update(this.user127_dbDataSet.Event);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.Remove(dataGridView1.Rows[a]);
            this.eventTableAdapter.Update(this.user127_dbDataSet.Event);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = dataGridView1.Columns[1].HeaderText.ToString() + " LIKE '%" + textBox1.Text + "%'";
            dataGridView1.DataSource = bs;
        }
    }
}
