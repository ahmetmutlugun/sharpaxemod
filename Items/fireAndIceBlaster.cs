using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace sharpaxemod.Items
{
	public class fireAndIceBlaster : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fire and Ice Blaster");
			Tooltip.SetDefault("Can shoot magical ice balls traveling at the speed of sound");
		}

		public override void SetDefaults()
		{
			item.damage = 80;
			item.ranged = true;
			item.width = 124;
			item.height = 44;
			item.useTime = 6;
			item.useAnimation = 18;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 2;
			item.shootSpeed = 10f;
			item.useAmmo = AmmoID.Bullet;
			item.reuseDelay = 40;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            			recipe.AddIngredient(ItemID.ShroomiteBar, 20);
									recipe.AddIngredient(ItemID.HellstoneBar, 40);
									recipe.AddIngredient(ItemID.SnowballCannon, 1);
            			recipe.AddTile(TileID.MythrilAnvil);
            			recipe.SetResult(this);
            			recipe.AddRecipe();
		}

		//66% chance not to consume ammo
		public override bool ConsumeAmmo(Player player){

			return Main.rand.NextFloat() >= .66f;
		}

		//Replace projectiles with custom ammo
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			if (type == ProjectileID.Bullet) // or ProjectileID.WoodenArrowFriendly
			{
				type =mod.ProjectileType("iceOnFire");; // or ProjectileID.FireArrow;
			}
			return true;
		}


		//Inaccuracy
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(20));
			speedX = perturbedSpeed.X;
			speedY = perturbedSpeed.Y;
			return true;
		}



		// Adjust position on hand
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(2, 5);
		}

		// How can I make the shots appear out of the muzzle exactly?
		// Also, when I do this, how do I prevent shooting through tiles?
		/*public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 25f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
			{
				position += muzzleOffset;
			}
			return true;
		}*/
	}
}
