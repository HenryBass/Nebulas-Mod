using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Nebulas.Items
{
	public class Rubber : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rubber");
			Tooltip.SetDefault("Flexable, but strong");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.value = Item.sellPrice(silver: 1);
			item.rare = ItemRarityID.Blue;
			item.maxStack = 999;
		}

	}
}