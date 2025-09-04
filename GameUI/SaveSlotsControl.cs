using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameUI
{
    public partial class SaveSlotsControl : UserControl
    {
        public SaveSlotsControl()
        {
            InitializeComponent();
        }

        private void btnSlot1_Click(object sender, EventArgs e)
        {
            bool saveExists = false;
            var parent = (MainForm)ParentForm;

            if (saveExists)
                parent.LoadScreen(new GameControl(/* данные загрузки */));
            else
                parent.LoadScreen(new GameControl(/* новая игра */));
        }
        private void btnSlot2_Click_1(object sender, EventArgs e)
        {
            bool saveExists = false;
            var parent = (MainForm)ParentForm;

            if (saveExists)
                parent.LoadScreen(new GameControl());
            else
                parent.LoadScreen(new GameControl());
        }
        private void btnSlot3_Click_1(object sender, EventArgs e)
        {
            bool saveExists = false;
            var parent = (MainForm)ParentForm;

            if (saveExists)
                parent.LoadScreen(new GameControl());
            else
                parent.LoadScreen(new GameControl());
        }
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            var parent = (MainForm)ParentForm;
            parent.LoadScreen(new MainMenuControl());
        }
    }
}
