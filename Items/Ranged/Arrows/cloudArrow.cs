using Terraria.ID;
using Terraria.ModLoader;

namespace HecatombMod.Items.Ranged.Arrows
{
	public class cloudArrow : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("itemHelp"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Have fun making your enemies fly!");
			
		}

		public override void SetDefaults() 
		{
			item.damage = 0;
			item.ammo = AmmoID.Arrow;
			item.shoot = mod.ProjectileType("cloudArrowProjectile");
			item.ranged = true;
			item.width = 33;
			item.height = 33;
			item.crit = 6;
			item.maxStack = 999;
			item.knockBack = 1000000;
			item.value = 25;
			item.rare = 2;
            item.knockBack = 5;
			item.consumable = true;
			item.UseSound = SoundID.Item1;

		}

		public override void AddRecipes() 
		{
			ModRecipe recipeA = new ModRecipe(mod);
			recipeA.AddIngredient(ItemID.Cloud, 30);
            recipeA.AddIngredient(ItemID.WoodenArrow,300);
			recipeA.AddIngredient(ItemID.SoulofFlight,30);
			recipeA.AddTile(TileID.WorkBenches);
			recipeA.SetResult(this,300);
			recipeA.AddRecipe();
            
            
		}

	}
}