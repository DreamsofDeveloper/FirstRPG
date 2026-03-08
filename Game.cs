using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using FirstRPG.Entities.Items;

public class Game
{

    //Objeler
    private readonly Floor floor;
    private readonly CraftSystem craft;
    private readonly Player player;
    private readonly Goblin enemy;
    private readonly World world;
    private readonly Bag playerbag;
    
    //Oyun yönetimi
    private int cycle;


    public Game()
    {
    world = new World();
    floor = new Floor();
    playerbag = new Bag();
    craft = new CraftSystem();
   

    player = new Player("Kahraman", 50 , 100 , floor , playerbag);
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
                    playerbag.Print();
                    player.Use();
                    break;

                case "4":
                    craft.CraftMenu(player,floor,playerbag);
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