using Terraria;
using Terraria.ModLoader;

namespace CodZombiesPerks.Buffs;

public class QuickReviveCooldown : ModBuff
{
	public override void SetStaticDefaults()
	{
		// ((ModBuff)this).get_DisplayName().SetDefault("Quick Revive Cooldown");
		// ((ModBuff)this).get_Description().SetDefault("Quick Revive Cannot Be Drank");
		Main.buffNoTimeDisplay[Type] = true;
		Main.debuff[Type] = true;
	}

	public override void Update(Player player, ref int buffIndex)
	{
		player.GetModPlayer<SimpleModPlayer>().QuickReviveCooldown = true;
		player.ClearBuff(ModContent.BuffType<QuickReviveBuff>());
	}
}
