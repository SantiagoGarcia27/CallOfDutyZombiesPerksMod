using CodZombiesPerksPort.Content.Tiles;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CodZombiesPerksPort.Content.Items.Placeable
{
    public class DispenserMachine : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Mechanical Drill");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(30);
        public override void SetDefaults()
        {
            // Vanilla has many useful methods like these, use them! This substitutes setting Item.createTile and Item.placeStyle aswell as setting a few values that are common across all placeable items
            Item.DefaultToPlaceableTile(ModContent.TileType<TileDispenserMachine>());

            Item.width = 32;
            Item.height = 32;
            Item.maxStack = 99;
            Item.rare = ItemRarityID.Purple;
            Item.value = Item.buyPrice(0, 30);
        }
    }
}
