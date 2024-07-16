using System;
using BepInEx;

namespace DayTimeCultists
{
    [BepInPlugin("com.DayTimeCultists", "DayTimeCultists", "1.2.0")]
    [BepInDependency("com.SPT.core", "3.9.0")]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {

            if (!DependencyChecker.ValidateDependencies(Logger, Info, this.GetType(), Config))
            {
                throw new Exception($"Missing Dependencies");
            }

            new CulitstSpawnPatch().Enable();
            Logger.LogDebug("DayTimeCultists is enabled");
        }
    }
}
