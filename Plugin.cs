﻿using BepInEx;

namespace DayTimeCultists
{
    [BepInPlugin("com.DayTimeCultists", "DayTimeCultists", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            new CulitstSpawnPatch().Enable();
            Logger.LogDebug("DayTimeCultists is enabled");
        }
    }
}
