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

            projectile.width = 20;       //projectile width
            projectile.height = 28;  //projectile height
            projectile.friendly = true;      //make that the projectile will not damage you
            projectile.melee = true;         // 
            projectile.tileCollide = false;   //make that the projectile will be destroed if it hits the terrain
            projectile.penetrate = 3;      //how many npc will penetrate
            projectile.timeLeft = 700;   //how many time this projectile has before disepire
            projectile.light = 0.2f;    // projectile light
            projectile.extraUpdates = 1;
            projectile.ignoreWater = true;   
        }
        public override void AI()           //this make that the projectile will face the corect way
        {                                                           // |
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;  
        }

         public override void OnHitNPC(NPC n, int damage, float knockback, bool crit)
                {
                    Player owner = Main.player[projectile.owner];
                    int rand = Main.rand.Next(2); //Generates an integer from 0 to 1
                    if(rand == 0)
                    {
                        n.AddBuff(44, 240); //frostburn  debuff for x/60 seconds
                    }
                    else if (rand == 1)
                    {
                        owner.statLife += 10; //Gives 5 Health
        				owner.HealEffect(5, true); //Shows you have healed by 5 health
                    }

                }
                }
    }
