using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using Terraria;
using Terraria.ModLoader;

namespace HecatombMod.Items.Magic.Projectiles //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{	
	public class TomeofWaterProjectile : ModProjectile 
	{   
        float speed = 5;
		public override void SetDefaults()
		{

            projectile.magic = true;
            projectile.friendly = true; 
			projectile.hostile = false; 
			projectile.tileCollide = false;
			projectile.ignoreWater = true; 

            projectile.light = 0.6f;
            projectile.aiStyle = 0;
			projectile.width = 25; 
			projectile.height = 25; 
            projectile.timeLeft = 3000;

            projectile.knockBack = 5;
			projectile.penetrate = 2; 
		   
		}


        public override void AI()
        { //The projectile's AI/ what the projectile does
            
           
            Player player = Main.player[0];
            
            projectile.position.X = - 15 + player.Center.X + (float) Math.Cos(speed);
            projectile.position.Y = -10 + player.Center.Y + (float) Math.Sin(speed);
            
                projectile.velocity.X = (speed * (float) Math.Cos(speed));
                projectile.velocity.Y = (speed * (float) Math.Sin(speed));
            

            if( projectile.timeLeft >= 2000)
                speed += 0.135f;

            else if ( projectile.timeLeft < 2000 && projectile.timeLeft > 1500)
                speed += 0.05f;

            else if ( projectile.timeLeft <= 1500 & projectile.timeLeft > 1000)
                speed -= 0.05f;

            else if ( projectile.timeLeft <= 1000)
                speed -= 0.135f;
            

        }
		public override void Kill(int timeLeft){

            Main.PlaySound(0,new Vector2(projectile.position.X, projectile.position.Y),1);

        }

    }
}
