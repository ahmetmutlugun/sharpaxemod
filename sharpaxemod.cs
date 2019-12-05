using Terraria.ModLoader;

namespace sharpaxemod
{
	class sharpaxemod : Mod
	{
		public sharpaxemod()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
