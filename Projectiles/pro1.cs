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

            projectile.width = 20;
            projectile.height = 28;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.tileCollide = false;
            projectile.penetrate = 3;
            projectile.timeLeft = 700;
            projectile.light = 0.2f;
            projectile.extraUpdates = 1;
            projectile.ignoreWater = true;
        }
        public override void AI()
        {
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
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
