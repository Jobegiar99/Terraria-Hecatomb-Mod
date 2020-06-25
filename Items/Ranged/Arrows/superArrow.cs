using Terraria.ID;
using Terraria.ModLoader;

namespace HecatombMod.Items.Ranged.Arrows
{
	public class superArrow : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("itemHelp"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Fear the true power of the arrows!");
			
		}

		public override void SetDefaults() 
		{
			item.damage = 0;
			item.ammo = AmmoID.Arrow;
			item.shoot = mod.ProjectileType("superArrowProjectile");
			item.ranged = true;
			item.width = 25;
			item.height = 25;
			item.crit = 8;
			item.maxStack = 999;
			item.knockBack = 0;
			item.value = 50;
			item.rare = 3;
			item.consumable = true;
			item.UseSound = SoundID.Item1;

		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PixieDust,5);
            recipe.AddIngredient(ItemID.WoodenArrow,200);
            recipe.AddIngredient(ItemID.Cobweb, 20);
            recipe.AddIngredient(ItemID.SoulofFright,1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this,200);
			recipe.AddRecipe();
            
		}

	}
}