using Terraria.ID;
using Terraria.ModLoader;

namespace HecatombMod.Items.Magic.Tomes
{
	public class TomeofFireVolcano : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Tome of Fire: Volcano"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Unleash the wrath of the fire");
			
		}

		public override void SetDefaults() 
		{
			item.damage = 30;
            item.crit = 1;
            item.width = 28;
			item.height = 28;
            item.useTime = 30;
            item.useAnimation = 30;
			item.knockBack = 5;

            item.noMelee = true;
			item.magic = true;
            item.mana = 30;

            item.value = 200;
			item.rare = 4;
            item.maxStack = 1;
	
			item.shoot = mod.ProjectileType("TomeofFireVolcanoProjectile");
            item.useStyle = ItemUseStyleID.HoldingOut;
			item.UseSound = SoundID.LiquidsHoneyWater;

		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Book,1);
			recipe.AddIngredient(ItemID.LavaBucket, 5);
            recipe.AddIngredient(ItemID.Fireblossom,10);
            recipe.AddIngredient(ItemID.ManaCrystal, 10);
            recipe.AddIngredient(ItemID.Ruby, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this,1);
			recipe.AddRecipe();
		}		
	}
}