using Terraria;
using Terraria.ModLoader;

namespace CodZombiesPerks.Buffs;

public class QuickReviveBuff : ModBuff
{
	public override void SetStaticDefaults()
	{
		// ((ModBuff)this).get_DisplayName().SetDefault("Quick Revive");
		// ((ModBuff)this).get_Description().SetDefault("Life Regen Increased, You Will Be Revived Apon Death");
		Main.buffNoTimeDisplay[Type] = true;
		Main.debuff[Type] = false;
	}

	public override void Update(Player player, ref int buffIndex)
	{
		player.GetModPlayer<SimpleModPlayer>().QuickRevive = true;
		player.lifeRegen = (int)((float)player.lifeRegen * 2f);
	}
}
