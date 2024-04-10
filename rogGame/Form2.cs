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

        public Form2(Form1 Form1)
        {
            InitializeComponent();
            this.form1 = Form1;

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttomExitPlay_Click(object sender, EventArgs e)
        {
            var form3 = new Form3();
            form3.Show();
            form3.TopMost = true;
        }

    }
}
