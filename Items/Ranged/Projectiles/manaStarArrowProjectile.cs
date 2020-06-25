using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using Terraria;
using Terraria.ModLoader;

namespace HecatombMod.Items.Ranged.Projectiles  //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{	
	public class manaStarArrowProjectile : ModProjectile 
	{   
   
		public override void SetDefaults()
		{
			projectile.width = 33; //Set the hitbox width
			projectile.height = 33; //Set the hitbox height
            projectile.timeLeft = 180;
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

            int[]  xs = new int[]{-1,0,1};
            int[]  ys = new int[]{-1,0,1};

            int DustRed = Dust.NewDust(
                new Vector2(projectile.position.X, projectile.position.Y + 2f), 
                projectile.width + 80, 
                projectile.height + 80, 
                15, 
                projectile.velocity.X , 
                projectile.velocity.Y , 
                120,
                default(Color), 
                0.75f); //Spawns dust
            
            if( projectile.timeLeft % 13 == 0){
                Projectile.NewProjectile(
                                        projectile.position.X,
                                        projectile.position.Y,
                                        projectile.velocity.X * 4,
                                        projectile.velocity.Y * 4 ,
                                        9,
                                        15,
                                        1,
                                        Main.myPlayer,
                                        0,0);
            }
            if( projectile.timeLeft % 16 == 0){
                Projectile.NewProjectile(
                                        projectile.position.X,
                                        projectile.position.Y,
                                        projectile.velocity.X * 4,
                                        projectile.velocity.Y * 4 ,
                                        12,
                                        15,
                                        1,
                                        Main.myPlayer,
                                        0,0);
            }
        }

        public override void Kill(int timeLeft){
            Main.PlaySound(0,new Vector2(projectile.position.X, projectile.position.Y),1);
        }

    }
}
