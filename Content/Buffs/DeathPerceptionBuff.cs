using Terraria;
using Terraria.ModLoader;

namespace CodZombiesPerksPort.Content.Buffs;

public class DeathPerceptionBuff : ModBuff
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
		player.dangerSense = true;
        player.detectCreature = true;
        player.GetArmorPenetration(DamageClass.Generic) *= 1.25f;
    }
}
