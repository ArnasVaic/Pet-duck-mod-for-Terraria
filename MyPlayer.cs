using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;


namespace PetDuck
{
	// ModPlayer classes provide a way to attach data to Players and act on that data. ExamplePlayer has a lot of functionality related to 
	// several effects and items in ExampleMod. See SimpleModPlayer for a very simple example of how ModPlayer classes work.
	public class MyPlayer : ModPlayer
	{
		public bool Pet = false;
		public override void ResetEffects() {
			Pet = false;
		}
	}
}
