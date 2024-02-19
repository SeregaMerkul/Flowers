using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Capcha;

namespace практика4
{
    public partial class Authiriz : Form
    {
        DataBase database = new DataBase();
        public Authiriz()
        {
            InitializeComponent();
        }

   
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            var LoginUser = textBox2.Text;
            var PasswordUser = textBox1.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select  UserLogin, UserPassword, UserRole from dbo.[User] where UserLogin = '{LoginUser}' and UserPassword = '{PasswordUser}'";
            SqlCommand command = new SqlCommand(querystring, database.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                EditProduct editproduct = new EditProduct();
                editproduct.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Show();
            Hide();
        }

        private void Authiriz_Load(object sender, EventArgs e)
        {
            pictureBox2.Image = Capcha.Capt.CreateImage(pictureBox2.Width, pictureBox2.Height);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Capcha.Capt.CreateImage(pictureBox2.Width, pictureBox2.Height);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == Capcha.Capt.text)
            {
                MessageBox.Show("Верно");
                label1.Visible = true;
                label2.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
            }
            else
                MessageBox.Show("Ошибка");
        }
    }
}
