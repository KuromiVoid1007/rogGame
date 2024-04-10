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



        public Form1()
        {
            InitializeComponent();
            StartScreenMenu();

            sndPlayer = new SoundPlayer(Properties.Resources.rogGame);
            sndPlayer.PlayLooping();

        }



        private void buttonExit_Click(object sender, EventArgs e)
        {
            var form3 = new Form3();
            var locationX = this.Location.X;
            var locationY = this.Location.Y;
            form3.Show();
            form3.Location = new Point(locationX + this.Width / 2 - form3.Width / 2, locationY + this.Height / 2 - form3.Height / 2);
            form3.TopMost = true;
        }


        public void StartScreenMenu()
        {
            var form2 = new Form2(this);
            form2.Show();
            form2.TopMost = true;
        }

    }
}
