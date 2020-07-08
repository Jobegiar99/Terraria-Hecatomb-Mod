using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using Terraria;
using Terraria.ModLoader;

namespace HecatombMod.Items.Magic.Projectiles //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{	
	public class volcanoProjectile : ModProjectile 
	{   
       
		public override void SetDefaults()
		{

            projectile.friendly = true; 
			projectile.hostile = false; 
			projectile.tileCollide = true;
			projectile.ignoreWater = false; 

            projectile.light = 0.4f;
			projectile.width = 24; 
			projectile.height = 24; 
            projectile.timeLeft = 600;
            projectile.knockBack = 5;
            projectile.aiStyle = 1;
            projectile.damage = 10;


            projectile.knockBack = 5;
			projectile.penetrate = 1; 
		   
		}


        public override void AI()
        { //The projectile's AI/ what the projectile does
            Dust.NewDust(new Vector2(projectile.position.X,projectile.position.Y),100,100,6,0,1);
            projectile.damage = 5;
            projectile.velocity.X *= 1.00001f;
            projectile.velocity.Y *= 1.00001f;
        }

    }
}
