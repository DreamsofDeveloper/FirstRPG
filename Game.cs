using System;
using System.Runtime.InteropServices;

public class Game
{

    private readonly Floor floor;
    private readonly InventorySystems inv;
    private readonly CraftSystem craft;
    private readonly Player player;
    private readonly Goblin enemy;



    public Game()
    {
        
    floor = new Floor();
    inv = new InventorySystems();
    craft = new CraftSystem();


    //Entities
    player = new Player(50, 50,inv);
    enemy = new Goblin(floor);
    
    }
    

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
            string? input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    if (!enemy.IsDead)
                    {
                      player.Attack(); 
                      enemy.TakeDamage(player.AttackPower);  

                      if (enemy.IsDead) // Test için yeniden canladırma
                        {

                         enemy.Hp = 50;
                         enemy.IsDead = false;
                        }
                    } 
                    
                     
                    break;

                case "2":
                   
                    player.CollectItems(floor);
                   
                    break;

                case "3":
                    inv.PrintInventory();
                    break;

                case "4":
                    craft.CraftMenu(player);
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