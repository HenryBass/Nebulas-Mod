using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tweaks.Items
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
			item.rare = 2;
			item.maxStack = 99;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 10);
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
			recipe.AddIngredient(ModContent.ItemType<LunarHeart>(), 1);
			recipe.AddIngredient(ItemID.ChlorophyteOre, 30);
			recipe.AddIngredient(ItemID.GreaterHealingPotion, 4);
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
			recipe.AddIngredient(ItemID.EnchantedSword, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.FragmentNebula, 5);
			recipe.AddRecipe();
		}
	}
}








