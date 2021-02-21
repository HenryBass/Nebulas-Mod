using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tweaks.Items
{
    [AutoloadEquip(EquipType.Shoes)]
    public class lavaspark : ModItem
    {
        public override void SetStaticDefaults()
        {
            // Thanks, https://github.com/HumanGamer!

            DisplayName.SetDefault("Lavaspark Boots");
            Tooltip.SetDefault("Allows flight, super fast running, and extra mobility on ice"
                             + "\n10% increased movement speed"
                             + "\nProvides the ability to walk on water and lava"
                             + "\nGrants immunity to fire blocks and 8 seconds of immunity to lava");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = Item.sellPrice(0, 17);
            item.rare = ItemRarityID.Lime;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.waterWalk = true;
            player.fireWalk = true;
            player.lavaMax += 480;

            player.accRunSpeed = 6.75f;
            player.rocketBoots = 3;
            player.moveSpeed += 0.1f;
            player.iceSkate = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FrostsparkBoots);
            recipe.AddIngredient(ItemID.LavaWaders);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}