using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using Terraria;
using Terraria.ModLoader;

namespace HecatombMod.Items.Magic.Projectiles //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{	
	public class TomeofFireVolcanoProjectile : ModProjectile 
	{   
       
		public override void SetDefaults()
		{

            projectile.magic = true;
            projectile.friendly = true; 
			projectile.hostile = false; 
			projectile.tileCollide = true;
			projectile.ignoreWater = true; 

            projectile.light = 0.6f;
            projectile.aiStyle = 0;
			projectile.width = 25; 
			projectile.height = 25; 
            projectile.timeLeft = 180;
            projectile.knockBack = 5;
            projectile.position.X = Main.MouseWorld.X;
            projectile.position.Y = Main.MouseWorld.Y;
            projectile.velocity.X = 0;
            projectile.velocity.Y = 0;


            projectile.knockBack = 5;
			projectile.penetrate = 10; 
		   
		}


        public override void AI()
        { //The projectile's AI/ what the projectile does
            Dust.NewDust(new Vector2(projectile.position.X,projectile.position.Y),100,100,6,0,1);
            if(projectile.timeLeft % 60 == 0){
                if(projectile.timeLeft == 180){
                    projectile.position.X = Main.MouseWorld.X;
                    projectile.position.Y = Main.MouseWorld.Y;
                }
                for(int i = 0; i < 20; i++){
                   
                    Projectile.NewProjectile(
                        projectile.position.X,  
                        projectile.position.Y,  
                        -10 + i,
                        -5,
                        mod.ProjectileType("volcanoProjectile"),
                        15,
                        10,
                        Main.myPlayer
                    );
                }
            }
        }

        public override void Kill(int timeLeft){



        }

    }
}
