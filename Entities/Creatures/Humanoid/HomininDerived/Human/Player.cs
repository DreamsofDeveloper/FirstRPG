using System;
using FirstRPG.Entities.Items;

public class Player : Humanoid
{
    private int level = 0;
     

    public Player(string name, Floor floor)
        : base(name, 100, floor, new Bag(), null, null, null, null, null, null, null, 5, false)
    {
      
    }

    public void CollectItems()
    {
        if (Floor.IsthereItems())
            Floor.GiveItems(Container);
        else
            Console.WriteLine("Yerde Toplanacak Eşya Yok..!");
    }

    public int AddPlayerInventory(Item item, int amount)
    {
        int left = Container.AddItem(item, amount);
        return left;
    }

    public int GetItemAmountInBag(ItemsId itemsId)
    {
        return Container.ItemAmount(itemsId);
    }


public void Use()
{
    Console.Write("Kullanmak istediğiniz eşyanın slot numarası: ");
    bool input = int.TryParse(Console.ReadLine(), out int slot);

    if (!input)
    {
        Console.WriteLine("Lütfen geçerli bir numara giriniz!");
        return;
    }

    Item? item = Container.GetItem(slot);

    if (item == null)
    {
        Console.WriteLine("Bu slotta eşya yok.");
        return;
    }

    if (item is Weapon weapon)
    {
        EquipWeapon(weapon, slot);
        return;
    }

    if (item is Armor armor)
    {
        EquipArmor(armor, slot);
        return;
    }

    if (item is Potion potion)
    {
        Console.WriteLine($"{potion.Name} iksiri içildi.");
        Container.RemoveItemFromSlot(slot, 1);
        return;
    }

    Console.WriteLine($"{item.Name} bu şekilde kullanılamaz.");
}




    public bool LookInBag(ItemsId itemId)
    {
        return Container.ItemExist(itemId);
    }

    public bool SpendFromBag(ItemsId itemId, int amount)
    {
        return Container.SpendFromInventory(itemId, amount);
    }
    
    public List<Item> GetAllItemsList()
    {
       return Container.ReturnAllItems();
    }
    public void ReadTheBag()
    {
        Container.Print();


        Console.WriteLine("1. Kullan        2. Yere At        3. Sil        4. Ekipmanlar        5. <--- Geri");
        Console.Write("Seçim: ");
        string? input = Console.ReadLine();

        switch (input)
        {
            case "1":
                Use();
                break;
            case "4":
                 Console.WriteLine(EquipmentsList());
                     break;

            case "5":
                break;

            default:
                Console.WriteLine("Böyle bir seçenek yok!");
                break;
        }
    }

    public override List<Item> Loots()
    {
        return new List<Item>();
    }
 private void EquipWeapon(Weapon weapon, int slot)
{
    Weapon? oldWeapon = EquippedWeapon;

    Container.RemoveItemFromSlot(slot, 1);

    if (oldWeapon != null)
    {
        Container.AddItem(oldWeapon, 1);
    }

    EquippedWeapon = weapon;
    Console.WriteLine($"{weapon.Name} kuşanıldı.");
}

private void EquipArmor(Armor armor, int slot)
{
    switch (armor.ArmorType)
    {
        case EquipmentsType.HeadArmor:
        {
            Armor? oldArmor = HeadArmor;
            Container.RemoveItemFromSlot(slot, 1);

            if (oldArmor != null)
            {
                Container.AddItem(oldArmor, 1);
            }

            HeadArmor = armor;
            RefreshShieldFromEquipment();
            break;
        }

        case EquipmentsType.ChestArmor:
        {
            Armor? oldArmor = BodyArmor;
            Container.RemoveItemFromSlot(slot, 1);

            if (oldArmor != null)
            {
                Container.AddItem(oldArmor, 1);
            }

            BodyArmor = armor;
            RefreshShieldFromEquipment();
            break;
        }

        case EquipmentsType.HandArmor:
        {
            Armor? oldArmor = HandArmor;
            Container.RemoveItemFromSlot(slot, 1);

            if (oldArmor != null)
            {
                Container.AddItem(oldArmor, 1);
            }

            HandArmor = armor;
            RefreshShieldFromEquipment();
            break;
        }

        case EquipmentsType.LegArmor:
        {
            Armor? oldArmor = LegArmor;
            Container.RemoveItemFromSlot(slot, 1);

            if (oldArmor != null)
            {
                Container.AddItem(oldArmor, 1);
            }

            LegArmor = armor;
            RefreshShieldFromEquipment();
            break;
        }

        case EquipmentsType.FeetArmor:
        {
            Armor? oldArmor = FeetArmor;
            Container.RemoveItemFromSlot(slot, 1);

            if (oldArmor != null)
            {
                Container.AddItem(oldArmor, 1);
            }

            FeetArmor = armor;
            RefreshShieldFromEquipment();
            break;
        }

        case EquipmentsType.Shield:
        {
            Armor? oldArmor = Shield;
            Container.RemoveItemFromSlot(slot, 1);

            if (oldArmor != null)
            {
                Container.AddItem(oldArmor, 1);
            }

            Shield = armor;
            RefreshShieldFromEquipment();
            break;
        }

        default:
            Console.WriteLine("Bu zırh türü desteklenmiyor.");
            return;
    }

    Console.WriteLine($"{armor.Name} giyinildi.");
}

 
public string EquipmentsList()
{
    return
        $"Head: {(HeadArmor == null ? "(Boş)" : HeadArmor.Name + " Dayanıklık: " + HeadArmor.Durability)}\n" +
        $"Body: {(BodyArmor == null ? "(Boş)" : BodyArmor.Name + " Dayanıklık: " + BodyArmor.Durability)}\n" +
        $"Hand: {(HandArmor == null ? "(Boş)" : HandArmor.Name + " Dayanıklık: " + HandArmor.Durability)}\n" +
        $"Leg: {(LegArmor == null ? "(Boş)"   : LegArmor.Name  + " Dayanıklık: " + LegArmor.Durability)}\n" +
        $"Feet: {(FeetArmor == null ? "(Boş)" : FeetArmor.Name + " Dayanıklık: " + FeetArmor.Durability)}\n" +
        $"Shield: {(Shield == null ? "(Boş)"  : Shield.Name    + " Dayanıklık: " + Shield.Durability)}\n" +
        $"Weapon: {(EquippedWeapon == null ? "(Boş)" : EquippedWeapon.Name + " Hasar: " + EquippedWeapon.Damage + " Dayanıklık: " + EquippedWeapon.Durability)}";
}


        
}