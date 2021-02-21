using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tweaks.Items
{
	public class SteelSlasher: ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Chop up anyone in your way.");
		}

		public override void SetDefaults()
		{
			item.damage = 16;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.knockBack = 6;
			item.value = Item.buyPrice(silver: 50);
			item.rare = ItemRarityID.Blue;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.crit = 6;

			item.useStyle = ItemUseStyleID.SwingThrow;
		}

	}
}