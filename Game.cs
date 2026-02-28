using System;
using System.Runtime.InteropServices;

public class Game
{

    //Objeler
    private readonly Floor floor;
    private readonly InventorySystems inv;
    private readonly CraftSystem craft;
    private readonly Player player;
    private readonly Goblin enemy;
    private readonly World world;


    //Oyun yönetimi
    private int cycle;


    public Game()
    {
    world = new World();
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
            "\n 5. Yerdeki İtemler" +
            "\n 6. Çıkış\n";

        while (true)
        {
            cycle++;
            world.WorldRules(cycle,floor);

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

                         enemy.Respawn();
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
                    craft.CraftMenu(player,floor,inv);
                    break;

                case "5":
                    floor.ShowItemsOnFloor();
                    break;

                case "6":
                    Console.WriteLine("Çıkış Yapılıyor");
                    return;    

                default:
                    Console.WriteLine("Geçersiz seçim.");
                    break;
            }
        }
    }

 
  
}