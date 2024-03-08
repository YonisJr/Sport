using Npgsql;
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
    public partial class emp : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Database=sport;Username=YonisJr;Password=0907;Port=5432");
        public emp()
        {
            InitializeComponent();

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

            pictureBox1.Size = new Size(340,200);
            pictureBox1.Location = new Point(130, 910);

            dataGridView1.Location = new Point(513, 52);
            dataGridView1.Size = new Size(1390, 830);

            textBox1.Location = new Point(30, 100);
            comboBox3.Location = new Point(30, 100);

            textBox2.Location = new Point(30,220);
            maskedTextBox2.Location = new Point(30, 220);
            comboBox2.Location = new Point(30, 220);

            textBox3.Location = new Point(30,340);
            comboBox1.Location = new Point(30, 340);
            maskedTextBox1.Location = new Point(30, 340);

            textBox4.Location = new Point(30,460);
            radioButton1.Location = new Point(30, 430);
            radioButton2.Location = new Point(30, 460);
            numericUpDown2.Location = new Point(30, 548);

            textBox5.Location = new Point(30,580);

            textBox6.Location = new Point(30,700);

            textBox7.Location = new Point(30, 820);

            label1.Location = new Point(5,1065);

            label2.Location = new Point(28, 77);
            label3.Location = new Point(28, 197);
            label4.Location = new Point(28, 317);
            label5.Location = new Point(28, 437);
            label6.Location = new Point(28, 557);
            label7.Location = new Point(28, 677);
            label8.Location = new Point(28, 525);
            label9.Location = new Point(28, 797);

            label7.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";

            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            dataGridView1.Visible = false;
            comboBox1.Visible = false;
            maskedTextBox1.Visible = false;
            maskedTextBox2.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            comboBox3.Visible = false;
            comboBox2.Visible = false;
            numericUpDown2.Visible = false;


        }
        
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePosition = PointToClient(MousePosition);
            label1.Text = "X: " + mousePosition.X + ", Y: " + mousePosition.Y;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void emp_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        string fas;

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены что хотите выйти?",
                "Уведомление",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly
                );
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
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
        //добавление
        private void button4_Click(object sender, EventArgs e)
        {
            
            switch (fas)
            {

                case "Участники":
                    //insert into public.player(surname_pl, name_pl, otch_pl, age, pol, id_team) values('Максимов','Максим','Максимович','22','М',(select id_team from public.team where name_team ='228_team' and strana = 'Russia'));

                    //insert into public.team(name_team, strana) values('228_team','Russia'); 

                break;

                case "Соревнования":

                    label3.Text = "Робит";

                break;

                case "Расписание":

                    label4.Text = "ит";

                break;
            }
                    
        }

        private void участникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fas = "Участники";
            label2.Visible = true;
            label2.Text = "Фамилия";
            label3.Visible = true;
            label3.Text = "Имя";
            label4.Visible = true;
            label4.Text = "Отчество";
            label5.Visible = true;
            label5.Text = "Возраст";
            label6.Visible = true;
            label6.Text = "Пол";
            label7.Visible = true;
            label7.Text = "Команда";
            label9.Visible = true;
            label9.Text = "Страна";

            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            comboBox1.Visible = false;
            maskedTextBox1.Visible = false;
            maskedTextBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox2.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;

            panel1.Visible = true;
            panel2.Visible = true;

            button4.Visible = true;
            button4.Text = "Добавить";
            button3.Visible = true;
            button3.Text = "Редактировать";
            button2.Visible = true;
            button2.Text = "Удалить";
            button1.Visible = true;
            button1.Text = "Обновить";
            dataGridView1.Visible = true;
            label8.Visible = false;

            numericUpDown2.Visible = false;
        }

        private void соревнованияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fas = "Соревнования";

            label2.Visible = true;
            label2.Text = "Название";
            label3.Visible = true;
            label3.Text = "Вид спорта";
            label4.Visible = true;
            label4.Text = "Место проведения";
            label5.Visible = true;
            label5.Text = "Организатор";

            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            comboBox1.Visible = false;
            maskedTextBox1.Visible = false;
            maskedTextBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox2.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;

            textBox5.Visible = false;
            textBox6.Visible = false;

            panel1.Visible = true;
            panel2.Visible = true;

            button4.Visible = true;
            button4.Text = "Добавить";
            button3.Visible = true;
            button3.Text = "Редактировать";
            button2.Visible = true;
            button2.Text = "Удалить";
            button1.Visible = true;
            button1.Text = "Обновить";

            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;

            numericUpDown2.Visible = false;

            textBox7.Visible = false;
            label9.Visible = false;
        }

        private void расписаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fas = "Расписание";

            comboBox1.Visible = true;

            panel1 .Visible = true;
            panel2 .Visible = true;

            label2.Visible = true;
            label2.Text = "Список соревнований";
            label3.Visible = true;
            label3.Text = "Дата начала";
            label4.Visible = true;
            label4.Text = "Дата окончания";

            maskedTextBox1.Visible = true;
            maskedTextBox2.Visible = true;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;

            comboBox3 .Visible = true;

            button4.Visible = true;
            button4.Text = "Добавить";
            button3.Visible = true;
            button3.Text = "Редактировать";
            button2.Visible = true;
            button2.Text = "Удалить";
            button1.Visible = true;
            button1.Text = "Обновить";

            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;

            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;

            numericUpDown2.Visible = false;
            textBox7.Visible = false;
            label9.Visible = false;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void результатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fas = "Результаты";
            comboBox1.Visible = true;
            comboBox3.Visible = true;
            comboBox2.Visible = true;
            radioButton1.Visible = true;
            radioButton1.Text = "Победа";
            radioButton2.Visible = true;
            radioButton2.Text = "Порожение";
            numericUpDown2.Visible = true;

            panel1.Visible = true;
            panel2.Visible = true;

            button4.Visible = true;
            button4.Text = "Добавить";
            button3.Visible = true;
            button3.Text = "Редактировать";
            button2.Visible = true;
            button2.Text = "Удалить";
            button1.Visible = true;
            button1.Text = "Обновить";

            dataGridView1.Visible = true;

            label2.Visible = true;
            label2.Text = "Соревнования";
            label3.Visible = true;
            label3.Text = "Команда";
            label4.Visible = true;
            label4.Text = "Участники";
            label8.Visible = true;
            label8.Text = "Место";
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            textBox7.Visible = false;
            label9.Visible = false;
        }

        private void создатьГрамотуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible =false;

            panel1.Visible = true;
            panel2.Visible = true;

            button1.Visible = true;
            button1.Text = "Создать";

            label2.Visible = true;
            label2.Text = "Соревнования";
            comboBox3.Visible = true;

            label3.Visible = true;
            label3.Text = "Участники";
            comboBox2.Visible = true;

            dataGridView1.Visible = false;

            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;

            label4.Visible = false;
            label5.Visible = false;
            label6.Visible= false;
            label7.Visible = false;
            label8.Visible = false;

            textBox1 .Visible = false;
            textBox2 .Visible = false;
            textBox3 .Visible = false;
            textBox4 .Visible = false;
            textBox5 .Visible = false;
            textBox6 .Visible = false;
            
            radioButton1 .Visible = false;
            radioButton2 .Visible = false;

            numericUpDown2.Visible = false;

            maskedTextBox1 .Visible = false;
            maskedTextBox2 .Visible = false;    

            comboBox1 .Visible = false;

            textBox7.Visible = false;
            label9.Visible = false;


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
