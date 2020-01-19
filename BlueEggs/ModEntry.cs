using System;
using StardewModdingAPI;
namespace BlueEggs
{
    // Technically, all that this mod does can be achieved using ContentPatcher
    // as well as JsonAssets and a few other things, however...
    // this mod is deliberately constructed as an experiment in modding AND
    // so that it is not dependent on other mods for running in the game!
    // multiple dependencies seem to be required, this acts in one swoop!
    public class ModEntry : Mod, IAssetEditor, IAssetLoader
    {
        bool IAssetEditor.CanEdit<T>(IAssetInfo asset)
        {
            return asset.AssetNameEquals("Data/ObjectInformation") ? true : false;
        }

        /// Edit a matched asset.
        /// A helper which encapsulates metadata about an asset and enables changes to it.
        void IAssetEditor.Edit<T>(IAssetData asset)
        {
            if (asset != null && asset.AssetNameEquals("Data/ObjectInformation"))
            {
                //IDictionary<int, string> data = asset.AsDictionary<int, string>().Data;
                //foreach (int itemID in data.Keys)
                //{
                //    string[] fields = data[itemID].Split('/');
                //    fields[1] = (int.Parse(fields[1]) * 2).ToString();
                //    data[itemID] = string.Join("/", fields);
                //}


                //public void Edit<T>(IAssetData asset)
                //{
                //    IDictionary<int, string> data = asset.AsDictionary<int, string>().Data;
                //    data[999] = "... some new item string ...";
                //}
            }
        }

        /// Get whether this instance can load the initial version of the given asset.
        /// Basic metadata about the asset being loaded.
        bool IAssetLoader.CanLoad<T>(IAssetInfo asset)
        {
            return asset.AssetNameEquals("Objects/BlueEggs");
        }

        public T Load<T>(IAssetInfo asset)
        {
            if (asset != null && asset.AssetNameEquals("Objects/BlueEggs"))
            {
                return Helper.Content.Load<T>("assets/BlueEggs.png", ContentSource.ModFolder);
            }
            else
            {
                throw new InvalidOperationException($"Unexpected asset '{asset.AssetName}'.");
            }
        }


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

        //// read an image file
//        Texture2D texture = helper.Content.Load<Texture2D>("assets/texture.png", ContentSource.ModFolder);

        // read a json
//IDictionary<string, string> data = helper.Content.Load<Dictionary<string, string>>("assets/data.json", ContentSource.ModFolder);

    }
}
