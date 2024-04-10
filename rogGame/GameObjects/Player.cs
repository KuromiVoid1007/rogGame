using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rogGame.GameObjects
{
    internal class Player : UserControl
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Player
            // 
            this.BackColor = System.Drawing.Color.Silver;
            this.Name = "Player";
            this.ResumeLayout(false);

        }
    }
}
