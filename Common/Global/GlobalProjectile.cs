using CodZombiesPerks.Buffs;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace CodZombiesPerks.Common.Global
{
    public class CodGlobalProjectile : GlobalProjectile
    {
        public static bool DeadshotDaiquiriBuff;

        public List<int> HomminProjectiles = new List<int> {
            ProjectileID.ChlorophyteBullet,
            ProjectileID.RocketSnowmanI,
            ProjectileID.RocketSnowmanII,
            ProjectileID.RocketSnowmanIII,
            ProjectileID.RocketSnowmanIV
        };
        public override void OnSpawn(Projectile projectile, IEntitySource source)
        {
            DeadshotDaiquiriBuff = Main.player[projectile.owner].HasBuff<DeadshotDaiquiriBuff>() && projectile.CountsAsClass(DamageClass.Ranged) && !HomminProjectiles.Contains(projectile.type);
            base.OnSpawn(projectile, source);
        }
        public override void AI(Projectile projectile)
        {
            if (DeadshotDaiquiriBuff)
            {
                projectile.rotation = (float)Math.Atan2(projectile.velocity.Y, projectile.velocity.X) + 1.00f;
                projectile.rotation = projectile.velocity.ToRotation() + MathHelper.ToRadians(90f);
                float maxDetectRadius = 400f; // The maximum radius at which a projectile can detect a target
                float projSpeed = 5f; // The speed at which the projectile moves towards the target

                // Trying to find NPC closest to the projectile
                NPC closestNPC = FindClosestNPC(maxDetectRadius,projectile);
                if (closestNPC == null)
                    return;

                // If found, change the velocity of the projectile and turn it in the direction of the target
                // Use the SafeNormalize extension method to avoid NaNs returned by Vector2.Normalize when the vector is zero
                projectile.velocity = 2 * ((closestNPC.Center - projectile.Center).SafeNormalize(Vector2.Zero) * projSpeed);
                //projectile.rotation = projectile.velocity.ToRotation();
            }
            base.AI(projectile);
        }


    public NPC FindClosestNPC(float maxDetectDistance, Projectile projectile)
    {
        NPC closestNPC = null;

        // Using squared values in distance checks will let us skip square root calculations, drastically improving this method's speed.
        float sqrMaxDetectDistance = maxDetectDistance * maxDetectDistance;

        // Loop through all NPCs(max always 200)
        for (int k = 0; k < Main.maxNPCs; k++)
        {
            NPC target = Main.npc[k];

            if (target.CanBeChasedBy())
            {
                // The DistanceSquared function returns a squared distance between 2 points, skipping relatively expensive square root calculations
                float sqrDistanceToTarget = Vector2.DistanceSquared(target.Center, projectile.Center);

                // Check if it is within the radius
                if (sqrDistanceToTarget < sqrMaxDetectDistance)
                {
                    sqrMaxDetectDistance = sqrDistanceToTarget;
                    closestNPC = target;
                }
            }
        }

        return closestNPC;
    }
    public override bool InstancePerEntity => true;
    }
}
