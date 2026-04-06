using FirstRPG.Entities.Items;
using FirstRPG.Entities.Items.Materials;


namespace FirstRPG.Entities.Items
{
    public class ItemDatabase
    {
        private List<Item> items = new List<Item>();
        
       
        

        public List<Item> GetAllItems()
        {
            return items;
        
        }

// CreateItem — tam switch bloğu
// Tüm ItemsId değerleri için oluşturulmuştur.
// Weapon constructor parametreleri (sırasıyla):
//   id, name, description, goldValue, rarity, equipType,
//   damage, maxDurability, currentDurability, weight, stackSize, baseMaterial
// Armor constructor parametreleri (sırasıyla):
//   id, name, description, goldValue, rarity, equipType,
//   armor, maxDurability, currentDurability, weight, stackSize, baseMaterial
// Material constructor parametreleri (sırasıyla):
//   id, name, description, goldValue, maxStackSize, rarity, isStackable, baseMaterial

public Item CreateItem(ItemsId id)
{
    switch (id)
    {
        // ─────────────────────────────────────────────
        // MATERIALS  (1000 serisi)
        // ─────────────────────────────────────────────

        case ItemsId.Stone:
            return new Material(id, "Stone", "Basit taş", 1, 999, ItemRarity.Common, true, BaseMaterial.Stone);
            
        case ItemsId.IronIngot:
            return new Material(id, "Iron Ingot", "Demir külçesi", 12, 999, ItemRarity.Common, true, BaseMaterial.Iron);

        case ItemsId.GoldIngot:
            return new Material(id, "Gold Ingot", "Altın külçesi", 80, 500, ItemRarity.Rare, true, BaseMaterial.Gold);

        case ItemsId.CopperIngot:
            return new Material(id, "Copper Ingot", "Bakır külçesi", 8, 999, ItemRarity.Common, true, BaseMaterial.Copper);

        case ItemsId.CopperOre:
            return new Material(id, "Copper Ore", "Ham bakır cevheri", 4, 999, ItemRarity.Common, true, BaseMaterial.Copper);

        case ItemsId.Stick:
            return new Material(id, "Stick", "İnce odun dalı", 1, 999, ItemRarity.Common, true, BaseMaterial.Wood);

        case ItemsId.Wood:
            return new Material(id, "Wood", "Ağaçtan elde edilen kereste", 2, 999, ItemRarity.Common, true, BaseMaterial.Wood);

        case ItemsId.IronOre:
            return new Material(id, "Iron Ore", "Ham demir cevheri", 5, 999, ItemRarity.Common, true, BaseMaterial.Iron);


        case ItemsId.Coal:
            return new Material(id, "Coal", "Kömür; eritme fırınlarında yakıt olarak kullanılır", 3, 999, ItemRarity.Common, true, BaseMaterial.Coal);

        case ItemsId.Leather:
            return new Material(id, "Leather", "Hayvan derisinden işlenmiş deri", 8, 999, ItemRarity.Common, true, BaseMaterial.Leather);

        case ItemsId.Cloth:
            return new Material(id, "Cloth", "Basit kumaş parçası", 3, 999, ItemRarity.Common, true, BaseMaterial.Cloth);

        case ItemsId.Bone:
            return new Material(id, "Bone", "Hayvan kemiği", 2, 999, ItemRarity.Common, true, BaseMaterial.Bone);

        case ItemsId.Feather:
            return new Material(id, "Feather", "Hafif kuş tüyü; oklarda kullanılır", 3, 999, ItemRarity.Common, true, BaseMaterial.Feather);

        case ItemsId.Crystal:
            return new Material(id, "Crystal", "Şeffaf kristal parçası; sihirli eşyalarda bileşen", 20, 200, ItemRarity.Uncommon, true, BaseMaterial.Crystal);

        case ItemsId.MagicDust:
            return new Material(id, "Magic Dust", "Gizemli büyü tozu", 15, 500, ItemRarity.Uncommon, true, BaseMaterial.Arcane);

        case ItemsId.DragonScale:
            return new Material(id, "Dragon Scale", "Ejderha pulları; efsanevi zırhların hammaddesi", 500, 10, ItemRarity.Legendary, true, BaseMaterial.Scale);

        case ItemsId.SilverOre:
            return new Material(id, "Silver Ore", "Ham gümüş cevheri", 30, 999, ItemRarity.Uncommon, true, BaseMaterial.Silver);

        case ItemsId.GoldOre:
            return new Material(id, "Gold Ore", "Ham altın cevheri", 60, 500, ItemRarity.Rare, true, BaseMaterial.Gold);

        case ItemsId.Obsidian:
            return new Material(id, "Obsidian", "Volkanik camsı kaya; son derece sert", 25, 200, ItemRarity.Uncommon, true, BaseMaterial.Obsidian);

        case ItemsId.RuneStone:
            return new Material(id, "Rune Stone", "Antik runelerle kaplanmış büyülü taş", 80, 50, ItemRarity.Rare, true, BaseMaterial.Ancient);

        case ItemsId.AncientRelic:
            return new Material(id, "Ancient Relic", "Kadim bir uygarlıktan kalma eser", 200, 20, ItemRarity.Epic, true, BaseMaterial.Ancient);

        case ItemsId.SpiderSilk:
            return new Material(id, "Spider Silk", "Dev örümceklerden elde edilen sağlam ipek", 40, 300, ItemRarity.Uncommon, true, BaseMaterial.Cloth);

        case ItemsId.BeastFang:
            return new Material(id, "Beast Fang", "Güçlü bir canavarın dişi", 35, 200, ItemRarity.Uncommon, true, BaseMaterial.Fang);

        // ─────────────────────────────────────────────
        // WEAPONS — Tier 1 · Common  (Wooden / Starter)
        // ─────────────────────────────────────────────

        case ItemsId.Wooden_Sword:
            return new Weapon(id, "Wooden Sword", "Ağaçtan yapılmış basit bir kılıç", 10, ItemRarity.Common,
                EquipmentsType.Sword, 5, 20, 20, 2, 1, BaseMaterial.Wood);

        case ItemsId.Rusty_Dagger:
            return new Weapon(id, "Rusty Dagger", "Paslanmış, eski bir hançer", 8, ItemRarity.Common,
                EquipmentsType.Dagger, 4, 18, 18, 1, 1, BaseMaterial.Iron);

        case ItemsId.Old_Spear:
            return new Weapon(id, "Old Spear", "Eskimiş tahta saplı mızrak", 9, ItemRarity.Common,
                EquipmentsType.Spear, 6, 18, 18, 3, 1, BaseMaterial.Wood);

        case ItemsId.Training_Staff:
            return new Weapon(id, "Training Staff", "Yeni büyücülere mahsus alıştırma asası", 9, ItemRarity.Common,
                EquipmentsType.Staff, 4, 20, 20, 2, 1, BaseMaterial.Wood);

        case ItemsId.Farmer_Axe:
            return new Weapon(id, "Farmer Axe", "Odun kesmekte kullanılan köylü baltası", 8, ItemRarity.Common,
                EquipmentsType.Axe, 6, 22, 22, 4, 1, BaseMaterial.Iron);

        case ItemsId.Cracked_Mace:
            return new Weapon(id, "Cracked Mace", "Çatlak, eski bir topuz", 7, ItemRarity.Common,
                EquipmentsType.Spear, 5, 15, 15, 4, 1, BaseMaterial.Iron);

        case ItemsId.Hunting_Bow:
            return new Weapon(id, "Hunting Bow", "Avlanmaya uygun basit yay", 10, ItemRarity.Common,
                EquipmentsType.Bow, 5, 20, 20, 2, 1, BaseMaterial.Wood);

        case ItemsId.Wooden_Club:
            return new Weapon(id, "Wooden Club", "Ağır ahşap gürz", 6, ItemRarity.Common,
                EquipmentsType.Spear, 7, 25, 25, 5, 1, BaseMaterial.Wood);

        // ─────────────────────────────────────────────
        // WEAPONS — Tier 2 · Uncommon  (Iron)
        // ─────────────────────────────────────────────

        case ItemsId.Iron_Sword:
            return new Weapon(id, "Iron Sword", "Güvenilir demir kılıç", 50, ItemRarity.Uncommon,
                EquipmentsType.Sword, 14, 60, 60, 3, 1, BaseMaterial.Iron);

        case ItemsId.Iron_Dagger:
            return new Weapon(id, "Iron Dagger", "Hafif demir hançer", 40, ItemRarity.Uncommon,
                EquipmentsType.Dagger, 11, 50, 50, 1, 1, BaseMaterial.Iron);

        case ItemsId.Iron_Spear:
            return new Weapon(id, "Iron Spear", "Uzun demir mızrak", 45, ItemRarity.Uncommon,
                EquipmentsType.Spear, 15, 55, 55, 4, 1, BaseMaterial.Iron);

        case ItemsId.Iron_Axe:
            return new Weapon(id, "Iron Axe", "Sağlam demir balta", 48, ItemRarity.Uncommon,
                EquipmentsType.Axe, 16, 60, 60, 5, 1, BaseMaterial.Iron);

        case ItemsId.Iron_Mace:
            return new Weapon(id, "Iron Mace", "Ağır demir topuzu", 45, ItemRarity.Uncommon,
                EquipmentsType.Spear, 15, 65, 65, 6, 1, BaseMaterial.Iron);

        case ItemsId.Long_Bow:
            return new Weapon(id, "Long Bow", "Uzun menzilli yay", 50, ItemRarity.Uncommon,
                EquipmentsType.Bow, 13, 55, 55, 2, 1, BaseMaterial.Wood);

        case ItemsId.Apprentice_Staff:
            return new Weapon(id, "Apprentice Staff", "Büyü çıraklarının asası", 45, ItemRarity.Uncommon,
                EquipmentsType.Staff, 12, 50, 50, 2, 1, BaseMaterial.Wood);

        case ItemsId.Short_Warhammer:
            return new Weapon(id, "Short Warhammer", "Kısa saplı savaş çekici", 50, ItemRarity.Uncommon,
                EquipmentsType.Spear, 16, 65, 65, 6, 1, BaseMaterial.Iron);

        // ─────────────────────────────────────────────
        // WEAPONS — Tier 3 · Rare  (Steel)
        // ─────────────────────────────────────────────

        case ItemsId.Steel_Sword:
            return new Weapon(id, "Steel Sword", "Keskin çelik kılıç", 120, ItemRarity.Rare,
                EquipmentsType.Sword, 28, 100, 100, 4, 1, BaseMaterial.Steel);

        case ItemsId.Steel_Dagger:
            return new Weapon(id, "Steel Dagger", "Hızlı çelik hançer", 100, ItemRarity.Rare,
                EquipmentsType.Dagger, 22, 85, 85, 1, 1, BaseMaterial.Steel);

        case ItemsId.Steel_Spear:
            return new Weapon(id, "Steel Spear", "Dengeli çelik mızrak", 110, ItemRarity.Rare,
                EquipmentsType.Spear, 30, 95, 95, 4, 1, BaseMaterial.Steel);

        case ItemsId.Steel_Axe:
            return new Weapon(id, "Steel Axe", "Sarp çelik balta", 115, ItemRarity.Rare,
                EquipmentsType.Axe, 32, 100, 100, 5, 1, BaseMaterial.Steel);

        case ItemsId.Steel_Mace:
            return new Weapon(id, "Steel Mace", "Ezici çelik topuz", 110, ItemRarity.Rare,
                EquipmentsType.Spear, 30, 105, 105, 7, 1, BaseMaterial.Steel);

        case ItemsId.War_Bow:
            return new Weapon(id, "War Bow", "Savaş yayı; uzun menzil ve yüksek hasar", 115, ItemRarity.Rare,
                EquipmentsType.Bow, 26, 90, 90, 3, 1, BaseMaterial.Wood);

        case ItemsId.Adept_Staff:
            return new Weapon(id, "Adept Staff", "Deneyimli büyücülerin asası", 110, ItemRarity.Rare,
                EquipmentsType.Staff, 24, 85, 85, 2, 1, BaseMaterial.Steel);

        case ItemsId.Knight_GreatSword:
            return new Weapon(id, "Knight GreatSword", "Şövalyelere özgü büyük kılıç", 130, ItemRarity.Rare,
                EquipmentsType.Sword, 36, 110, 110, 7, 1, BaseMaterial.Steel);

        // ─────────────────────────────────────────────
        // WEAPONS — Tier 4 · Epic  (Named / Elite)
        // ─────────────────────────────────────────────

        case ItemsId.Dragon_Slayer:
            return new Weapon(id, "Dragon Slayer", "Ejderha avına özel yapılmış dev kılıç", 400, ItemRarity.Epic,
                EquipmentsType.Sword, 60, 160, 160, 8, 1, BaseMaterial.Steel);

        case ItemsId.Assassin_Dagger:
            return new Weapon(id, "Assassin Dagger", "Suikastçının zehirlenmiş hançeri", 380, ItemRarity.Epic,
                EquipmentsType.Dagger, 52, 140, 140, 1, 1, BaseMaterial.Steel);

        case ItemsId.Knight_Halberd:
            return new Weapon(id, "Knight Halberd", "Şövalye muhafızlarının yalman mızrağı", 390, ItemRarity.Epic,
                EquipmentsType.Spear, 62, 155, 155, 6, 1, BaseMaterial.Steel);

        case ItemsId.War_Axe:
            return new Weapon(id, "War Axe", "Savaş meydanlarında nam salmış balta", 385, ItemRarity.Epic,
                EquipmentsType.Axe, 64, 160, 160, 7, 1, BaseMaterial.Steel);

        case ItemsId.Skull_Crusher:
            return new Weapon(id, "Skull Crusher", "Düşmanları eziyet eden topuz", 375, ItemRarity.Epic,
                EquipmentsType.Spear, 62, 165, 165, 9, 1, BaseMaterial.Steel);

        case ItemsId.Elven_Bow:
            return new Weapon(id, "Elven Bow", "Elflerin efsanevi yayı", 400, ItemRarity.Epic,
                EquipmentsType.Bow, 56, 150, 150, 2, 1, BaseMaterial.Wood);

        case ItemsId.Arcane_Staff:
            return new Weapon(id, "Arcane Staff", "Arcane enerjisiyle dolu asa", 390, ItemRarity.Epic,
                EquipmentsType.Staff, 55, 145, 145, 3, 1, BaseMaterial.Arcane);

        case ItemsId.Blood_Mace:
            return new Weapon(id, "Blood Mace", "Kan büyüleriyle güçlendirilmiş topuz", 380, ItemRarity.Epic,
                EquipmentsType.Spear, 63, 160, 160, 9, 1, BaseMaterial.Iron);

        // ─────────────────────────────────────────────
        // WEAPONS — Tier 5 · Legendary
        // ─────────────────────────────────────────────

        case ItemsId.Phoenix_Blade:
            return new Weapon(id, "Phoenix Blade", "Anka kuşunun alevlerinden doğan kılıç", 1200, ItemRarity.Legendary,
                EquipmentsType.Sword, 110, 240, 240, 5, 1, BaseMaterial.Fire);

        case ItemsId.Shadow_Dagger:
            return new Weapon(id, "Shadow Dagger", "Gölgeden örülmüş, sessiz ölüm", 1100, ItemRarity.Legendary,
                EquipmentsType.Dagger, 95, 210, 210, 1, 1, BaseMaterial.Shadow);

        case ItemsId.Storm_Spear:
            return new Weapon(id, "Storm Spear", "Fırtınanın gücünü taşıyan mızrak", 1150, ItemRarity.Legendary,
                EquipmentsType.Spear, 115, 230, 230, 5, 1, BaseMaterial.Lightning);

        case ItemsId.Titan_Axe:
            return new Weapon(id, "Titan Axe", "Titanlara ait dev balta", 1200, ItemRarity.Legendary,
                EquipmentsType.Axe, 120, 250, 250, 10, 1, BaseMaterial.Adamantite);

        case ItemsId.Thunder_Hammer:
            return new Weapon(id, "Thunder Hammer", "Gök gürültüsünü içinde barındıran çekiç", 1200, ItemRarity.Legendary,
                EquipmentsType.Spear, 122, 255, 255, 12, 1, BaseMaterial.Lightning);

        case ItemsId.Celestial_Bow:
            return new Weapon(id, "Celestial Bow", "Yıldız ışığından örülmüş yay", 1150, ItemRarity.Legendary,
                EquipmentsType.Bow, 105, 225, 225, 3, 1, BaseMaterial.Light);

        case ItemsId.Archmage_Staff:
            return new Weapon(id, "Archmage Staff", "Büyücü liderinin güç asası", 1180, ItemRarity.Legendary,
                EquipmentsType.Staff, 105, 220, 220, 4, 1, BaseMaterial.Arcane);

        case ItemsId.Sunblade:
            return new Weapon(id, "Sunblade", "Güneşin saf ışığından yaratılmış kılıç", 1250, ItemRarity.Legendary,
                EquipmentsType.Sword, 118, 245, 245, 5, 1, BaseMaterial.Light);

        // ─────────────────────────────────────────────
        // WEAPONS — Tier 6 · Mythic
        // ─────────────────────────────────────────────

        case ItemsId.Void_Reaver:
            return new Weapon(id, "Void Reaver", "Boşluğun kendisinden yoğurulmuş büyük kılıç", 5000, ItemRarity.Mythic,
                EquipmentsType.Sword, 220, 400, 400, 8, 1, BaseMaterial.Shadow);

        case ItemsId.Godslayer_Dagger:
            return new Weapon(id, "Godslayer Dagger", "Tanrıları bile öldürebilen hançer", 5000, ItemRarity.Mythic,
                EquipmentsType.Dagger, 200, 380, 380, 1, 1, BaseMaterial.Shadow);

        case ItemsId.Leviathan_Spear:
            return new Weapon(id, "Leviathan Spear", "Okyanus canavarının ruhunu taşıyan mızrak", 5000, ItemRarity.Mythic,
                EquipmentsType.Spear, 230, 410, 410, 7, 1, BaseMaterial.Ancient);

        case ItemsId.World_Breaker:
            return new Weapon(id, "World Breaker", "Dünyaları parçalamaya yetecek balta", 6000, ItemRarity.Mythic,
                EquipmentsType.Axe, 240, 420, 420, 14, 1, BaseMaterial.Ancient);

        case ItemsId.Doom_Hammer:
            return new Weapon(id, "Doom Hammer", "Kıyamet getirecek çekiç", 6000, ItemRarity.Mythic,
                EquipmentsType.Spear, 245, 430, 430, 16, 1, BaseMaterial.Ancient);

        case ItemsId.Astral_Bow:
            return new Weapon(id, "Astral Bow", "Astral boyuttan çekilen yay", 5000, ItemRarity.Mythic,
                EquipmentsType.Bow, 210, 390, 390, 4, 1, BaseMaterial.Arcane);

        case ItemsId.Cosmic_Staff:
            return new Weapon(id, "Cosmic Staff", "Kozmik enerjiyi kontrol eden asa", 5500, ItemRarity.Mythic,
                EquipmentsType.Staff, 215, 395, 395, 5, 1, BaseMaterial.Arcane);

        case ItemsId.Eclipse_Blade:
            return new Weapon(id, "Eclipse Blade", "Tutulma anında dövülmüş kılıç", 5500, ItemRarity.Mythic,
                EquipmentsType.Sword, 225, 405, 405, 7, 1, BaseMaterial.Shadow);

        case ItemsId.Infinity_Dagger:
            return new Weapon(id, "Infinity Dagger", "Sonsuzluğu içinde saklayan hançer", 5500, ItemRarity.Mythic,
                EquipmentsType.Dagger, 205, 385, 385, 1, 1, BaseMaterial.Arcane);

        case ItemsId.Chaos_Spear:
            return new Weapon(id, "Chaos Spear", "Kaos gücüyle titreşen mızrak", 5500, ItemRarity.Mythic,
                EquipmentsType.Spear, 235, 415, 415, 8, 1, BaseMaterial.Ancient);

        // ─────────────────────────────────────────────
        // ARMOR — Tier 1 · Common  (Cloth)
        // armor değerleri: Chest > Legs > Head > Hands > Feet
        // ─────────────────────────────────────────────

        case ItemsId.Cloth_Hood:
            return new Armor(id, "Cloth Hood", "Basit kumaş başlık", 10, ItemRarity.Common,
                EquipmentsType.HeadArmor, 1, 20, 20, 1, 1, BaseMaterial.Cloth);

        case ItemsId.Cloth_Robe:
            return new Armor(id, "Cloth Robe", "Basit kumaş cüppe", 12, ItemRarity.Common,
                EquipmentsType.ChestArmor, 2, 25, 25, 2, 1, BaseMaterial.Cloth);

        case ItemsId.Cloth_Gloves:
            return new Armor(id, "Cloth Gloves", "Basit kumaş eldivenler", 8, ItemRarity.Common,
                EquipmentsType.HandArmor, 1, 18, 18, 1, 1, BaseMaterial.Cloth);

        case ItemsId.Cloth_Pants:
            return new Armor(id, "Cloth Pants", "Basit kumaş pantolon", 10, ItemRarity.Common,
                EquipmentsType.LegArmor, 1, 22, 22, 1, 1, BaseMaterial.Cloth);

        case ItemsId.Cloth_Boots:
            return new Armor(id, "Cloth Boots", "Basit kumaş çizmeler", 8, ItemRarity.Common,
                EquipmentsType.FeetArmor, 1, 18, 18, 1, 1, BaseMaterial.Cloth);

        // ─────────────────────────────────────────────
        // ARMOR — Tier 2 · Uncommon  (Leather)
        // ─────────────────────────────────────────────

        case ItemsId.Leather_Cap:
            return new Armor(id, "Leather Cap", "Deri şapka", 30, ItemRarity.Uncommon,
                EquipmentsType.HeadArmor, 4, 45, 45, 1, 1, BaseMaterial.Leather);

        case ItemsId.Leather_Armor:
            return new Armor(id, "Leather Armor", "Hafif deri zırh", 40, ItemRarity.Uncommon,
                EquipmentsType.ChestArmor, 6, 55, 55, 3, 1, BaseMaterial.Leather);

        case ItemsId.Leather_Gloves:
            return new Armor(id, "Leather Gloves", "Deri eldivenler", 25, ItemRarity.Uncommon,
                EquipmentsType.HandArmor, 3, 40, 40, 1, 1, BaseMaterial.Leather);

        case ItemsId.Leather_Leggings:
            return new Armor(id, "Leather Leggings", "Deri bacak zırhı", 35, ItemRarity.Uncommon,
                EquipmentsType.LegArmor, 5, 48, 48, 2, 1, BaseMaterial.Leather);

        case ItemsId.Leather_Boots:
            return new Armor(id, "Leather Boots", "Sağlam deri çizmeler", 28, ItemRarity.Uncommon,
                EquipmentsType.FeetArmor, 3, 42, 42, 2, 1, BaseMaterial.Leather);

        // ─────────────────────────────────────────────
        // ARMOR — Tier 3 · Rare  (Iron)
        // ─────────────────────────────────────────────

        case ItemsId.Iron_Helmet:
            return new Armor(id, "Iron Helmet", "Sağlam demir kask", 80, ItemRarity.Rare,
                EquipmentsType.HeadArmor, 10, 90, 90, 4, 1, BaseMaterial.Iron);

        case ItemsId.Iron_Armor:
            return new Armor(id, "Iron Armor", "Demir göğüs zırhı", 120, ItemRarity.Rare,
                EquipmentsType.ChestArmor, 14, 120, 120, 8, 1, BaseMaterial.Iron);

        case ItemsId.Iron_Gloves:
            return new Armor(id, "Iron Gloves", "Demir eldiven", 65, ItemRarity.Rare,
                EquipmentsType.HandArmor, 7, 75, 75, 3, 1, BaseMaterial.Iron);

        case ItemsId.Iron_Leggings:
            return new Armor(id, "Iron Leggings", "Demir bacak zırhı", 90, ItemRarity.Rare,
                EquipmentsType.LegArmor, 11, 100, 100, 6, 1, BaseMaterial.Iron);

        case ItemsId.Iron_Boots:
            return new Armor(id, "Iron Boots", "Ağır demir çizmeler", 70, ItemRarity.Rare,
                EquipmentsType.FeetArmor, 8, 80, 80, 5, 1, BaseMaterial.Iron);

        // ─────────────────────────────────────────────
        // ARMOR — Tier 4 · Rare/Epic  (Steel)
        // ─────────────────────────────────────────────

        case ItemsId.Steel_Helmet:
            return new Armor(id, "Steel Helmet", "Çelik miğfer", 180, ItemRarity.Rare,
                EquipmentsType.HeadArmor, 18, 150, 150, 5, 1, BaseMaterial.Steel);

        case ItemsId.Steel_Armor:
            return new Armor(id, "Steel Armor", "Çelik göğüs zırhı", 260, ItemRarity.Rare,
                EquipmentsType.ChestArmor, 26, 190, 190, 10, 1, BaseMaterial.Steel);

        case ItemsId.Steel_Gloves:
            return new Armor(id, "Steel Gloves", "Çelik eldivenler", 140, ItemRarity.Rare,
                EquipmentsType.HandArmor, 13, 130, 130, 3, 1, BaseMaterial.Steel);

        case ItemsId.Steel_Leggings:
            return new Armor(id, "Steel Leggings", "Çelik bacak zırhı", 200, ItemRarity.Rare,
                EquipmentsType.LegArmor, 20, 165, 165, 7, 1, BaseMaterial.Steel);

        case ItemsId.Steel_Boots:
            return new Armor(id, "Steel Boots", "Çelik çizmeler", 150, ItemRarity.Rare,
                EquipmentsType.FeetArmor, 14, 135, 135, 6, 1, BaseMaterial.Steel);

        // ─────────────────────────────────────────────
        // ARMOR — Tier 5 · Epic  (Knight)
        // ─────────────────────────────────────────────

        case ItemsId.Knight_Helm:
            return new Armor(id, "Knight Helm", "Şövalye miğferi", 400, ItemRarity.Epic,
                EquipmentsType.HeadArmor, 32, 240, 240, 6, 1, BaseMaterial.Steel);

        case ItemsId.Knight_Armor:
            return new Armor(id, "Knight Armor", "Tam şövalye göğüs zırhı", 580, ItemRarity.Epic,
                EquipmentsType.ChestArmor, 48, 300, 300, 14, 1, BaseMaterial.Steel);

        case ItemsId.Knight_Gauntlets:
            return new Armor(id, "Knight Gauntlets", "Şövalye eldivenler", 320, ItemRarity.Epic,
                EquipmentsType.HandArmor, 24, 210, 210, 4, 1, BaseMaterial.Steel);

        case ItemsId.Knight_Leggings:
            return new Armor(id, "Knight Leggings", "Şövalye bacak zırhı", 450, ItemRarity.Epic,
                EquipmentsType.LegArmor, 36, 260, 260, 10, 1, BaseMaterial.Steel);

        case ItemsId.Knight_Boots:
            return new Armor(id, "Knight Boots", "Şövalye çizmeleri", 350, ItemRarity.Epic,
                EquipmentsType.FeetArmor, 26, 220, 220, 8, 1, BaseMaterial.Steel);

        // ─────────────────────────────────────────────
        // ARMOR — Tier 6 · Legendary  (Dragon)
        // ─────────────────────────────────────────────

        case ItemsId.Dragon_Helm:
            return new Armor(id, "Dragon Helm", "Ejderha pullarından yapılmış miğfer", 1200, ItemRarity.Legendary,
                EquipmentsType.HeadArmor, 60, 400, 400, 7, 1, BaseMaterial.Scale);

        case ItemsId.Dragon_Armor:
            return new Armor(id, "Dragon Armor", "Ejderha pullarından yapılmış göğüs zırhı", 1800, ItemRarity.Legendary,
                EquipmentsType.ChestArmor, 90, 500, 500, 16, 1, BaseMaterial.Scale);

        case ItemsId.Dragon_Gauntlets:
            return new Armor(id, "Dragon Gauntlets", "Ejderha pullarından yapılmış eldivenler", 950, ItemRarity.Legendary,
                EquipmentsType.HandArmor, 46, 360, 360, 5, 1, BaseMaterial.Scale);

        case ItemsId.Dragon_Leggings:
            return new Armor(id, "Dragon Leggings", "Ejderha pullarından yapılmış bacak zırhı", 1400, ItemRarity.Legendary,
                EquipmentsType.LegArmor, 70, 440, 440, 12, 1, BaseMaterial.Scale);

        case ItemsId.Dragon_Boots:
            return new Armor(id, "Dragon Boots", "Ejderha pullarından yapılmış çizmeler", 1050, ItemRarity.Legendary,
                EquipmentsType.FeetArmor, 50, 370, 370, 9, 1, BaseMaterial.Scale);

        // ─────────────────────────────────────────────
        // ARMOR — Tier 7 · Mythic  (Celestial)
        // ─────────────────────────────────────────────

        case ItemsId.Celestial_Helm:
            return new Armor(id, "Celestial Helm", "Gök ışığından dövülmüş miğfer", 4000, ItemRarity.Mythic,
                EquipmentsType.HeadArmor, 110, 700, 700, 5, 1, BaseMaterial.Light);

        case ItemsId.Celestial_Armor:
            return new Armor(id, "Celestial Armor", "Gök ışığından dövülmüş göğüs zırhı", 6000, ItemRarity.Mythic,
                EquipmentsType.ChestArmor, 165, 880, 880, 12, 1, BaseMaterial.Light);

        case ItemsId.Celestial_Gloves:
            return new Armor(id, "Celestial Gloves", "Gök ışığından dövülmüş eldivenler", 3200, ItemRarity.Mythic,
                EquipmentsType.HandArmor, 85, 640, 640, 3, 1, BaseMaterial.Light);

        case ItemsId.Celestial_Leggings:
            return new Armor(id, "Celestial Leggings", "Gök ışığından dövülmüş bacak zırhı", 4800, ItemRarity.Mythic,
                EquipmentsType.LegArmor, 130, 760, 760, 8, 1, BaseMaterial.Light);

        case ItemsId.Celestial_Boots:
            return new Armor(id, "Celestial Boots", "Gök ışığından dövülmüş çizmeler", 3600, ItemRarity.Mythic,
                EquipmentsType.FeetArmor, 95, 660, 660, 6, 1, BaseMaterial.Light);

        // ─────────────────────────────────────────────
        // ARMOR — Shields
        // ─────────────────────────────────────────────

        case ItemsId.Wooden_Shield:
            return new Armor(id, "Wooden Shield", "Basit ahşap kalkan", 15, ItemRarity.Common,
                EquipmentsType.Shield, 4, 35, 35, 4, 1, BaseMaterial.Wood);

        case ItemsId.Iron_Shield:
            return new Armor(id, "Iron Shield", "Sağlam demir kalkan", 90, ItemRarity.Rare,
                EquipmentsType.Shield, 16, 130, 130, 8, 1, BaseMaterial.Iron);

        case ItemsId.Steel_Shield:
            return new Armor(id, "Steel Shield", "Çelik kalkan", 220, ItemRarity.Rare,
                EquipmentsType.Shield, 30, 200, 200, 9, 1, BaseMaterial.Steel);

        case ItemsId.Knight_Shield:
            return new Armor(id, "Knight Shield", "Armalı şövalye kalkanı", 600, ItemRarity.Epic,
                EquipmentsType.Shield, 55, 320, 320, 11, 1, BaseMaterial.Steel);

        case ItemsId.Dragon_Shield:
            return new Armor(id, "Dragon Shield", "Ejderha pullarından yapılmış kalkan", 2000, ItemRarity.Legendary,
                EquipmentsType.Shield, 100, 520, 520, 13, 1, BaseMaterial.Scale);

        // ─────────────────────────────────────────────

        default:
            throw new Exception($"Item bulunamadı: {id}");
    }
}



    
    public String GetItemNameById(ItemsId id)
{
    Item item = CreateItem(id);
    return $"{item.Name}";
    
}

    }



public enum BaseMaterial
{
    none,

