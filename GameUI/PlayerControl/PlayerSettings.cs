using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameUI
{
    public class PlayerSettings : PictureBox
    {
        public int Speed = 5;
        public PlayerSettings(int startX, int startY)
        {
            Size = new Size(64, 64);
            Location = new Point(startX, startY);
            SizeMode = PictureBoxSizeMode.Zoom;
            BackColor = Color.Transparent;
        }
    }
}
