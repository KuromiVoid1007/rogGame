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
    public partial class Form2 : Form
    {
        public Form1 form1;
        public bool flagMusic;

        public Form2(Form1 Form1)
        {
            InitializeComponent();
            this.form1 = Form1;

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.Close();
            var form4 = new Form4();
            var locationX = this.Location.X;
            var locationY = this.Location.Y;
            form4.Show();
            form4.Location = new Point(locationX + this.Width / 2 - form4.Width / 2, locationY + this.Height / 2 - form4.Height / 2 + 11);
            form4.TopMost = true;
        }

        private void buttomExitPlay_Click(object sender, EventArgs e)
        {
            var form3 = new Form3();
            var locationX = form1.Location.X;
            var locationY = form1.Location.Y;
            form3.Show();
            form3.TopMost = true;
        }

        private void buttonMusic2_Click(object sender, EventArgs e)
        {
            if (!flagMusic)
            {
                form1.sndPlayer.Stop();
                flagMusic = true;
            }
            else
            {
                form1.sndPlayer.PlayLooping();
                flagMusic = false;
            }
        }
    }
}
