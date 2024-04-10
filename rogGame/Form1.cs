using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rogGame
{
    public partial class Form1 : Form
    {
        Form From2;
        Form From3;
        Point start_point = new Point(0, 0);

        public SoundPlayer sndPlayer;

        bool drag = false;
        public bool flagMusic;


        public Form1()
        {
            InitializeComponent();
            StartScreenMenu();

            sndPlayer = new SoundPlayer(Properties.Resources.rogGame);
            LoopMusic();
        }

        private void LoopMusic()
        {
            if (flagMusic == false)
                sndPlayer.PlayLooping();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            var form3 = new Form3();
            form3.Show();
            form3.TopMost = true;
        }

        public void StartScreenMenu()
        {
            var form2 = new Form2(this);
            form2.Show();
            form2.TopMost = true;
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
