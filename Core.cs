using MelonLoader;
using DooDesch.Weapons;

[assembly: MelonInfo(typeof(AmpedBatPlus.Core), "AmpedBatPlus", DooDesch.ModVersion.Current, "DooDesch", null)]
[assembly: MelonGame("ReLUGames", "MIMESIS")]

namespace AmpedBatPlus
{
    public sealed class Core : MelonMod
    {
        public override void OnInitializeMelon()
        {
            WeaponPreferences.Initialize();
            MelonLogger.Msg("AmpedBatPlus initialized for item 1600. Gameplay follows the host.");
        }
        public override void OnUpdate()
        {
            DooDesch.HostSettings.Update();
            WeaponDisplay.Update();
            WeaponReloadAnimation.Update();
        }
    }
}
