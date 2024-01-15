using BepInEx;

namespace Nooky.DayTimeCultists
{
    [BepInPlugin("com.nooky.DayTimeCultists", "nooky-DayTimeCultists", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            new CulitstSpawnPatch().Enable();
        }
    }
}
