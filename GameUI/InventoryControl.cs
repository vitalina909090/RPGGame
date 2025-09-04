using GameLogic;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class InventoryControl : UserControl
    {
        private Inventory playerInventory;
        public event Action InventoryClosed;

        public InventoryControl(Inventory inventory)
        {
            InitializeComponent();
            playerInventory = inventory;
            UpdateUI();
        }

        public void UpdateUI()
        {
            lblHealth.Text = $"{playerInventory.Health}/{playerInventory.MaxHealth}";
            lblExperience.Text = $"{playerInventory.Experience}/{playerInventory.MaxExperience} (Lvl {playerInventory.Level})";
            lblGold.Text = playerInventory.Gold.ToString();

            lblWeapon.Text = playerInventory.Equipment.Weapon?.Name ?? "None";
            lblArmor.Text = playerInventory.Equipment.Armor?.Name ?? "None";

            lstItems.Items.Clear();
            foreach (var item in playerInventory.Items)
                lstItems.Items.Add(item);
        }

        private void X_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            InventoryClosed?.Invoke();
        }

        private void lstItems_DoubleClick(object sender, EventArgs e)
        {
            var selectedItem = lstItems.SelectedItem as InventoryItem;
            if (selectedItem == null) return;

            switch (selectedItem.Type)
            {
                case ItemType.Weapon:
                    if (playerInventory.Equipment.Weapon != null)
                    {
                        playerInventory.AddItem(playerInventory.Equipment.Weapon.Name, 1, ItemType.Weapon);
                    }

                    playerInventory.Equipment.Weapon = new Weapon
                    {
                        Name = selectedItem.ItemName,
                        AttackBonus = 10
                    };

                    playerInventory.RemoveItem(selectedItem.ItemName, 1);
                    break;

                case ItemType.Armor:
                    if (playerInventory.Equipment.Armor != null)
                    {
                        playerInventory.AddItem(playerInventory.Equipment.Armor.Name, 1, ItemType.Armor);
                    }

                    playerInventory.Equipment.Armor = new Armor
                    {
                        Name = selectedItem.ItemName,
                        DefenseBonus = 5
                    };

                    playerInventory.RemoveItem(selectedItem.ItemName, 1);
                    break;

                case ItemType.Consumable:
                    MessageBox.Show($"{selectedItem.ItemName} используется!");
                    playerInventory.RemoveItem(selectedItem.ItemName, 1);
                    break;
            }

            UpdateUI();
        }
    }
}
