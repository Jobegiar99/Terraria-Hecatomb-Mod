using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using Terraria;
using Terraria.ModLoader;

namespace HecatombMod.Items.Ranged.Projectiles  //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{	
	public class waterArrowProjectile : ModProjectile 
	{
        float pX,pY;
		public override void SetDefaults()
		{
			projectile.width = 33; //Set the hitbox width
			projectile.height = 33; //Set the hitbox height
			projectile.timeLeft = 180; //The amount of time the projectile is alive for
			projectile.penetrate = 1; //Tells the game how many enemies it can hit before being destroyed
			projectile.friendly = true; //Tells the game whether it is friendly to players/friendly npcs or not
			projectile.hostile = false; //Tells the game whether it is hostile to players or not
			projectile.tileCollide = true; //Tells the game whether or not it can collide with a tile
			projectile.ignoreWater = false; //Tells the game whether or not projectile will be affected by water
			projectile.ranged = true; //Tells the game whether it is a ranged projectile or not
			projectile.aiStyle = 1; //How the projectile works, this is no AI, it just goes a straight path
            
		}

        public override void AI()
        { //The projectile's AI/ what the projectile does

            Player owner = Main.player[projectile.owner];

            projectile.light = 0.5f;

            Projectile.NewProjectile(projectile.position.X - 10,
                                     projectile.position.Y - 15, 
                                     MathHelper.Lerp(-5f,10f,1), 
                                     MathHelper.Lerp(5f,10f,1), 
                                     22 , // 22 projectile ID
                                     10, //damage
                                     projectile.knockBack, 
                                     Main.myPlayer);
            
            pX =  projectile.position.X;
            pY =  projectile.position.Y;


        }

         public override void OnHitNPC(NPC n, int damage, float knockback, bool crit)
        {
            n.AddBuff(103,180);
        }
    }
}
