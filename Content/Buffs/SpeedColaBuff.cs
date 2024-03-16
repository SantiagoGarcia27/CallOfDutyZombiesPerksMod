using Terraria;
using Terraria.ModLoader;

namespace CodZombiesPerks.Content.Buffs;

public class SpeedColaBuff : ModBuff
{
	public override void SetStaticDefaults()
	{
		// ((ModBuff)this).get_DisplayName().SetDefault("Speed Cola");
		// ((ModBuff)this).get_Description().SetDefault("15% Increased Movement, Build, and Mining Speed");
		Main.buffNoTimeDisplay[Type] = true;
		Main.debuff[Type] = false;
	}

	public override void Update(Player player, ref int buffIndex)
	{
		player.moveSpeed *= 1.15f;
		player.pickSpeed *= 0.85f;
		player.tileSpeed *= 0.85f;
		player.wallSpeed *= 0.85f;
	}
}
