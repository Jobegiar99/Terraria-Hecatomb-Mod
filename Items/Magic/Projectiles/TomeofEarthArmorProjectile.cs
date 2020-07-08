using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using Terraria;
using Terraria.ModLoader;

namespace HecatombMod.Items.Magic.Projectiles //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{	
	public class TomeofEarthArmorProjectile : ModProjectile 
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
            //I need to fix the sprite
			projectile.width = 32; 
			projectile.height = 32; 
            projectile.timeLeft = 3600;
            projectile.knockBack = 5;


            projectile.knockBack = 5;
			projectile.penetrate = 10; 
		   
		}

        public override void AI()
        { //The projectile's AI/ what the projectile does
            if(projectile.timeLeft == 3600){
                Main.LocalPlayer.AddBuff(mod.BuffType("TomeofEarthArmorBuff"),3600,false);
            }
            Vector2 playerLocation = Main.LocalPlayer.Center;
            projectile.position.X = playerLocation.X - 15;
            projectile.position.Y = playerLocation.Y;
        }

    }
}
