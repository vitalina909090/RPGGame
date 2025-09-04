using GameLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GameLogic
{
    public class Inventory
    {
        public int Gold { get; set; }

        public int Health { get; set; }
        public int MaxHealth { get; set; }

        public int Experience { get; set; }
        public int MaxExperience { get; set; }
        public int Level { get; set; } = 1;

        public List<InventoryItem> Items { get; set; } = new List<InventoryItem>();
        public Equipment Equipment { get; set; } = new Equipment();

        public int TotalAttack => Equipment?.Weapon?.AttackBonus ?? 0;
        public int TotalDefense => Equipment?.Armor?.DefenseBonus ?? 0;

        public void AddItem(string itemName, int quantity, ItemType type)
        {
            var existing = Items.FirstOrDefault(i => i.ItemName == itemName && i.Type == type);
            if (existing != null)
                existing.Quantity += quantity;
            else
                Items.Add(new InventoryItem { ItemName = itemName, Quantity = quantity, Type = type });
        }

        public void RemoveItem(string itemName, int quantity = 1)
        {
            var existing = Items.FirstOrDefault(i => i.ItemName == itemName);
            if (existing != null)
            {
                existing.Quantity -= quantity;
                if (existing.Quantity <= 0)
                    Items.Remove(existing);
            }
        }

        public void EquipWeapon(Weapon weapon)
        {
            if (Equipment.Weapon != null)
                AddItem(Equipment.Weapon.Name, 1, ItemType.Weapon);

            Equipment.Weapon = weapon;
            RemoveItem(weapon.Name, 1);
        }

        public void UnequipWeapon()
        {
            if (Equipment.Weapon != null)
            {
                AddItem(Equipment.Weapon.Name, 1, ItemType.Weapon);
                Equipment.Weapon = null;
            }
        }

        public void EquipArmor(Armor armor)
        {
            if (Equipment.Armor != null)
                AddItem(Equipment.Armor.Name, 1, ItemType.Armor);

            Equipment.Armor = armor;
            RemoveItem(armor.Name, 1);
        }

        public void UnequipArmor()
        {
            if (Equipment.Armor != null)
            {
                AddItem(Equipment.Armor.Name, 1, ItemType.Armor);
                Equipment.Armor = null;
            }
        }

        public void AddExperience(int amount)
        {
            Experience += amount;
            while (Experience >= MaxExperience)
            {
                Experience -= MaxExperience;
                LevelUp();
            }
        }

        private void LevelUp()
        {
            Level++;
            MaxHealth += 10;
            Health = MaxHealth;
            MaxExperience = CalculateNextLevelExp();
        }

        private int CalculateNextLevelExp()
        {
            return 100 + (Level - 1) * 50;
        }
    }
    public enum ItemType
    {
        Consumable,
        Weapon,
        Armor
    }
    public class InventoryItem
    {
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public ItemType Type { get; set; } = ItemType.Consumable;

        public override string ToString()
        {
            return $"{ItemName} x{Quantity}";
        }
    }

    public class Equipment
    {
        public Weapon Weapon { get; set; }
        public Armor Armor { get; set; }
    }

    public class Weapon
    {
        public string Name { get; set; }
        public int AttackBonus { get; set; }
    }

    public class Armor
    {
        public string Name { get; set; }
        public int DefenseBonus { get; set; }
    }
}

