using JetBrains.Annotations;
using Lykke.Quintessence.Settings;

namespace Lykke.BilService.EthereumClassicApi.Settings
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class EthereumClassicApiSettings : ApiSettings
    {
        public bool IsMainNet { get; set; }
    }
}