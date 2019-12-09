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
            Tooltip.SetDefault("No one can heal themselves by wounding others. Or can they?");
        }
        public override void SetDefaults()
        {
            item.damage = 100;
            item.melee = true;
            item.width = 50;
            item.height = 50;
            item.useTime = 25;
            item.useAnimation = 25;
            item.useStyle = 1;
            item.knockBack = 8;
            item.crit = 5;
            item.value = 100000;
            item.rare = 7;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;
            item.shoot = mod.ProjectileType("iceCross");
            item.shootSpeed = 5f;
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
