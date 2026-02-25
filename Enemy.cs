public class Enemy
{
    
int healt = 15;
public int exp = 5;
int fallingitem; //coin, stone


public bool Dead (int damage)
    {
        healt -= damage;

        if(healt <= 0)
        {
            Console.WriteLine("Yaratık Öldü!");
            return true;

        }
        return false;
    }


}