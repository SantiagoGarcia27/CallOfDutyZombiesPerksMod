using CodZombiesPerksPort.Content.Buffs;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace CodZombiesPerksPort;

public class SimpleModPlayer : ModPlayer
{
	public bool QuickRevive;

	public bool QuickReviveCooldown;

	public bool DoubleTap;

	public override void ResetEffects()
	{
		QuickRevive = false;
		QuickReviveCooldown = false;
		DoubleTap = false;
	}

	public override bool PreKill(double damage, int hitDirection, bool pvp, ref bool playSound, ref bool genGore, ref PlayerDeathReason damageSource)
	{	
		if (QuickRevive)
		{
			Player.statLife = Player.statLifeMax2 / 2;
			Player.ClearBuff(ModContent.BuffType<QuickReviveBuff>());
			Player.AddBuff(ModContent.BuffType<QuickReviveCooldown>(), 999999999, true);
			Main.NewText("You've Been Revived!", Color.Cyan);
			return false;
		}
		return base.PreKill(damage, hitDirection, pvp, ref playSound, ref genGore, ref damageSource);
	}

	public override float UseTimeMultiplier(Item item)
	{
		if (DoubleTap)
		{
			return 0.66f;
		}
		return 1f;
	}
}
