﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria;
using Terraria.ModLoader;
using System.Threading.Tasks;
using Terraria.ID;

namespace Nebulas.Items
{
    class ModGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (npc.type == NPCID.MoonLordCore)
            {
                if (!world.spawnLuminite)
                {
                    Main.NewText("The world has been blessed with Luminite", 200, 200, 55);
                    for (int k = 0; k < (int)((double)(WorldGen.rockLayer * Main.maxTilesY) * 400E-05); k++)
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
            if (Main.rand.Next(15) == 0)
            {
                if (npc.type == NPCID.Zombie)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("UndeadSpirit"));
                }
            }
            if (Main.rand.Next(1) == 0)
            {
                if (npc.type == NPCID.MoonLordCore)
                {

                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LunarHeart"));
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("MegaHealingPotion"));
                }

                if (npc.type == NPCID.WallofFlesh)
                {

                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("TerraHeart"));
                }

                if (npc.type == NPCID.SkeletronHead)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Hellstone, 20);
                }
            }
        }
    }
}
