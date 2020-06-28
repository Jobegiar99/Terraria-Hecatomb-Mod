using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using Terraria;
using Terraria.ModLoader;

namespace HecatombMod.Items.Ranged.Projectiles  //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{	
	public class partyArrowProjectile : ModProjectile 
	{   
        int bumps = 5;
		public override void SetDefaults()
		{
			projectile.width = 25; //Set the hitbox width
			projectile.height = 25; //Set the hitbox height
            projectile.timeLeft = 2400;
            projectile.knockBack = 5;
			projectile.penetrate = 1; //Tells the game how many enemies it can hit before being destroyed
			projectile.friendly = true; //Tells the game whether it is friendly to players/friendly npcs or not
			projectile.hostile = false; //Tells the game whether it is hostile to players or not
			projectile.tileCollide = true; //Tells the game whether or not it can collide with a tile
			projectile.ignoreWater = true; //Tells the game whether or not projectile will be affected by water
			projectile.ranged = true; //Tells the game whether it is a ranged projectile or not
			projectile.aiStyle = 1; //How the projectile works
            projectile.light = 1f;
            
		}
		
        public override void AI()
        { //The projectile's AI/ what the projectile does

			if( projectile.timeLeft % 15 == 0 ){
            
				Projectile.NewProjectile(
					projectile.position.X + 20,
					projectile.position.Y,
					projectile.velocity.X * 2 ,
					projectile.velocity.Y * 2,
					167,
					5,
					5,
					Main.myPlayer,1
					);
                
			}
        
            if( projectile.timeLeft % 25 == 0 ){
            
				Projectile.NewProjectile(
					projectile.position.X + 20,
					projectile.position.Y,
					projectile.velocity.X  ,
					projectile.velocity.Y ,
					168,
					5,
					5,
					Main.myPlayer
					);

                
			}

            if( projectile.timeLeft % 35 == 0 ){
            
				Projectile.NewProjectile(
					projectile.position.X + 20,
					projectile.position.Y,
					projectile.velocity.X * 3 ,
					projectile.velocity.Y * 3 ,
					169,
					5,
					5,
					Main.myPlayer
					);

                
			}

            if( projectile.timeLeft % 45 == 0 ){
            
				Projectile.NewProjectile(
					projectile.position.X + 20,
					projectile.position.Y,
					projectile.velocity.X * 0.5f ,
					projectile.velocity.Y * 0.5f ,
					170,
					5,
					5,
					Main.myPlayer
					);
			}
            if( projectile.timeLeft % 60 == 0){
                Projectile.NewProjectile(
                    projectile.position.X + 20,
                    projectile.position.Y,
                    projectile.velocity.X * 0.5f ,
                    projectile.velocity.Y * 0.5f ,
                    178,
                    0,
                    0,
                    Main.myPlayer
                );
            }
        }
		public override void Kill(int timeLeft){
            Main.PlaySound(0,new Vector2(projectile.position.X, projectile.position.Y),1);

        }

    }
}
