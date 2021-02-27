using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tweaks.Items
{
	public class MegaHealingPotion : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Restores 500 health");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 26;
			item.useStyle = ItemUseStyleID.EatingUsing;
			item.useAnimation = 17;
			item.useTime = 17;
			item.useTurn = true;
			item.UseSound = SoundID.Item3;
			item.maxStack = 30;
			item.consumable = true;
			item.rare = ItemRarityID.Purple;
			item.healLife = 250;
			item.potion = true;
			item.value = Item.sellPrice(gold: 7);
		}

	}
}