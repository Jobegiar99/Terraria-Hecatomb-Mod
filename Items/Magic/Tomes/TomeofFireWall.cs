using Terraria.ID;
using Terraria.ModLoader;

namespace HecatombMod.Items.Magic.Tomes
{
	public class TomeofFireWall : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Tome of Fire: Wall"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Those who are brave enough to go through the fire will perish.");
			
		}

		public override void SetDefaults() 
		{
			item.damage = 20;
            item.crit = 1;
            item.width = 28;
			item.height = 28;
            item.useTime = 5;
            item.useAnimation = 25;
			item.knockBack = 5;

            item.noMelee = true;
			item.magic = true;
            item.mana = 30;

            item.value = 200;
			item.rare = 4;
            item.maxStack = 1;
	
			item.shoot = mod.ProjectileType("TomeofFireWallProjectile");
            item.useStyle = ItemUseStyleID.HoldingOut;
			item.UseSound = SoundID.LiquidsHoneyWater;

		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
           /* recipe.AddIngredient(ItemID.WaterGun,1);
            recipe.AddIngredient(ItemID.ManaCrystal, 10);
            recipe.AddIngredient(ItemID.Sapphire, 10);*/
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this,1);
			recipe.AddRecipe();
		}		
	}
}