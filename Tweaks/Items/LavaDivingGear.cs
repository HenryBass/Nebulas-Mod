using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tweaks.Items
{
    public class LavaDivingGear : ModItem
    {
        public override void SetStaticDefaults()
        {

            DisplayName.SetDefault("Lava Diving Gear");
            Tooltip.SetDefault("Go to the deepest depths.");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = Item.sellPrice(gold:10);
            item.rare = ItemRarityID.Lime;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.waterWalk = true;
            player.fireWalk = true;
            player.lavaMax += 480;
            player.lavaRose = true;

            player.accRunSpeed = 7f;
            player.rocketBoots = 3;
            player.moveSpeed += 0.1f;
            player.arcticDivingGear = true;
            player.accFlipper = true;
            player.accDivingHelm = true;
            player.iceSkate = true;

            player.AddBuff(BuffID.Shine, 180, false);

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<lavaspark>());
            recipe.AddIngredient(ItemID.ArcticDivingGear);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}