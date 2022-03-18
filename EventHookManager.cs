using StardewModdingAPI.Events;
using StardewValley;

namespace WorstLuck
{
	internal class EventHookManager
	{
		internal static void InitializeEventHooks()
		{
			Globals.Helper.Events.GameLoop.DayStarted += SetLuck;
		}

		private static void SetLuck(object sender, DayStartedEventArgs e)
		{
			Game1.player.team.sharedDailyLuck.Value = -0.12f;
		}
	}
}