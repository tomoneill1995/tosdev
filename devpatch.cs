using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using Game.Simulation;
using System.Reflection;
using MelonLoader;

namespace TosDev
{
    [HarmonyPatch(typeof(GameSimulation), "get_userLevel")]
    public class Devpatch
    {


        internal static bool Prefix(out StateProperty<int> __result)
        {

            Melon<MyMod>.Logger.Msg("started postfix");

            var cadt = new StateProperty<int>(3);
            Melon<MyMod>.Logger.Msg(cadt);
            __result = cadt;

            return false;
        }
    }
}
