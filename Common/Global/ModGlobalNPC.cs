using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using CodZombiesPerksPort.Content.Items.Potions;
using CodZombiesPerksPort.Content.Items.Placeable;
using CodZombiesPerksPort.Common.Utils;

namespace CodZombiesPerksPort;

public class ModGlobalNPC : GlobalNPC
{
	public override void OnKill(NPC npc)
	{
		bool PerkDropEligible = false;
		bool PerkDrop = false;
		int numberOfDrops = 1;
		if (!Main.hardMode)
		{
			if (!NPC.downedQueenBee & !NPC.downedBoss3)
			{
				if ((npc.type == NPCID.KingSlime) && !NPC.downedBoss1)
				{
					PerkDropEligible = true;
				}
				if ((npc.type == NPCID.EyeofCthulhu))
				{
					PerkDropEligible = true;
				}
			}
			if ((npc.type == NPCID.EyeofCthulhu))
			{
				PerkDropEligible = true;
			}
		}
		if ((npc.type == NPCID.WallofFlesh) & !NPC.downedMechBossAny)
		{
			PerkDropEligible = true;
		}
		if (!NPC.downedPlantBoss)
		{
			if ((npc.type == NPCID.TheDestroyer))
			{
				PerkDropEligible = true;
			}
			if ((npc.type == NPCID.Spazmatism))
			{
				PerkDropEligible = true;
			}
			if ((npc.type == NPCID.SkeletronPrime))
			{
				PerkDropEligible = true;
			}
		}
		if ((npc.type == NPCID.Plantera) & !NPC.downedGolemBoss)
		{
			PerkDropEligible = true;
		}
		if ((npc.type == NPCID.Golem) & !NPC.downedAncientCultist)
		{
			PerkDropEligible = true;
		}
		if ((npc.type == NPCID.CultistBoss) & !NPC.downedMoonlord)
		{
			PerkDropEligible = true;
		}
		if (npc.type == NPCID.MoonLordCore)
		{
			PerkDropEligible = true;
		}
		if (npc.boss)
		{
			numberOfDrops = Main.CurrentFrameFlags.ActivePlayersCount;
		}
		if (npc.rarity > 0)
		{
			PerkDropEligible = true;
		}
		if (PerkDropEligible && Main.rand.NextBool(6))
		{
			PerkDrop = true;
		}
		if (PerkDrop)
		{
			for (int i = 0; i < numberOfDrops; i++)
			{
				Item.NewItem(Item.GetSource_None(), npc.position, npc.Size, GlobalUtils.Perks[Main.rand.Next(GlobalUtils.Perks.Length)], 1, false, 0, false, false);
			}
		}
	}
    public override void SetupTravelShop(int[] shop, ref int nextSlot)
    {
        if (Main.rand.NextBool(3))
        {
            shop[nextSlot] = ModContent.ItemType<DispenserMachine>();
            nextSlot++;
        }
    }
}
