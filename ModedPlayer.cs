using sharpaxemod.Buffs;
using sharpaxemod.Items;
using sharpaxemod.Projectiles;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using static Terraria.ModLoader.ModContent;

namespace sharpaxemod
{
	// ModPlayer classes provide a way to attach data to Players and act on that data. ModedPlayer has a lot of functionality related to
	// several effects and items in ExampleMod. See SimpleModPlayer for a very simple example of how ModPlayer classes work.
	public class ModedPlayer : ModPlayer
	{
		public bool BalloonMaxPet;


		public override void ResetEffects() {
			BalloonMaxPet = false;

		}



	}
}
