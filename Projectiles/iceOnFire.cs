using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace sharpaxemod.Projectiles
{

    public class iceOnFire : ModProjectile
    {
        public override void SetDefaults()
        {

            projectile.width = 16;
            projectile.height = 16;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.tileCollide = true;
            projectile.penetrate = 3;
            projectile.timeLeft = 700;
            projectile.light = 0.5f;
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
                        n.AddBuff(44, 240); //debuff/buff for x/60 seconds
                        n.AddBuff(24,240);
                    }
                    else if (rand == 1)
                    {
                        int healAmount = Main.rand.Next(3);
                        owner.statLife += healAmount+2; //Gives Health
        				owner.HealEffect(healAmount+2, true); //Show sheal
                    }

                }
                }
    }
