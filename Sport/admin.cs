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
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePosition = PointToClient(MousePosition);
            label1.Text = "X: " + mousePosition.X + ", Y: " + mousePosition.Y;
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }
    }
}
