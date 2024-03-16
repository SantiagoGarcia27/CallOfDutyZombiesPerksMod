using Terraria;
using Terraria.ModLoader;

namespace historicalGuns;

public class GlobalCrateFile : GlobalItem
{

	public virtual void OpenVanillaBag(string context, Player player, int arg)
	{
		if (context == "crate")
		{
			_ = 2334;
		}
	}
}
