using Terraria.ID;
using Terraria.ModLoader;

namespace HecatombMod.Items.Ranged.Arrows
{
	public class waterArrow : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("itemHelp"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Soak your enemies to death!");
			
		}

		public override void SetDefaults() 
		{
			item.damage = 12;
			item.ammo = AmmoID.Arrow;
			item.shoot = mod.ProjectileType("waterArrowProjectile");
			item.ranged = true;
			item.width = 33;
			item.height = 33;
			item.crit = 4;
			item.maxStack = 999;
			item.knockBack = 5;
			item.value = 25;
			item.rare = 2;
			item.UseSound = SoundID.Item1;

		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WoodenArrow, 25);
			recipe.AddIngredient(ItemID.BottledWater,5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this,25);
			recipe.AddRecipe();
		}

		
	}
}