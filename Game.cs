using System;

public class Game
{
    private readonly InventorySystems inv = new InventorySystems();
    private  Player player = new Player();
    private Enemy enemy = new Enemy();

    public void Run()
    {
        string menu =
            "\n 1. Saldır" +
            "\n 2. Topla" +
            "\n 3. Envanter" +
            "\n 4. Craft" +
            "\n 5. Çıkış\n";

        while (true)
        {
            Console.Write(menu);
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    player.Attack();
                    enemy.Dead(player.AttackPower);
                    break;

                case "2":
                    inv.CollectItems();
                    break;

                case "3":
                    inv.PrintInventory();
                    break;

                case "4":
                    inv.CraftMenu();
                    break;

                case "5":
                    Console.WriteLine("Çıkış Yapılıyor");
                    return;

                default:
                    Console.WriteLine("Geçersiz seçim.");
                    break;
            }
        }
    }

  
}