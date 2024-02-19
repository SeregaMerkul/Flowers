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
    public partial class EditProduct : Form
    {
        public EditProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Authiriz authiriz = new Authiriz();
            authiriz.Show();
            Hide();
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {

            // TODO: данная строка кода позволяет загрузить данные в таблицу "tradeDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.tradeDataSet.Product);
            
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToInt32(row.Cells[8].Value) <= 5)
                {
                    row.DefaultCellStyle.BackColor = Color.Pink;
                }

               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.productBindingSource.EndEdit();
            this.productTableAdapter.Update(this.tradeDataSet.Product);
          
        }
    }
}
