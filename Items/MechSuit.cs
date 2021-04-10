using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Nebulas.Items
{
    public class MechSuit : ModItem
    {
        public override void SetStaticDefaults()
        {

            DisplayName.SetDefault("Mech Suit");
            Tooltip.SetDefault("Go anywhere, with style.");
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

            player.accRunSpeed = 8f;
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

            player.scope = true;
            player.rangedCrit += 10;
            player.rangedDamage += 0.1f;

            player.kbGlove = true;
            player.meleeSpeed += 0.15f;
            player.meleeDamage += 0.15f;


        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<SpaceSuit>());
            recipe.AddIngredient(ItemID.SniperScope);
            recipe.AddIngredient(ItemID.MechanicalGlove);
            recipe.AddIngredient(ItemID.SoulofMight);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}