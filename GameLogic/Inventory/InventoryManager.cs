using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GameLogic
{
    public static class InventoryManager
    {
        private static string dataFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PlayerData.json");

        public static Inventory InventoryLoad()
        {
            if (File.Exists(dataFilePath))
            {
                string json = File.ReadAllText(dataFilePath);
                return JsonSerializer.Deserialize<Inventory>(json);
            }
            else
            {
                return new Inventory();
            }
        }

        public static void InventorySave(Inventory inventory)
        {
            string json = JsonSerializer.Serialize(inventory, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(dataFilePath, json);
        }
    }
}
