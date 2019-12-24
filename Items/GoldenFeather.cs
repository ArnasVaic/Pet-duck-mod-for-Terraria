using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace PetDuck.Items
{
	public class GoldenFeather : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Golden Feather");
			Tooltip.SetDefault("Summons a pet duck");
		}

		public override void SetDefaults() {
			item.CloneDefaults(ItemID.ZephyrFish);
			item.shoot = ProjectileType<Projectiles.Pets.PetDuck>();
			item.buffType = BuffType<Buffs.PetDuckBuff>();
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldBar, 5);
			recipe.AddIngredient(ItemID.FallenStar, 5);
			recipe.AddIngredient(ItemID.Duck, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void UseStyle(Player player) {
			if (player.whoAmI == Main.myPlayer && player.itemTime == 0) {
				player.AddBuff(item.buffType, 3600, true);
			}
		}
	}
}