using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rogGame
{
    public partial class Form1 : Form
    {
        Form From2;
        bool drag = false;
        Point start_point = new Point(0, 0);

        public Form1()
        {
            InitializeComponent();
            Start();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Start()
        {
            From2 = new Form2();
            From2.Show();
        }

        // настрйока панели
        private void quickPanel_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void quickPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void quickPanel_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
        
    }
}
