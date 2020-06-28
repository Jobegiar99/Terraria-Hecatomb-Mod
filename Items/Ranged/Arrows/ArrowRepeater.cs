using Terraria.ID;
using Terraria.ModLoader;

namespace HecatombMod.Items.Ranged.Arrows
{
	public class ArrowRepeater : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("itemHelp"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Arrows++");
			
		}

		public override void SetDefaults() 
		{
			item.damage = 9;
			item.ammo = AmmoID.Arrow;
			item.shoot = mod.ProjectileType("ArrowRepeaterProjectile");
			item.ranged = true;
			item.width = 28;
			item.height = 28;
			item.crit = 2;
			item.maxStack = 999;
			item.knockBack = 5;
			item.value = 25;
			item.rare = 2;
			item.consumable = true;
			item.UseSound = SoundID.Item1;
			

		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Timer1Second,2);
			recipe.AddIngredient(ItemID.WoodenArrow,100);
			recipe.AddIngredient(ItemID.Wire,10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this,100);
			recipe.AddRecipe();
		}		
	}
}