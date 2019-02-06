using JetBrains.Annotations;
using Lykke.BilService.EthereumClassicApi.Modules;
using Lykke.BilService.EthereumClassicApi.Settings;
using Lykke.Quintessence;
using Lykke.Sdk;

namespace Lykke.BilService.EthereumClassicApi
{
    [UsedImplicitly]
    public class Startup : ApiStartupBase<EthereumClassicApiSettings>
    {
        protected override string IntegrationName
            => "EthereumClassic";

        protected override void RegisterAdditionalModules(
            IModuleRegistration modules)
        {
            modules.RegisterModule<EthereumClassicApiModule>();
            
            base.RegisterAdditionalModules(modules);
        }
    }
}