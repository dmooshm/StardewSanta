using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;

namespace StardewSanta
{
    public class ModEntry : Mod
    {
        public override void Entry(IModHelper helper)
        {
            helper.Events.GameLoop.DayStarted += OnDayStarted;
        }

        private void OnDayStarted(object? sender, DayStartedEventArgs e)
        {
            // Winter 25 = Christmas!
            if (Game1.currentSeason == "winter" && Game1.dayOfMonth == 25)
            {
                var item = ItemRegistry.Create("(O)david.proteinPowder_ProteinPowder", 1);

                if (item != null)
                {
                    Game1.player.addItemByMenuIfNecessary(item);
                    Game1.addHUDMessage(new HUDMessage("Merry Christmas! Santa gifted you some protein powder!", HUDMessage.newQuest_type));
                }
            }
        }
    }
}