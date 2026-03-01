namespace FirstRPG.Entities.Items.Materials
{
    public class Stone : Material
    {

    public const int Id = 1001;
    public  const string Name = "Stone";
    public  const string Description = "Yerden toplanabilen sıradan taş. Basit craft işlemlerinde kullanılır. ";
    public  const int Value = 2;
    public  const int MaxStack = 999;
    public  const string Rarity = "Low";
    public  const bool IsSellable = true;

    
        
        public Stone() : base(Id, Name, Description, Value, MaxStack, Rarity, IsSellable)
        {
         

        }
    }
}