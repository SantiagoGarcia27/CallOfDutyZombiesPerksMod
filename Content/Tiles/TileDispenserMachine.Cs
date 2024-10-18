using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.Audio;
using Terraria.ID;
using CodZombiesPerksPort.Common.Utils;

namespace CodZombiesPerksPort.Content.Tiles
{
    public class TileDispenserMachine : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileShine[Type] = 1100;
            Main.tileSolid[Type] = true;
            Main.tileSolidTop[Type] = true;
            Main.tileFrameImportant[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2xX);   
            TileObjectData.newTile.LavaDeath = false;
            TileObjectData.addTile(Type);

            AddMapEntry(new Color(200, 200, 200), Language.GetText("MapObject.MetalBar")); // localized text for "Metal Bar"
        }

        public override void MouseOver(int i, int j)
        {
            Player player = Main.LocalPlayer;
            player.noThrow = 2;
            player.cursorItemIconEnabled = true;    
            player.cursorItemIconID = ItemID.GoldCoin;
            
        }
       
        public override bool RightClick(int i, int j)
        {
            SoundEngine.PlaySound(SoundID.Mech, new Vector2(i * 16, j * 16));
            if (Main.LocalPlayer.BuyItem(Item.buyPrice(0, 30, 0, 0)))
            {
                Item.NewItem(Player.GetSource_None(), new Vector2(i * 16, j * 16), new Vector2(2 * 16, 2 * 16), GlobalUtils.Perks[Main.rand.Next(GlobalUtils.Perks.Length)], 1);
            }
            return true;
        }


    
    }
}