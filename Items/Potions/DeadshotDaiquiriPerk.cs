using CodZombiesPerks.Buffs;
using Microsoft.Xna.Framework;
using Terraria.Audio;
using Terraria.ModLoader;

namespace CodZombiesPerks.Items.Potions;

public class DeadshotDaiquiriPerk : ModItem
{
	public override void SetStaticDefaults()
	{
		// ((ModItem)this).get_Tooltip().SetDefault("Increases Weapon Speed By 33%\nLasts Until You Die\n'Ya Thirsty Partner?'");
		// ((ModItem)this).get_DisplayName().SetDefault("Double Tap Root Beer");
	}

	public override void SetDefaults()
	{
		Item.width = 18;
		Item.height = 49;
		Item.maxStack = 99;
		Item.UseSound = new SoundStyle("Sounds/Item/DrinkPerk");
		Item.scale = 0.5f;
		Item.value = 500;
		Item.rare = 3;
		Item.useAnimation = 15;
		Item.useTime = 15;
		Item.useStyle = 2;
		Item.buffType = ModContent.BuffType<DeadshotDaiquiriBuff>();
		Item.buffTime = 999999999;
		Item.consumable = true;
	}

	public override Vector2? HoldoutOffset()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		return new Vector2(20f, 3f);
	}
}
