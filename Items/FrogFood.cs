using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Nebulas.Items
{
	public class FrogFood : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Frog Food");
			Tooltip.SetDefault("I wonder if humans could eat this...");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.value = Item.sellPrice(silver:20);
			item.value = Item.buyPrice(silver:20);
			item.rare = ItemRarityID.Gray;
			item.maxStack = 999;
		}

	}
}