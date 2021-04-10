using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Nebulas.Items
{
	public class MoonCore : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lunar Core");
			Tooltip.SetDefault("Contains the energy of the Moon Lord");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.value = 1000;
			item.rare = ItemRarityID.Green;
			item.maxStack = 99;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.AddIngredient(ModContent.ItemType<Rubber>(), 2);
			recipe.anyIronBar = true;
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.DivingHelmet);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.JungleSpores, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.JungleRose);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<LunarHeart>(), 1);
			recipe.AddIngredient(ItemID.Starfury, 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(ItemID.StarWrath);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<LunarHeart>(), 1);
			recipe.AddIngredient(ItemID.TerraBlade, 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(ItemID.Meowmere);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<LunarHeart>(), 1);
			recipe.AddIngredient(ItemID.Megashark, 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(ItemID.SDMG);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<LunarHeart>(), 1);
			recipe.AddIngredient(ItemID.Terrarian, 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(ItemID.TheEyeOfCthulhu);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<LunarHeart>(), 1);
			recipe.AddIngredient(ItemID.RazorbladeTyphoon, 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(ItemID.LunarFlareBook);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<LunarHeart>(), 1);
			recipe.AddIngredient(ItemID.ChargedBlasterCannon, 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(ItemID.LastPrism);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<LunarHeart>(), 1);
			recipe.AddIngredient(ItemID.QueenSpiderStaff, 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(ItemID.RainbowCrystalStaff);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<LunarHeart>(), 1);
			recipe.AddIngredient(ItemID.QueenSpiderStaff, 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(ItemID.MoonlordTurretStaff);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<LunarHeart>(), 1);
			recipe.AddIngredient(ItemID.RocketLauncher, 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(ItemID.FireworksLauncher);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<TerraHeart>(), 1);
			recipe.AddIngredient(ItemID.SpaceGun, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.LaserRifle);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<TerraHeart>(), 1);
			recipe.AddIngredient(ItemID.SpaceGun, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.LaserRifle);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<TerraHeart>(), 1);
			recipe.AddIngredient(ModContent.ItemType<SteelSlasher>());
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.BreakerBlade);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<TerraHeart>(), 1);
			recipe.AddIngredient(ItemID.ImpStaff, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.SummonerEmblem);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<TerraHeart>(), 1);
			recipe.AddIngredient(ItemID.WoodenArrow, 9999);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.RangerEmblem);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<TerraHeart>(), 1);
			recipe.AddIngredient(ItemID.FieryGreatsword, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.WarriorEmblem);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<TerraHeart>(), 1);
			recipe.AddIngredient(ItemID.WaterBolt, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.SorcererEmblem);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Hellstone, 20);
			recipe.AddIngredient(ItemID.PalladiumOre, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ModContent.ItemType<TerraHeart>());
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Hellstone, 20);
			recipe.AddIngredient(ItemID.CobaltOre, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ModContent.ItemType<TerraHeart>());
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<LunarHeart>(), 1);
			recipe.AddIngredient(ItemID.ChlorophyteOre, 30);
			recipe.AddIngredient(ItemID.SuperHealingPotion, 2);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(ModContent.ItemType<MegaHealingPotion>(), 2);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarOre, 20);
			recipe.AddIngredient(ItemID.FragmentVortex, 5);
			recipe.AddIngredient(ItemID.FragmentNebula, 5);
			recipe.AddIngredient(ItemID.FragmentStardust, 5);
			recipe.AddIngredient(ItemID.FragmentSolar, 5);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(ModContent.ItemType<LunarHeart>(), 1);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarOre, 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(ItemID.FragmentVortex, 5);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarOre, 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(ItemID.FragmentSolar, 5);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarOre, 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(ItemID.FragmentStardust, 5);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarOre, 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(ItemID.FragmentNebula, 5);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronskinPotion, 2);
			recipe.AddIngredient(ItemID.GoldOre, 2);
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(ModContent.ItemType<PlatinumSkinPotion>(), 1);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StoneBlock, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.MusketBall, 10);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 5);
			recipe.AddTile(TileID.Solidifier);
			recipe.SetResult(ModContent.ItemType<Rubber>());
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 20);
			recipe.anyIronBar = true;
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Solidifier);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Rubber>(), 5);
			recipe.AddTile(TileID.Solidifier);
			recipe.SetResult(ItemID.Flipper);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<UndeadSpirit>(), 1);
			recipe.AddIngredient(ItemID.MusketBall, 100);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ModContent.ItemType<PhantomShot>(), 100);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IceBlock, 10);
			recipe.AddIngredient(ItemID.MusketBall, 100);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ModContent.ItemType<IceShot>(), 100);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.anyIronBar = true;
			recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.ShoeSpikes);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.anyIronBar = true;
			recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.ClimbingClaws);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 20);
			recipe.AddIngredient(ItemID.Bone, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Tabi);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.BlackBelt);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<FrogFood>(), 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ModContent.ItemType<FroggyCharm>(), 1);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<FrogFood>(), 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.FrogLeg, 1);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Hellstone, 10);
			recipe.AddIngredient(ItemID.Obsidian, 20);
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(ItemID.LavaCharm, 1);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Glowstick, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.JellyfishNecklace, 1);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.anyIronBar = true;
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Aglet, 1);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 1);
			recipe.AddIngredient(ItemID.Silk, 10);
			recipe.anyIronBar = true;
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.IceSkates, 1);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.AddIngredient(ModContent.ItemType<Rubber>(), 5);
			recipe.anyIronBar = true;
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.WaterWalkingBoots, 1);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 1);
			recipe.AddIngredient(ItemID.JungleSpores);
			recipe.anyIronBar = true;
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.AnkletoftheWind, 1);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WhiteString, 1);
			recipe.AddIngredient(ModContent.ItemType<Rubber>(), 10);
			recipe.anyIronBar = true;
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.ShinyRedBalloon, 1);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldBar, 10);
			recipe.AddIngredient(ItemID.Cloud, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.LuckyHorseshoe, 1);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PlatinumBar, 10);
			recipe.AddIngredient(ItemID.Cloud, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.LuckyHorseshoe, 1);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Hellstone, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.MagmaStone, 1);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.JungleSpores, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.FeralClaws, 1);
			recipe.AddRecipe(); 

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Rubber>(), 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.FeralClaws, 1);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LihzahrdBrick, 20);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.EyeoftheGolem, 1);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IceBlock, 10);
			recipe.AddIngredient(ItemID.MagmaStone, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ModContent.ItemType<FrostStone>());
			recipe.AddRecipe();

		}
	}
}