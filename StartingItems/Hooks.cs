using RoR2;

namespace Basil_ror2
{
    public static class Hooks
    {

        public static void addItems()
        {
            On.RoR2.SceneDirector.PopulateScene += (orig, self) =>
            {
                orig(self);

                if(Run.instance.stageClearCount == 0)
                {
                    foreach(CharacterMaster cm in CharacterMaster.readOnlyInstancesList)
                    {
                        if(cm.teamIndex == TeamIndex.Player)
                        {
                            cm.inventory.GiveItem(RoR2Content.Items.Syringe, 20);
                            cm.inventory.GiveItem(RoR2Content.Items.Feather, 20);
                            cm.inventory.GiveItem(RoR2Content.Items.Hoof, 20);
                            cm.inventory.GiveItem(RoR2Content.Items.GhostOnKill, 1);
                            cm.inventory.GiveItem(RoR2Content.Items.PersonalShield, 5);
                            cm.inventory.GiveItem(RoR2Content.Items.EquipmentMagazine, 16);
                            cm.inventory.GiveItem(RoR2Content.Items.BeetleGland, 1);
                            cm.inventory.GiveItem(RoR2Content.Items.Clover, 10);
                            cm.inventory.GiveItem(RoR2Content.Items.TitanGoldDuringTP, 1);
                            cm.inventory.GiveItem(RoR2Content.Items.Squid, 1);
                            cm.inventory.GiveItem(RoR2Content.Items.ChainLightning, 50);
                            cm.inventory.GiveItem(RoR2Content.Items.LunarBadLuck, 8);
                            cm.inventory.GiveItem(RoR2Content.Items.ExtraLife, 2);
                            cm.GiveMoney(100000);
                            cm.inventory.GiveEquipmentString("DroneBackup");
                        }
                    }
                }
            };
        }
    }
}