    // Natural / Basic
    Wood,
    Stone,
    Flint,
    Bone,
    Leather,
    Cloth,

    // Metals
    Copper,
    Tin,
    Bronze,
    Iron,
    Steel,
    Silver,
    Gold,
    Mithril,
    Adamantite,

    // Minerals / Crystals
    Coal,
    Obsidian,
    Crystal,
    Diamond,

    // Organic / Monster
    Hide,
    Fang,
    Claw,
    Scale,
    Feather,

    // Magical / Elemental
    Fire,
    Water,
    Ice,
    Lightning,
    Shadow,
    Light,
    Arcane,

    // Special
    Spirit,
    Ancient
}
    



public enum ItemsId
{
    none = 0,


    // Materials 1000
    Stone = 1001,
    Stick = 1002,
    Wood = 1003,
    IronIngot= 100401,
    IronOre = 1004,
    CopperIngot = 100501,
    CopperOre = 1005,
    Coal = 1006,
    Leather = 1007,
    Cloth = 1008,
    Bone = 1009,
    Feather = 1010,
    Crystal = 1011,
    MagicDust = 1012,
    DragonScale = 1013,
    SilverOre = 1014,
    GoldIngot= 101501,
    GoldOre = 1015,
    Obsidian = 1016,
    RuneStone = 1017,
    AncientRelic = 1018,
    SpiderSilk = 1019,
    BeastFang = 1020,

