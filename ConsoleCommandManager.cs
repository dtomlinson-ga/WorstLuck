using StardewModdingAPI;
using StardewValley;

namespace WorstLuck
{
	internal class ConsoleCommandManager
	{
		internal static void InitializeConsoleCommands()
		{
			Globals.Helper.ConsoleCommands.Add("vert.wl.printluck", "Prints luck value for the current player.", (_, _) =>
				{
					if (Context.IsWorldReady)
					{
						Log.Info($"Current player's luck value: {Game1.player.DailyLuck}");
					}
					else
					{
						Log.Warn("This command should only be used while a save is loaded.");
					}
				}
			);
		}
	}
}