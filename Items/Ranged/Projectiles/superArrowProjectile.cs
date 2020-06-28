using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using Terraria;
using Terraria.ModLoader;

namespace HecatombMod.Items.Ranged.Projectiles  //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{	
	public class superArrowProjectile : ModProjectile 
	{
		public override void SetDefaults()
		{
			projectile.width = 28; //Set the hitbox width
			projectile.height = 28; //Set the hitbox height
			projectile.timeLeft = 600; //The amount of time the projectile is alive for
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

            projectile.light = 0.9f;


        }

        public override void Kill(int timeLeft){
            Main.PlaySound(0,new Vector2(projectile.position.X, projectile.position.Y),1);
            for(int i = 0; i < 4;i++){
                for(int j = 0; j <= 8; j++){
                    Projectile.NewProjectile(
                        projectile.position.X + (40 - (j * 10)),
                        projectile.position.Y - (i * 20),
                        projectile.velocity.X,
                        projectile.velocity.Y,
                        1,
                        5,
                        1,
                        Main.myPlayer,
                        0,
                        0
                    );
                }
            }

        }
    }
}