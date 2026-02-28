using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class Floor
{

    private const int ClearCycle = 45;

    
   
    public  List<string> collectableItems = new List<string>();


    public void ItemsOnTheFloor(string droppedItem)
    {
        if (string.IsNullOrEmpty(droppedItem))
        {
            Console.WriteLine("Yere eklenecek eşya yok.");
            return;
        }

        collectableItems.Add(droppedItem);
    
    }

    public void ClearFloor()

    {
        collectableItems.Clear();       
    }

    public void AutomaticCleaning () {

      int Cycle =  ClearCycle;
      int Remain1 = ClearCycle - ()
        

        if( ClearCycle == 20)
        {
            Console.WriteLine ("Yerdeki itemler 25 döngü sonra silinecektir!!!");
    
            
        }
        else if( ClearCycle == 35)
        {
            Console.WriteLine ("Yerdeki itemler 10 döngü sonra silinecektir!!!");
    
            
        }

        if (ClearCycle >= 45)
        {
            collectableItems.Clear();

        }
        
    }

   
}