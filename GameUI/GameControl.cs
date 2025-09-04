using GameLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace GameUI
{
    public partial class GameControl : UserControl
    {
        private System.Windows.Forms.Timer gameTimer;

        private PlayerSettings player;
        private AnimationPlayer animation;
        private PlayerController controller;

        private Button btnMenu;
        private GameMenuControl gameMenu;

        private Inventory playerInventory;
        private InventoryControl inventoryControl;
        private Button btnInventory;

        public GameControl()
        {
            InitializeComponent();

            gameTimer = new System.Windows.Forms.Timer();
            gameTimer.Interval = 50;
            gameTimer.Tick += GameLoop;
            gameTimer.Start();


            player = new PlayerSettings(200, 200);
            this.Controls.Add(player);

            animation = new AnimationPlayer();
            controller = new PlayerController(player, animation);


            btnMenu = new Button
            {
                Text = "Меню",
                Size = new Size(80, 30),
                Location = new Point(10, 10),
                TabStop = false
            };
            btnMenu.Click += (s, e) => gameMenu.ToggleMenu();
            this.Controls.Add(btnMenu);


            gameMenu = new GameMenuControl
            {
                Visible = false,
                Dock = DockStyle.Fill
            };
            this.Controls.Add(gameMenu);

            gameMenu.MenuClosed += () => this.Focus();
            gameMenu.MainMenuRequested += GoToMainMenu;

            playerInventory = InventoryManager.InventoryLoad();
            inventoryControl = new InventoryControl(playerInventory) { Visible = false, Dock = DockStyle.Fill };
            inventoryControl.InventoryClosed += () => this.Focus();
            this.Controls.Add(inventoryControl);

            btnInventory = new Button
            {
                Text = "Инвентарь",
                Location = new Point(100, 10),
                TabStop = false
            };
            btnInventory.Click += (s, e) => ToggleInventory();
            this.Controls.Add(btnInventory);

            this.Focus();
        }


        private void GameLoop(object sender, EventArgs e)
        {
            controller.Update(this.ClientRectangle);
            player.Image = controller.GetCurrentFrame();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                gameMenu.ToggleMenu();
                return true;
            }
            if (keyData == Keys.I)
            {
                ToggleInventory();
                return true;
            }

            controller.OnKeyDown(keyData);
            return base.ProcessCmdKey(ref msg, keyData);
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            controller.OnKeyUp(e.KeyCode);
            base.OnKeyUp(e);
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            ToggleMenu();
        }
        private void ToggleMenu()
        {
            gameMenu.Visible = !gameMenu.Visible;
            gameMenu.BringToFront();

            if (!gameMenu.Visible)
            {
                this.Focus();
            }
        }
        private void ToggleInventory()
        {
            inventoryControl.Visible = !inventoryControl.Visible;
            inventoryControl.BringToFront();

            if (!inventoryControl.Visible)
                this.Focus();
        }
        private void GoToMainMenu()
        {
            this.Controls.Clear();
            var mainMenu = new MainMenuControl();
            this.Controls.Add(mainMenu);
            mainMenu.Dock = DockStyle.Fill;
        }
    }
}
