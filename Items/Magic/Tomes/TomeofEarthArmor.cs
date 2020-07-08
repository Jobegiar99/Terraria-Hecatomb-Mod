using Terraria.ID;
using Terraria.ModLoader;

namespace HecatombMod.Items.Magic.Tomes
{
	public class TomeofEarthArmor : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Tome of Earth: Armor"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Become one with earth");
			
		}

		public override void SetDefaults() 
		{
            item.width = 32;
			item.height = 32;
            item.useTime = 60;
            item.useAnimation = 60;

            item.noMelee = true;
			item.magic = true;
            item.mana = 1;

            item.value = 1000;
			item.rare = 5;
            item.maxStack = 1;
	
			item.shoot = mod.ProjectileType("TomeofEarthArmorProjectile");
            item.useStyle = ItemUseStyleID.HoldingOut;
			item.UseSound = SoundID.LiquidsHoneyWater;

		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock , 1);
			/*recipe.AddIngredient(ItemID.LavaBucket, 5);
            recipe.AddIngredient(ItemID.Fireblossom,10);
            recipe.AddIngredient(ItemID.ManaCrystal, 10);
            recipe.AddIngredient(ItemID.Ruby, 10)*/;
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this,1);
			recipe.AddRecipe();
		}		
	}
}