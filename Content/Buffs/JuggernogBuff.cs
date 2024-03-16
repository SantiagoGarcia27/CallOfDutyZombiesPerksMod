using Terraria;
using Terraria.ModLoader;

namespace CodZombiesPerks.Content.Buffs;

public class JuggernogBuff : ModBuff
{
	public override void SetStaticDefaults()
	{
		// ((ModBuff)this).get_DisplayName().SetDefault("Juggernog");
		// ((ModBuff)this).get_Description().SetDefault("Max Health Increased By 40%");
		Main.buffNoTimeDisplay[Type] = true;
		Main.debuff[Type] = false;
	}

	public override void Update(Player player, ref int buffIndex)
	{
		player.statLifeMax2 = (int)((double)(float)player.statLifeMax2 * 1.4);
	}
}
