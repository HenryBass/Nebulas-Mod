using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Nebulas.Items
{
	public class UndeadSpirit : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Energy Flows from this spirit");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.value = Item.sellPrice(silver:10);
			item.rare = ItemRarityID.LightRed;
			item.maxStack = 9;
		}

	}
}