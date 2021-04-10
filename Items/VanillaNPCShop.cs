using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YourModName.NPCs
{
    public class VanillaNPCShop : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            switch (type)
            {
                case NPCID.Merchant:

                    shop.item[nextSlot].SetDefaults(mod.ItemType("FrogFood"));
                    nextSlot++;
                    break;
            }
        }
    }
}