using Mafi;
using Mafi.Base;
using Mafi.Core.Entities.Static.Layout;
using Mafi.Core.Mods;

namespace CaptainParty
{
    internal class CaptainPartyData : IModData
    {
        public void RegisterData(ProtoRegistrator registrator)
        {
            registrator.StorageProtoBuilder
                .Start("Party Test", CaptainPartyModIds.Machines.PartyPlace)
                .Description("Something to test")
                .SetCapacity(1024)                
                .SetNoTransferLimit()
                .SetCost(Costs.Build.CP(80).Workers(1))
                .SetLayout(new EntityLayoutParams(),
                    "[4][4][4][4][4][4][4][4][4][4][4][4][4]",
                    "[4][4][4][4][4][4][4][4][4][4][4][4][4]",
                    "[4][4][4][4][4][4][4][4][4][4][4][4][4]",
                    "[4][4][4][4][4][4][4][4][4][4][4][4][4]",
                    "[4][4][4][4][4][4][4][4][4][4][4][4][4]",
                    "[4][4][4][4][4][4][4][4][4][4][4][4][4]",
                    "[4][4][4][4][4][4][4][4][4][4][4][4][4]",
                    "[4][4][4][4][4][4][4][4][4][4][4][4][4]",
                    "[4][4][4][4][4][4][4][4][4][4][4][4][4]",
                    "[4][4][4][4][4][4][4][4][4][4][4][4][4]",
                    "[4][4][4][4][4][4][4][4][4][4][4][4][4]",
                    "[4][4][4][4][4][4][4][4][4][4][4][4][4]",
                    "[4][4][4][4][4][4][4][4][4][4][4][4][4]",
                    "[4][4][4][4][4][4][4][4][4][4][4][4][4]")
                .SetPrefabPath("Assets/Base/Buildings/Ruins/RadioTower.prefab")
                .SetPrefabOffset(-RelTile3f.UnitX)
                .SetCategories(Ids.ToolbarCategories.Buildings)
                .BuildAndAdd();
        }
    }
}
