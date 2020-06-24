using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using Terraria;
using Terraria.ModLoader;

namespace HecatombMod.Items.Ranged.Projectiles  //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{	
	public class slimeArrowProjectile : ModProjectile 
	{   
        int bumps = 5;
		public override void SetDefaults()
		{
			projectile.width = 33; //Set the hitbox width
			projectile.height = 33; //Set the hitbox height
            projectile.timeLeft = 2400;
			projectile.penetrate = 1; //Tells the game how many enemies it can hit before being destroyed
			projectile.friendly = true; //Tells the game whether it is friendly to players/friendly npcs or not
			projectile.hostile = false; //Tells the game whether it is hostile to players or not
			projectile.tileCollide = true; //Tells the game whether or not it can collide with a tile
			projectile.ignoreWater = false; //Tells the game whether or not projectile will be affected by water
			projectile.ranged = true; //Tells the game whether it is a ranged projectile or not
			projectile.aiStyle = 1; //How the projectile works
            
		}
        public override bool OnTileCollide(Vector2 velocityChange)  
        {
			Projectile.NewProjectile(projectile.position.X,
									projectile.position.Y,
									projectile.velocity.X,	
									projectile.velocity.Y,
									406,
									0,
									0,
									Main.myPlayer,
									1,1);
            if( bumps > 0){
                projectile.velocity.X = -velocityChange.X * MathHelper.Lerp(0.9f,1.1f,1); //Goes in the opposite direction
                projectile.velocity.Y = -velocityChange.Y * MathHelper.Lerp(0.9f,1.1f,1); //Goes in the opposite direction
                bumps --;
                return false;
            }

			
            return true;
        }

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit){
			Projectile.NewProjectile(projectile.position.X,
									projectile.position.Y,
									projectile.velocity.X,	
									projectile.velocity.Y,
									406,
									0,
									0,
									Main.myPlayer,
									1,1);
		}
		public override void Kill(int timeLeft){
            Main.PlaySound(0,new Vector2(projectile.position.X, projectile.position.Y),1);

        }

    }
}
