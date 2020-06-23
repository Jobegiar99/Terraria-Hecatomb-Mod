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

        public override void AI()
        { //The projectile's AI/ what the projectile does

            Player owner = Main.player[projectile.owner];

            projectile.light = 0.5f;
            

        }
        public override bool OnTileCollide(Vector2 velocityChange)  
        {
            if( bumps > 0){
                projectile.velocity.X = -velocityChange.X * MathHelper.Lerp(0.9f,1.1f,1); //Goes in the opposite direction
                projectile.velocity.Y = -velocityChange.Y * MathHelper.Lerp(0.9f,1.1f,1); //Goes in the opposite direction
                bumps --;
                return false;
            }
            return true;
        }

    }
}
