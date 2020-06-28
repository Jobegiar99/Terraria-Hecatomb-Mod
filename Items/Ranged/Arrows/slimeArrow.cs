using Terraria.ID;
using Terraria.ModLoader;

namespace HecatombMod.Items.Ranged.Arrows
{
	public class slimeArrow : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("itemHelp"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Boing!");
			
		}

		public override void SetDefaults() 
		{
			item.damage = 8;
			item.ammo = AmmoID.Arrow;
			item.shoot = mod.ProjectileType("slimeArrowProjectile");
			item.ranged = true;
			item.width = 33;
			item.height = 33;
			item.crit = 8;
			item.maxStack = 999;
			item.knockBack = 2;
			item.value = 25;
			item.consumable = true;
			item.rare = 2;
			item.UseSound = SoundID.Item1;

		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WoodenArrow,100);
			recipe.AddIngredient(ItemID.Gel,10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this,100);
			recipe.AddRecipe();
		}
		
	}
}