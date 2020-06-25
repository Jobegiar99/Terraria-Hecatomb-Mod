using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using Terraria;
using Terraria.ModLoader;

namespace HecatombMod.Items.Ranged.Projectiles  //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{	
	public class cloudArrowProjectile : ModProjectile 
	{   
        int bumps = 5;
		public override void SetDefaults()
		{
			projectile.width = 33; //Set the hitbox width
			projectile.height = 33; //Set the hitbox height
            projectile.timeLeft = 2400;
            projectile.knockBack = 100000000;
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

			if( projectile.timeLeft % 10 == 0 ){

				Projectile.NewProjectile(
					projectile.position.X,
					projectile.position.Y,
					projectile.velocity.X * 5,
					projectile.velocity.Y * 5,
					mod.ProjectileType("windPushProjectile"),
					1,
					10000000000000000000,
					Main.myPlayer,
					8
					);

				Main.PlaySound(16, new Vector2(projectile.position.X,projectile.position.Y),1);
			}

        }
		public override void Kill(int timeLeft){
            Main.PlaySound(0,new Vector2(projectile.position.X, projectile.position.Y),1);

        }

    }
}
