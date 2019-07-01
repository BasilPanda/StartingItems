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
                        cm.inventory.GiveItem((ItemIndex)0, 20);
                        cm.inventory.GiveItem((ItemIndex)8, 20);
                        cm.inventory.GiveItem((ItemIndex)9, 20);
                        cm.inventory.GiveItem((ItemIndex)15, 1);
                        cm.inventory.GiveItem((ItemIndex)29, 5);
                        cm.inventory.GiveItem((ItemIndex)30, 16);
                        cm.inventory.GiveItem((ItemIndex)35, 10);
                        cm.inventory.GiveItem((ItemIndex)82, 1);
                    }
                }
            };
        }
    }
}
