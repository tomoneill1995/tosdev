using MelonLoader;
using HarmonyLib;


namespace TosDev
{
    public class MyMod : MelonMod
    {
        public virtual void OnInitializeMelon()
        {
            new Harmony("MyMod").PatchAll();
            ((MelonBase)this).LoggerInstance.Msg("QoL modifications loaded");
        }
    }
}