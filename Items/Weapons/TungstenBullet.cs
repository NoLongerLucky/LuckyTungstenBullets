// using LuckyTungstenBullets.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace LuckyTungstenBullets.Items.Weapons
{
	public class TungstenBullet : ModItem
	{

		public override void SetDefaults() {
			item.damage = 10;
			item.ranged = true;
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.consumable = true;
			item.knockBack = 3f;
			item.value = 15;
			item.rare = 0;
			item.shoot = ProjectileID.Bullet;
			item.shootSpeed = 5f;
			item.ammo = AmmoID.Bullet;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TungstenBar, 1);
            recipe.AddIngredient(ItemID.MusketBall, 70);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 70);
			recipe.AddRecipe();
		}
	}
}
