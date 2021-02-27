using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tweaks.Items
{
    public class PlatinumSkinPotion : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Gives a large defense buff.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 26;
            item.useStyle = ItemUseStyleID.EatingUsing;
            item.useAnimation = 15;
            item.useTime = 15;
            item.useTurn = true;
            item.UseSound = SoundID.Item3;
            item.maxStack = 30;
            item.consumable = true;
            item.rare = ItemRarityID.Orange;
            item.value = Item.buyPrice(gold: 1);
            item.buffType = ModContent.BuffType<PlatinumSkinBuff>();
            item.buffTime = 28800;
        }
    }
}