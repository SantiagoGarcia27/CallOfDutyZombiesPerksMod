
using CodZombiesPerks.Content.Buffs;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.ModLoader;

namespace CodZombiesPerks.Content.Items.Potions;

public class QuickRevivePerk : ModItem
{
	public override void SetStaticDefaults()
	{
		// ((ModItem)this).get_Tooltip().SetDefault("Revives You Apon Death And Increases Life Regen\nLasts Until You Die\n'If You Wanna Get Up, You Need A Little Revive!'");
		// ((ModItem)this).get_DisplayName().SetDefault("Quick Revive");
	}

	public override void SetDefaults()
	{
		Item.width = 18;
		Item.height = 49;
		Item.maxStack = 99;
		 Item.UseSound = new SoundStyle($"{nameof(CodZombiesPerks)}/Content/Sounds/Item/DrinkPerk");
		Item.scale = 0.5f;
		Item.value = 500;
		Item.rare = 3;
		Item.useAnimation = 15;
		Item.useTime = 15;
		Item.useStyle = 2;
		Item.consumable = true;
	}

	public override Vector2? HoldoutOffset()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		return new Vector2(20f, 3f);
	}

	public override bool? UseItem(Player player)/* tModPorter Suggestion: Return null instead of false */
	{
		if (player.GetModPlayer<SimpleModPlayer>().QuickReviveCooldown)
		{
			return false;
		}
		player.AddBuff(ModContent.BuffType<QuickReviveBuff>(), 999999999, true);
		return true;
	}
}
