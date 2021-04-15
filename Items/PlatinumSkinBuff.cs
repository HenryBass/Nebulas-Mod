using Terraria;
using Terraria.ModLoader;

namespace Nebulas.Items
{
    public class PlatinumSkinBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Platinum Skin");
            Description.SetDefault("Grants +16 defense.");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.statDefense += 16;
        }
    }
}