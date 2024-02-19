using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace практика4
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Authiriz authiriz = new Authiriz();
            authiriz.Show();
            Hide();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tradeDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.tradeDataSet.Product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tradeDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.tradeDataSet.Product);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
