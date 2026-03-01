using System;

public class World
{
    private int cycleFloor;
    private bool countdownStarted = false;

    public void WorldRules(int cycle, Floor floor)
    {

        if (floor.IsWeight())
        {
            // Geri sayım daha önce başlamadıysa sadece bir kere kaydet
            if (!countdownStarted)
            {
                cycleFloor = cycle;
                countdownStarted = true;
                Console.WriteLine("15 döngü sonra yerdeki tüm eşyalar silinecektir!");
            }

            if (cycle == cycleFloor + 5)
            {
                Console.WriteLine("10 döngü sonra yerdeki tüm eşyalar silinecektir!");
            }

            if (cycle == cycleFloor + 10)
            {
                Console.WriteLine("5 döngü sonra yerdeki tüm eşyalar silinecektir!");
            }

            if (cycle >= cycleFloor + 15)
            {
                floor.ClearFloor();
                countdownStarted = false; // temizlikten sonra sistem sıfırlansın
                Console.WriteLine("Yerdeki tüm eşyalar silindi!");
            }
        }
        else
        {
            // Yerde eşya yoksa geri sayım açık kalmasın
            countdownStarted = false;
        }
    }
}