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
    public partial class GameMenuControl : UserControl
    {
        public event Action MenuClosed;
        public event Action MainMenuRequested;

        public GameMenuControl()
        {
            InitializeComponent();
        }

        private void btnHints_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HELP ME");
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            MainMenuRequested?.Invoke();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void X_Click(object sender, EventArgs e)
        {
            CloseMenu();
        }

        public void CloseMenu()
        {
            this.Visible = false;
            MenuClosed?.Invoke();
        }
        public void OpenMenu()
        {
            this.Visible = true;
            this.BringToFront();
        }

        public void ToggleMenu()
        {
            if (this.Visible)
                CloseMenu();
            else
                OpenMenu();
        }
    }
}
