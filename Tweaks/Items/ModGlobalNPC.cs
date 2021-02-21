using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tweaks.Items
{
    public class ModGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (npc.type == NPCID.MoonLordCore)
            {
                if (!world.spawnLuminite)
                {
                    Main.NewText("The world has been blessed with Luminite", 200, 200, 55);
                    for (int k = 0; k < (int)((double)(WorldGen.rockLayer * Main.maxTilesY) * 100E-05); k++)
                    {
                        int X = WorldGen.genRand.Next(0, Main.maxTilesX);
                        int Y = WorldGen.genRand.Next((int)WorldGen.rockLayer, Main.maxTilesY - 260);
                        WorldGen.OreRunner(X, Y, WorldGen.genRand.Next(9, 10), WorldGen.genRand.Next(5, 9), (ushort)TileID.LunarOre);
                    }
                }
                world.spawnLuminite = true;
            }

            if (Main.rand.Next(50) == 0)
            {
                if (npc.type == NPCID.BloodZombie)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SteelSlasher"));
                }
            }
            if (Main.rand.Next(1) == 0)
            {
                if (npc.type == NPCID.MoonLordCore)
                {

                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LunarHeart"));
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("MegaHealingPotion"));
                }
            }
        }
    }
}