using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using Terraria;
using Terraria.ModLoader;

namespace HecatombMod.Items.Ranged.Projectiles  //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{	
	public class grenadeArrowProjectile : ModProjectile 
	{   
   
		public override void SetDefaults()
		{
			projectile.width = 33; //Set the hitbox width
			projectile.height = 33; //Set the hitbox height
            projectile.timeLeft = 2400;
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

            

            int DustRed = Dust.NewDust(
                new Vector2(projectile.position.X, projectile.position.Y + 2f), 
                projectile.width + 4, projectile.height + 4, 
                6, 
                projectile.velocity.X * 0.2f, 
                projectile.velocity.Y * 0.2f, 
                120,
                default(Color), 
                0.75f); //Spawns dust
        

            

        }

        public override void Kill(int timeLeft){
            Player owner = Main.player[projectile.owner];
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

            Projectile.NewProjectile(
                projectile.position.X - 5,
                projectile.position.Y -10,
                projectile.velocity.X,
                projectile.velocity.Y,
                30,
                20,
                3,
                Main.myPlayer,
                1,
                1
            );

            Projectile.NewProjectile(
                projectile.position.X ,
                projectile.position.Y -10,
                projectile.velocity.X,
                projectile.velocity.Y,
                30,
                15,
                3,
                Main.myPlayer,
                1,
                1
            );

            Projectile.NewProjectile(
                projectile.position.X + 5,
                projectile.position.Y -10,
                projectile.velocity.X,
                projectile.velocity.Y,
                30,
                10,
                3,
                Main.myPlayer,
                1,
                1
            );

            Projectile.NewProjectile(
                projectile.position.X + 10,
                projectile.position.Y -10,
                projectile.velocity.X,
                projectile.velocity.Y,
                30,
                5,
                3,
                Main.myPlayer,
                1,
                1
            );
            Main.PlaySound(0,new Vector2(projectile.position.X, projectile.position.Y),1);
        }

    }
}
