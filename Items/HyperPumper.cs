using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Nebulas.Items
{
    class HyperPumper : ModItem
    {
        public override void SetStaticDefaults()
        {

            DisplayName.SetDefault("Hyper Pumper");
            Tooltip.SetDefault("Prevents you from taking damage from the next hit, recharges every 10 seconds");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = Item.sellPrice(gold: 10);
            item.rare = ItemRarityID.Lime;
            item.accessory = true;
        }
        int charge = 0;
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
         
            if(++charge > 600)
            {
                charge = 0;
                if(player.GetModPlayer<NebulaPlayer>().freehits < 1)
                {
                    CombatText.NewText(player.Hitbox, Color.DarkOrchid, "+1");
                    player.GetModPlayer<NebulaPlayer>().freehits += 1; 
                }
            }
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