    // Weapons 2000
    Wooden_Sword = 2001,
    Rusty_Dagger = 2002,
    Old_Spear = 2003,
    Training_Staff = 2004,
    Farmer_Axe = 2005,
    Cracked_Mace = 2006,
    Hunting_Bow = 2007,
    Wooden_Club = 2008,

    Iron_Sword = 2009,
    Iron_Dagger = 2010,
    Iron_Spear = 2011,
    Iron_Axe = 2012,
    Iron_Mace = 2013,
    Long_Bow = 2014,
    Apprentice_Staff = 2015,
    Short_Warhammer = 2016,

    Steel_Sword = 2017,
    Steel_Dagger = 2018,
    Steel_Spear = 2019,
    Steel_Axe = 2020,
    Steel_Mace = 2021,
    War_Bow = 2022,
    Adept_Staff = 2023,
    Knight_GreatSword = 2024,

    Dragon_Slayer = 2025,
    Assassin_Dagger = 2026,
    Knight_Halberd = 2027,
    War_Axe = 2028,
    Skull_Crusher = 2029,
    Elven_Bow = 2030,
    Arcane_Staff = 2031,
    Blood_Mace = 2032,

    Phoenix_Blade = 2033,
    Shadow_Dagger = 2034,
    Storm_Spear = 2035,
    Titan_Axe = 2036,
    Thunder_Hammer = 2037,
    Celestial_Bow = 2038,
    Archmage_Staff = 2039,
    Sunblade = 2040,

