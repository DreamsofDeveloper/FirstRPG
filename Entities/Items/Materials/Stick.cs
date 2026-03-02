

using FirstRPG.Entities.Items.Materials;

public class Stick : Material
{   

    public const int id = 1003;
    public  const string name = "Stick";
    public  const string description = "İnce odun dalı. İlkel silahlar ve basit tariflerde kullanılır. ";
    public  const int value = 2;
    public  const int maxStack = 999;
    public  const string rarity = "Low";
    public  const bool isSellable = true;

    
    public Stick() : base(id, name, description, value, maxStack, rarity, isSellable)
    {
        
    }




}