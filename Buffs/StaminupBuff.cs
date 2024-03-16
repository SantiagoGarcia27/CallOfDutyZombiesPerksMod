using Terraria;
using Terraria.ModLoader;

namespace CodZombiesPerks.Buffs;

public class StaminupBuff : ModBuff
{
	public override void SetStaticDefaults()
	{
		// ((ModBuff)this).get_DisplayName().SetDefault("Stamin-up");
		// ((ModBuff)this).get_Description().SetDefault("33% Increased Movement Speed");
		Main.buffNoTimeDisplay[Type] = true;
		Main.debuff[Type] = false;
	}

	public override void Update(Player player, ref int buffIndex)
	{
		player.moveSpeed *= 1.33f;
	}
}