    Void_Reaver = 2041,
    Godslayer_Dagger = 2042,
    Leviathan_Spear = 2043,
    World_Breaker = 2044,
    Doom_Hammer = 2045,
    Astral_Bow = 2046,
    Cosmic_Staff = 2047,
    Eclipse_Blade = 2048,
    Infinity_Dagger = 2049,
    Chaos_Spear = 2050,

    // Armor 3000
    Cloth_Hood = 3001,
    Cloth_Robe = 3002,
    Cloth_Gloves = 3003,
    Cloth_Pants = 3004,
    Cloth_Boots = 3005,

    Leather_Cap = 3006,
    Leather_Armor = 3007,
    Leather_Gloves = 3008,
    Leather_Leggings = 3009,
    Leather_Boots = 3010,

    Iron_Helmet = 3011,
    Iron_Armor = 3012,
    Iron_Gloves = 3013,
    Iron_Leggings = 3014,
    Iron_Boots = 3015,

    Steel_Helmet = 3016,
    Steel_Armor = 3017,
    Steel_Gloves = 3018,
    Steel_Leggings = 3019,
    Steel_Boots = 3020,

    Knight_Helm = 3021,
    Knight_Armor = 3022,
    Knight_Gauntlets = 3023,
    Knight_Leggings = 3024,
    Knight_Boots = 3025,

    Dragon_Helm = 3026,
    Dragon_Armor = 3027,
    Dragon_Gauntlets = 3028,
    Dragon_Leggings = 3029,
    Dragon_Boots = 3030,

    Celestial_Helm = 3031,
    Celestial_Armor = 3032,
    Celestial_Gloves = 3033,
    Celestial_Leggings = 3034,
    Celestial_Boots = 3035,

    Wooden_Shield = 3036,
    Iron_Shield = 3037,
    Steel_Shield = 3038,
    Knight_Shield = 3039,
    Dragon_Shield = 3040
}

     public enum ItemType
    {
        Potion,
        Weapon,
        Armor,
        Material
    }

    public enum ItemRarity
{
    Common,
    Uncommon,
    Rare,
    Epic,
    Legendary,
    Mythic
}
    public enum EquipmentsType
    {
        //Armor
        HeadArmor,
        ChestArmor,
        HandArmor,
        LegArmor,
        FeetArmor,
        Shield,



        //Weapon 
        Sword,
        Axe,
        Bow,
        Staff,
        Dagger,
        Spear,
        Shovel


    }


 
}