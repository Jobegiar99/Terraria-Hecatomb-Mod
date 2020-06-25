using Terraria.ID;
using Terraria.ModLoader;

namespace HecatombMod.Items.Ranged.Arrows
{
	public class manaStarArrow : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("itemHelp"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Hope they are able to make a wish before they die...");
			
		}

		public override void SetDefaults() 
		{
			item.damage = 15;
			item.ammo = AmmoID.Arrow;
			item.shoot = mod.ProjectileType("manaStarArrowProjectile");
			item.ranged = true;
			item.width = 33;
			item.height = 33;
			item.crit = 2;
			item.maxStack = 999;
			item.knockBack = 4;
			item.value = 25;
			item.rare = 2;
			item.consumable = true;
			item.UseSound = SoundID.Item1;

		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock,1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this,100);
			recipe.AddRecipe();
            
            
		}

	}
}