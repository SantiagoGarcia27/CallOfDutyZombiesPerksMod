using CodZombiesPerksPort.Content.Items.Potions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CodZombiesPerksPort.Common.Utils
{
    public class GlobalUtils
    {
        public static readonly int[] Perks =
        [
            ModContent.ItemType<JuggernogPerk>(), ModContent.ItemType<QuickRevivePerk>(), ModContent.ItemType<StaminupPerk>(),
            ModContent.ItemType<SpeedColaPerk>(), ModContent.ItemType<DoubleTapPerk>(), ModContent.ItemType<DeadshotDaiquiriPerk>(),
            ModContent.ItemType<DeathPerceptionPerk>()
        ];
        
        public static bool HasItem(int item,ref int slot)
        {
            for(int i = 0; i < 58; i++)
            {
                if (Main.LocalPlayer.inventory[i].type == item)
                {
                    slot = i;
                    return true;
                }
            }
            slot = -1;
            return false;
        }
        public static void DecreaseStack(int slot,int ammount)
        {
            if(Main.LocalPlayer.inventory[slot].stack <= ammount)
            {
                Main.LocalPlayer.inventory[slot].stack -= ammount;
            }
        }

    }
}
