using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tweaks.Items
{
	public class TerraHeart : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Terra Heart");
			Tooltip.SetDefault("Contains the energy of the Wall of Flesh");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.value = Item.sellPrice(gold: 5);
			item.rare = ItemRarityID.LightRed;
			item.maxStack = 9;
		}

	}
}