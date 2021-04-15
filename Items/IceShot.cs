using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Nebulas.Items
{
	public class IceShot : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ice Shot");
			Tooltip.SetDefault("Inflicts the \"FrostBurn\" debuff");
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
			item.value = 10;
			item.rare = ItemRarityID.Green;
			item.shoot = ModContent.ProjectileType<IceShotProjectile>();
			item.shootSpeed = 16f;
			item.ammo = AmmoID.Bullet;
		}




    }
}