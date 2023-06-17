using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using Game.Simulation;
using System.Reflection;


namespace TosDev
{
    [HarmonyPatch(typeof(GameSimulation), "get_userLevel")]
    internal class Devpatch
    {


        
        [HarmonyPrefix]
        internal static bool Prefix()
        {

            Type exampleType = typeof(GameSimulation);
            MethodInfo set_userLevel = exampleType.GetMethod("set_userLevel");
            set_userLevel.Invoke(null, new object[] { 3 });

            MethodInfo get_userLevel = exampleType.GetMethod("get_userLevel");
            get_userLevel.Invoke(null, new object[] {});
            return true;
        }
    }
}
