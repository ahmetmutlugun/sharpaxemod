using Terraria.ID;
using Terraria.ModLoader;

namespace sharpaxemod.Items
{
    public class sandsword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sand Sword");
            Tooltip.SetDefault("Sand is overpowered"); //you can put anything you want between "s
        }
        public override void SetDefaults()
        {
            item.damage = 45;  //damage
            item.melee = true;   // if it is melee, write false if not
            item.width = 100;  // how big the item is (pixel)
            item.height = 100;  // how big item is (pixel)
            item.useTime = 15;  //how fast item it is, smaller number for faster
            item.useAnimation = 15;  //make it same as item.useTime
            item.useStyle = 1;  // 1 for sword, dont change it
            item.knockBack = 10; //knockbak
            item.crit = 5; //critical chance
            item.value = 100000; //value as copper coins
            item.rare = 4;  //rarity (-1 to 10)
            item.UseSound = SoundID.Item1;  //sound which we dont have
            item.autoReuse = true;  //auto reuse
            item.useTurn = true;  //dont touch this
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.YellowPhasesaber, 1); // item needed to craft, how much of that item u need
            recipe.AddIngredient(ItemID.AncientBattleArmorMaterial, 1); // item needed to craft, how much of that item u need
            recipe.AddIngredient(ItemID.SandBlock, 20);
            recipe.AddTile(TileID.DemonAltar); //crafting table
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

