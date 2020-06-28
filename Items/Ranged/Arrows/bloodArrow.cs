using Terraria.ID;
using Terraria.ModLoader;

namespace HecatombMod.Items.Ranged.Arrows
{
	public class bloodArrow : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("itemHelp"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Make blood rain under them and shoot them to death!");
			
		}

		public override void SetDefaults() 
		{
			item.damage = 12;
			item.ammo = AmmoID.Arrow;
			item.shoot = mod.ProjectileType("bloodArrowProjectile");
			item.ranged = true;
			item.width = 33;
			item.height = 33;
			item.crit = 6;
			item.maxStack = 999;
			item.knockBack = 4;
			item.value = 25;
			item.rare = 2;
			item.consumable = true;
			item.UseSound = SoundID.Item1;

		}

		public override void AddRecipes() 
		{
			ModRecipe recipeA = new ModRecipe(mod);
            ModRecipe recipeB = new ModRecipe(mod);
			recipeA.AddIngredient(ItemID.TissueSample, 10);
			recipeA.AddIngredient(ItemID.WoodenArrow,100);
			recipeA.AddTile(TileID.WorkBenches);
			recipeA.SetResult(this,100);
			recipeA.AddRecipe();

            recipeB.AddIngredient(ItemID.UnholyArrow,1);
            recipeB.AddTile(TileID.WorkBenches);
            recipeB.SetResult(this,1);
            recipeB.AddRecipe();
            
            
		}

	}
}