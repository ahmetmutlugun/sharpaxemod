using Terraria.ID;
using Terraria.ModLoader;

namespace sharpaxemod.Items
{
	public class diamondaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Diamond Axe");
			Tooltip.SetDefault("Made 100% with diamond!");
		}
		public override void SetDefaults()
		{
			item.damage = 12;
			item.melee = true;
			item.width = 20;
			item.height = 20;
			item.useTime = 25;
			item.useAnimation = 25;
			item.axe = 13;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Diamond, 182);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
