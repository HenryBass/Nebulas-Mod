using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;

namespace Nebulas
{
    class NebulaPlayer : ModPlayer
    {
        public int freehits = 0;
 
        public override bool PreHurt(bool pvp, bool quiet, ref int damage, ref int hitDirection, ref bool crit, ref bool customDamage, ref bool playSound, ref bool genGore, ref PlayerDeathReason damageSource)
        {
            if (freehits > 0)
            {
                CombatText.NewText(player.Hitbox, Color.DarkRed, "-1");
                damage = 0;
                freehits--;
                player.statDefense = 99999999;
                player.immune = true;
                player.immuneTime = 120;
                return false;
            }
            return base.PreHurt(pvp, quiet, ref damage, ref hitDirection, ref crit, ref customDamage, ref playSound, ref genGore, ref damageSource);

        }
    }
}
