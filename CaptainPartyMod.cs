using Mafi.Base;
using Mafi.Core;
using Mafi;
using Mafi.Core.Mods;

namespace CaptainParty
{
    public sealed class CaptainPartyMod : DataOnlyMod
    {
        public override string Name => "Captain Party";

        public override int Version => 1;

        public CaptainPartyMod(CoreMod coreMod, BaseMod baseMod)
        {
            // You can use Log class for logging. These will be written to the log file
            // and can be also displayed in the in-game console with command `also_log_to_console`.
            Log.Info("CaptainPartyMod: constructed");
        }

        public override void RegisterPrototypes(ProtoRegistrator registrator)
        {
            Log.Info("CaptainPartyMod: registering prototypes");

            registrator.RegisterAllProducts();

            registrator.RegisterData<CaptainPartyData>();
        }
    }
}
