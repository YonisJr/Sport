using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sport
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
            this.MouseMove += new MouseEventHandler(Form1_MouseMove);
            this.MouseMove += new MouseEventHandler(Form1_MouseMove);
            button1.Location = new Point(1545, 960);
            button1.Size = new Size(280, 65);

            button2.Location = new Point(1220, 960);
            button2.Size = new Size(280, 65);

            button3.Location = new Point(895, 960);
            button3.Size = new Size(280, 65);

            button4.Location = new Point(570, 960);
            button4.Size = new Size(280, 65);

            panel1.Location = new Point(485, 33);

            panel2.Location = new Point(-1, 900);
            panel2.Size = new Size(1922, 10);

            pictureBox1.Size = new Size(340, 200);
            pictureBox1.Location = new Point(130, 910);

            dataGridView1.Location = new Point(513, 52);
            dataGridView1.Size = new Size(1390, 830);

            textBox1.Location = new Point(30, 100);
            textBox2.Location = new Point(30, 220);
            textBox3.Location = new Point(30, 340);
            textBox4.Location = new Point(30, 460);
            textBox5.Location = new Point(30, 580);
            textBox6.Location = new Point(30, 700);

            label1.Location = new Point(5, 1065);

            label2.Location = new Point(28, 77);
            label3.Location = new Point(28, 197);
            label4.Location = new Point(28, 317);
            label5.Location = new Point(28, 437);
            label6.Location = new Point(28, 557);
            label7.Location = new Point(28, 677);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePosition = PointToClient(MousePosition);
            label1.Text = "X: " + mousePosition.X + ", Y: " + mousePosition.Y;
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены что хотите выйти?",
                "Уведомление",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly
                ) ;
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены что хотите сменить пользователя?",
                "Уведомление",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly
                );
            if (result == DialogResult.Yes)
            {
                auth ADM = new auth();
                ADM.Show();
                this.Close();
            }
        }
    }
}
