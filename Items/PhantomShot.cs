using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Nebulas.Items
{
	public class PhantomShot : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Phantom Shot");
			Tooltip.SetDefault("Goes Through Walls");
		}

		public override void SetDefaults()
		{
			item.damage = 9;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.consumable = true;
			item.knockBack = 1.5f;
			item.value = Item.sellPrice(silver: 1);
			item.rare = ItemRarityID.Green;
			item.shoot = ModContent.ProjectileType<PhantomShotProjectile>();
			item.shootSpeed = 14f;
			item.ammo = AmmoID.Bullet;
		}

	}
}