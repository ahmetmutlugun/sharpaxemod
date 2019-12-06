using System;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace sharpaxemod.Items
{
    public class icesword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ice Sword");
            Tooltip.SetDefault("Has healing and frostburn capabilities."); //you can put anything you want between "s
        }
        public override void SetDefaults()
        {
            item.damage = 100;
            item.melee = true;
            item.width = 70;
            item.height = 70;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 1;
            item.knockBack = 8;
            item.crit = 5;
            item.value = 100000;
            item.rare = 7;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;
            item.shoot = mod.ProjectileType("pro1");
            item.shootSpeed = 10f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.YellowPhasesaber, 1); /
            recipe.AddIngredient(ItemID.AncientBattleArmorMaterial, 1);
            recipe.AddIngredient(ItemID.SandBlock, 20);
            recipe.AddTile(TileID.DemonAltar); iu
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        class MyGlobalNPC : GlobalNPC
        {
        	public override void NPCLoot(NPC npc)
        	{
        		if(npc.type == NPCID.IceQueen)
        		{
                       if (Main.rand.Next(50) == 0)
                       	Item.NewItem(npc.getRect(), mod.ItemType("icesword"));


        		}
        	}
        }
    }
}
