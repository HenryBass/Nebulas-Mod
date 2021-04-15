using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Nebulas.Items
{
    public class SpaceSuit : ModItem
    {
        public override void SetStaticDefaults()
        {

            DisplayName.SetDefault("Space Suit");
            Tooltip.SetDefault("Go anywhere.");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = Item.sellPrice(gold:20);
            item.rare = ItemRarityID.Lime;
            item.accessory = true;
        }

        public override void UpdateAccessory(Terraria.Player player, bool hideVisual)
        {
            player.waterWalk = true;
            player.fireWalk = true;
            player.lavaMax += 480;
            player.lavaRose = true;

            player.accRunSpeed = 7.25f;
            player.rocketBoots = 600;
            player.moveSpeed += 0.2f;
            player.iceSkate = true;
            player.arcticDivingGear = true;
            player.accFlipper = true;
            player.accDivingHelm = true;

            player.AddBuff(BuffID.Shine, 180, false);

            player.noFallDmg = true;

            player.blackBelt = true;
            player.dash = 2;
            player.spikedBoots = 2;

            player.autoJump = true;
            player.jumpBoost = true;

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<LavaDivingGear>());
            recipe.AddIngredient(ModContent.ItemType<FroggyCharm>());
            recipe.AddIngredient(ItemID.LuckyHorseshoe);
            recipe.AddIngredient(ItemID.FishBowl);
            recipe.AddIngredient(ItemID.MasterNinjaGear);
            recipe.AddIngredient(ItemID.FrogLeg);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}