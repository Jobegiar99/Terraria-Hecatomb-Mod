using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using Terraria;
using Terraria.ModLoader;

namespace HecatombMod.Items.Ranged.Projectiles  //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{	
	public class explodingSquirrelProjectile : ModProjectile 
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

		public override void Kill(int timeLeft){
           Projectile.NewProjectile(
                projectile.position.X - 10,
                projectile.position.Y -10,
                projectile.velocity.X,
                projectile.velocity.Y,
                30,
                25,
                3,
                Main.myPlayer,
                1,
                1
            );

			NPC.NewNPC(
				(int)projectile.position.X,
				(int)projectile.position.Y,
				299
			);
        }

    }
}
