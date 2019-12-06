using Terraria.ID;
using Terraria.ModLoader;

namespace sharpaxemod.Items
{
    public class sandsword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sand Sword");
            Tooltip.SetDefault("Sand is overpowered");
        }
        public override void SetDefaults()
        {
            item.damage = 50;
            item.melee = true;
            item.width = 100;
            item.height = 100;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 1;
            item.knockBack = 10;
            item.crit = 5;
            item.value = 100000;
            item.rare = 4;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.YellowPhasesaber, 1);
            recipe.AddIngredient(ItemID.AncientBattleArmorMaterial, 1);
            recipe.AddIngredient(ItemID.SandBlock, 50);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
