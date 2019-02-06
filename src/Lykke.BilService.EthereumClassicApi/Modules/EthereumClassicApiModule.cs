using Autofac;
using JetBrains.Annotations;
using Lykke.BilService.EthereumClassicApi.Domain.Services;
using Lykke.BilService.EthereumClassicApi.Settings;
using Lykke.Quintessence.Core.DependencyInjection;
using Lykke.Quintessence.Core.Telemetry.DependencyInjection;
using Lykke.Quintessence.Domain.Services.DependencyInjection;
using Lykke.Quintessence.Settings;
using Lykke.SettingsReader;

namespace Lykke.BilService.EthereumClassicApi.Modules
{
    [UsedImplicitly]
    public class EthereumClassicApiModule : Module
    {
        private readonly IReloadingManager<AppSettings<EthereumClassicApiSettings>> _appSettings;

        public EthereumClassicApiModule(
            IReloadingManager<AppSettings<EthereumClassicApiSettings>> appSettings)
        {
            _appSettings = appSettings;
        }

        protected override void Load(
            ContainerBuilder builder)
        {
            var chainId = _appSettings.CurrentValue.Api.IsMainNet ? 61 : 62;

            builder
                .UseAITelemetryConsumer()
                .UseAssetService<EthereumClassicAssetService>()
                .UseChainId(chainId);
        }
    }
}