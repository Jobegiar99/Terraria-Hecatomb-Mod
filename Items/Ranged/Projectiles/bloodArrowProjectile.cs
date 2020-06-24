using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using Terraria;
using Terraria.ModLoader;

namespace HecatombMod.Items.Ranged.Projectiles  //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{	
	public class bloodArrowProjectile : ModProjectile 
	{   
   
		public override void SetDefaults()
		{
			projectile.width = 33; //Set the hitbox width
			projectile.height = 33; //Set the hitbox height
            projectile.timeLeft = 300;
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
            int DustRed = Dust.NewDust(
                new Vector2(projectile.position.X, projectile.position.Y + 2f), 
                projectile.width + 20, projectile.height + 20, 
                5, 
                projectile.velocity.X * 0.2f, 
                projectile.velocity.Y * 0.2f, 
                120,
                default(Color), 
                0.75f); //Spawns dust
            Projectile.NewProjectile(projectile.position.X,
                                     (float) (projectile.position.Y + Math.Cos(projectile.position.Y)),
                                     -(float) (Math.Cos(projectile.velocity.X)) * 2f ,
                                     -(float) (Math.Sin(projectile.velocity.Y)) ,
                                     245,
                                     10,
                                     1,
                                     Main.myPlayer,
                                     0,0);
        }

        public override void Kill(int timeLeft){
            Main.PlaySound(0,new Vector2(projectile.position.X, projectile.position.Y),1);
        }

    }
}
