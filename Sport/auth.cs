using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sport
{
    public partial class auth : Form
    {
        private Data data;
        public auth()
        {
            InitializeComponent();
            data = new Data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Проверка аутентификации
            bool isAuthenticated = data.AuthenticateUser(username, password);

            if (isAuthenticated)
            {
                // Получение должности работника
                string position = data.GetEmployeePosition(username);

                // Открытие соответствующей формы в зависимости от должности
                if (position == "Администратор")
                {
                    admin a = new admin();
                    a.Show();
                }
                else if (position == "Менеджер")
                {
                    emp emp = new emp();
                    emp.Show();
                }
                else
                {
                    MessageBox.Show("Неизвестная должность");
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
        private void auth_Load(object sender, EventArgs e)
        {

        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
