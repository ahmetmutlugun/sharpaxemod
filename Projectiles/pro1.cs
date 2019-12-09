using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace sharpaxemod.Projectiles
{

    public class pro1 : ModProjectile
    {
        public override void SetDefaults()
        {

            projectile.width = 18;
            projectile.height = 25;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.tileCollide = true;
            projectile.penetrate = 3;
            projectile.timeLeft = 700;
            projectile.light = 0.3f;
            projectile.extraUpdates = 1;
            projectile.ignoreWater = true;
        }
        public override void AI()
        {
          if (Main.rand.Next(5) == 0) // only spawn 20% of the time
          {
            int choice = Main.rand.Next(3); // choose a random number: 0, 1, or 2
            if (choice == 0) // use that number to select dustID: 15, 57, or 58
          {
            choice = 15;
          }
          else if (choice == 1)
          {
            choice = 57;
          }
          else
          {
            choice = 58;
          }
          // Spawn the dust
          Dust.NewDust(projectile.position, projectile.width, projectile.height, choice, projectile.velocity.X * 0.25f, projectile.velocity.Y * 0.25f, 150, default(Color), 0.7f);
          }
          projectile.rotation += 0.3f * (float)projectile.direction;
            //projectile.rotation = projectile.velocity.ToRotation();

        }

         public override void OnHitNPC(NPC n, int damage, float knockback, bool crit)
                {
                    Player owner = Main.player[projectile.owner];
                    int rand = Main.rand.Next(2);
                    if(rand == 0)
                    {
                        n.AddBuff(44, 240); //debuff for x/60 seconds
                    }
                    else if (rand == 1)
                    {
                        owner.statLife += 3; //+5 Health
        				owner.HealEffect(3, true); //shows heal
                    }

                }
                }
    }
