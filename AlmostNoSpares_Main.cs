using Planetbase;
using System;
using UnityEngine;
using System.Reflection;
using System.IO;

namespace Tahvohck_Mods
{
    public class AlmostNoSpares
    {
        [LoaderOptimization(LoaderOptimization.NotSpecified)]
        public static void Init()
        {
            try
            {
                TahvohckUtil.FirstUpdate += Update;
            }
            catch (Exception e)
            {
                Debug.Log(e.Message);
            }
        }

        public static void Update()
        {
            ModuleName solar = ModuleName.SolarPanel;
            typeof(ModuleTypeSolarPanel)
                .GetField("mCondicionDecayTime", BindingFlags.NonPublic | BindingFlags.Instance)
                .SetValue(solar, 14000f);
            ModuleName wind = ModuleName.WindTurbine;
            typeof(ModuleTypeWindTurbine)
                .GetField("mCondicionDecayTime", BindingFlags.NonPublic | BindingFlags.Instance)
                .SetValue(wind, 14000f);
        }
    }
}