using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreValue
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class ObjectValues : BaseUnityPlugin
    {
        private const string modGUID = "Patt.MoreValue";
        private const string modName = "MoreValue";
        private const string modVersion = "1.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static ObjectValues Instance;

        internal ManualLogSource mls;

        void Awake()
        {
            if(Instance == null)
            {
                Instance = this;
            }

            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);
            mls.LogInfo("More Value is loading...");

            harmony.PatchAll();
            mls.LogInfo("More Value Loaded successfully!");
        }






    }
}
