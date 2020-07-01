using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using Terraria;
using Terraria.ModLoader;

namespace HecatombMod.Items.Magic.Projectiles //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{	
	public class TomeofWaterAttackProjectile : ModProjectile 
	{   
        float[] directions = new float[]{-1,0,1};
        float dX, dY, xDirection, angle = 0;
		public override void SetDefaults()
		{
            dX = directions[Main.rand.Next(3)];
            dY = directions[Main.rand.Next(3)];
            float[] temp = new float[]{-1,1};
            xDirection = temp[Main.rand.Next(2)];

            projectile.magic = true;
            projectile.friendly = true; 
			projectile.hostile = false; 
			projectile.tileCollide = true;
			projectile.ignoreWater = true; 

            projectile.light = 0.6f;
            projectile.aiStyle = 0;
			projectile.width = 25; 
			projectile.height = 25; 
            projectile.timeLeft = 750;


            projectile.knockBack = 5;
			projectile.penetrate = 10; 
		   
		}


        public override void AI()
        { //The projectile's AI/ what the projectile does
            if( dX == 0 && dY == 0){
                while( dX == 0 && dY == 0){

                    dX = directions[Main.rand.Next(3)];
                    if( dX == 0)
                        dY = directions[Main.rand.Next(3)];

                }
            }

            projectile.velocity.X += ((dX / 4) + (float) Math.Cos( projectile.velocity.X ) / 2) * xDirection ;
            projectile.velocity.Y += ((dY / 4) + (float) Math.Sin( projectile.velocity.X ) / 2) * xDirection;
            projectile.position.X += ((float) Math.Cos(angle) * 3   ) * xDirection;
            projectile.position.Y += ((float) Math.Sin(angle) * 0.5f) * xDirection;
            
            angle++;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit){
            projectile.velocity.X  = -projectile.velocity.X *.85f ;
            projectile.velocity.Y  = -projectile.velocity.Y *.75f;

        }

        public override bool OnTileCollide(Vector2 oldVelocity){
            projectile.velocity.X = -oldVelocity.X * .85f;
            projectile.velocity.Y = -oldVelocity.Y * .75f;
     
            return false;
        }

    }
}
