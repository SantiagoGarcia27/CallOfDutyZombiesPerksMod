using Terraria;
using Terraria.ModLoader;

namespace CodZombiesPerks.Content.Buffs;

public class DoubleTapBuff : ModBuff
{
	public override void SetStaticDefaults()
	{
		// ((ModBuff)this).get_DisplayName().SetDefault("Double Tap Root Beer");
		// ((ModBuff)this).get_Description().SetDefault("33% Increased Weapon Speed");
		Main.buffNoTimeDisplay[Type] = true;
		Main.debuff[Type] = false;
	}

	public override void Update(Player player, ref int buffIndex)
	{
		player.GetModPlayer<SimpleModPlayer>().DoubleTap = true;
	}
}
