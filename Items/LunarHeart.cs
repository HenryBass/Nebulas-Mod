using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Nebulas.Items
{
	public class LunarHeart : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lunar Heart");
			Tooltip.SetDefault("Contains the energy of the Moon Lord");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.value = Item.sellPrice(gold: 5);
			item.rare = ItemRarityID.Purple;
			item.maxStack = 9;
		}

	}
}