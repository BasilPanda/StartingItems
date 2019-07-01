using System;
using BepInEx;
using BepInEx.Configuration;
using RoR2;

namespace Basil_ror2
{
    [BepInDependency("com.bepis.r2api")]
    [BepInPlugin("com.Basil.StartingItems", "StartingItems", "1.0.0")]
    public class StartingItems : BaseUnityPlugin
    {
        
        public void Awake()
        {
            Hooks.addItems();
        }

    }
}
