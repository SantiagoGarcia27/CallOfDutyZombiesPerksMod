using CodZombiesPerks.Items.Potions;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace CodZombiesPerks;

public class ModGlobalNPC : GlobalNPC
{
	public override void OnKill(NPC npc)
	{
		bool PerkDropEligible = false;
		bool PerkDrop = false;
		int numberOfDrops = 1;
		if ((npc.type == NPCID.KingSlime) & !NPC.downedQueenBee & !NPC.downedBoss1 & !Main.hardMode & !NPC.downedBoss3)
		{
			PerkDropEligible = true;
		}
		if ((npc.type == NPCID.EyeofCthulhu) & !NPC.downedQueenBee & !NPC.downedBoss3 & !Main.hardMode)
		{
			PerkDropEligible = true;
		}
		if ((npc.type == NPCID.EyeofCthulhu) & !Main.hardMode)
		{
			PerkDropEligible = true;
		}
		if ((npc.type == NPCID.WallofFlesh) & !NPC.downedMechBossAny)
		{
			PerkDropEligible = true;
		}
		if ((npc.type == NPCID.TheDestroyer) & !NPC.downedPlantBoss)
		{
			PerkDropEligible = true;
		}
		if ((npc.type == NPCID.Spazmatism) & !NPC.downedPlantBoss)
		{
			PerkDropEligible = true;
		}
		if ((npc.type == NPCID.SkeletronPrime) & !NPC.downedPlantBoss)
		{
			PerkDropEligible = true;
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
				int perkLoot = Utils.Next<int>(Main.rand, new int[5] 
				{ 
					ModContent.ItemType<JuggernogPerk>(),
					ModContent.ItemType<StaminupPerk>(),
					ModContent.ItemType<SpeedColaPerk>(),
                    ModContent.ItemType<DoubleTapPerk>(),
                    ModContent.ItemType<QuickRevivePerk>()
				});
				Item.NewItem(Item.GetSource_None(), npc.position, npc.Size, perkLoot, 1, false, 0, false, false);
			}
		}
	}
}
