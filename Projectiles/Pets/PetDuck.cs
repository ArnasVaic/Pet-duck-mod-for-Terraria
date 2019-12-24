using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PetDuck.Projectiles.Pets
{
	public class PetDuck : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Duck"); // Automatic from .lang files
			Main.projFrames[projectile.type] = 8;
			Main.projPet[projectile.type] = true;
		}

		public override void SetDefaults() {
			projectile.CloneDefaults(ProjectileID.ZephyrFish);
			aiType = ProjectileID.Bunny;
		}

		public override bool PreAI() {
			Player player = Main.player[projectile.owner];
			player.bunny = false; // Relic from aiType
			return true;
		}

		public override void AI() {
			Player player = Main.player[projectile.owner];
			MyPlayer myPlayer = player.GetModPlayer<MyPlayer>();
			if (player.dead) {
				myPlayer.Pet = false;
			}
			if (myPlayer.Pet) {
				projectile.timeLeft = 2;
			}
		}
	}
}