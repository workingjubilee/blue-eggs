using System;
using StardewModdingAPI;
namespace BlueEggs
{
    // Technically, all that this mod does can be achieved using ContentPatcher
    // as well as JsonAssets and a few other things, however...
    // this mod is deliberately constructed as an experiment in modding AND
    // so that it is not dependent on other mods for running in the game!
    // multiple dependencies seem to be required, this acts in one swoop!
    public class ModEntry : Mod
    {

        // TODO: add CanLoad
        // TODO: add AssetLoader
        // TODO: slice sprites out as Texture2Ds for loading with blue eggs
        // TODO: add blue eggs to game!
        // TODO: impl and test generic egg traits
        // Egg Trait Checklist
        // [ ] usable in mayonnaise machine to produce mayonnaise
        // [ ] usable in some recipes
        // [ ] can hatch chickens from them
        // [ ] no one likes a nice egg in this trying time... 'cept Shane
        // TODO: decide on whether blue eggs only hatch blue chickens or not (not?)

        public override void Entry(IModHelper helper)
        {
            // Successful minimum build!
        }
    }
}
