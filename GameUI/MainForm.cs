namespace GameUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadScreen(new MainMenuControl());
            this.KeyPreview = true;
        }

        public void LoadScreen(UserControl screen)
        {
            this.Controls.Clear();
            screen.Dock = DockStyle.Fill;
            this.Controls.Add(screen);
        }

    }
}
