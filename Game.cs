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
    private readonly CombatSystem combat;
 
    
    //Oyun yönetimi
    private int cycle;


    public Game()
    {
    world = new World();
    floor = new Floor();
    craft = new CraftSystem();
    combat = new CombatSystem();
   

    player = new Player("Kahraman", floor);
    enemy = new Goblin(floor);

    

    
    }
    

    public async Task RunAsync()
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

            Console.Write(menu +  "\n Seçim: ");
            string? input = Console.ReadLine();

            switch (input)
            {
                case "1":
                if (!player.IsDead && !enemy.IsDead)
             {
                    await combat.Combat(player, enemy);
                    }else Console.WriteLine($"{player.Name} ölü, saldırı yapamaz!");

                if (enemy.IsDead)
            {
                enemy.Respawn(); // test için
                 }

                     break;
                   

                case "2":
                   
                    player.CollectItems();
                   
                    break;

                case "3":
                    player.ReadTheBag();
                    break;

                case "4":
                    craft.CraftMenu(player,floor);
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