using MelonLoader;
using HarmonyLib;
using UnityEngine;


namespace TosDev
{
    public class MyMod : MelonMod
    {

        override public void OnInitializeMelon()
        {

            ((MelonBase)this).LoggerInstance.Msg("QoL modifications loaded");
            

        }
    }
}