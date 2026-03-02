using System.Net.Quic;
using FirstRPG.Entities.Items;

public class PlayerBag : Container
{

    private const int _capacity = 5;
    protected const string Name = "Çanta";
    public PlayerBag() : base(_capacity, Name )
    {
        
    }
   

  
    

}