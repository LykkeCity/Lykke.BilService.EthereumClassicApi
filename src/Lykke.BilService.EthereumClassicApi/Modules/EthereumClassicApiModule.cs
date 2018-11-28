using Autofac;
using JetBrains.Annotations;
using Lykke.BilService.EthereumClassicApi.Settings;
using Lykke.Quintessence.Settings;

namespace Lykke.BilService.EthereumClassicApi.Modules
{
    [UsedImplicitly]
    public class EthereumClassicApiModule : Module
    {
        private readonly AppSettings<EthereumClassicApiSettings> _appSettings;

        public EthereumClassicApiModule(
            AppSettings<EthereumClassicApiSettings> appSettings)
        {
            _appSettings = appSettings;
        }

        protected override void Load(
            ContainerBuilder builder)
        {
            
        }
    }
}