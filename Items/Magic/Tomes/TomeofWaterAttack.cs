using Terraria.ID;
using Terraria.ModLoader;

namespace HecatombMod.Items.Magic.Tomes
{
	public class TomeofWaterAttack : ModItem
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Tome of Water: Damage"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Let the water kill for you");
			
		}

		public override void SetDefaults() 
		{
			item.damage = 15;
            item.knockBack = 5;
            item.crit = 10;
            item.width = 28;
			item.height = 28;
            item.useTime = 1;
            item.useAnimation = 60;
			item.shootSpeed = 10;

            item.noMelee = true;
			item.magic = true;
            item.mana = 25;

            item.value = 200;
			item.rare = 4;
            item.maxStack = 1;
	
			item.shoot = mod.ProjectileType("TomeofWaterAttackProjectile");
            item.useStyle = ItemUseStyleID.HoldingOut;
			item.UseSound = SoundID.LiquidsHoneyWater;

		}


    
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Book, 1);
            recipe.AddIngredient(ItemID.WaterGun,1);
            recipe.AddIngredient(ItemID.ManaCrystal, 10);
            recipe.AddIngredient(ItemID.Sapphire, 10);
		
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this,1);
			recipe.AddRecipe();
		}		
	}
}