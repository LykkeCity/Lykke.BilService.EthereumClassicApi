using JetBrains.Annotations;
using Lykke.Quintessence.Domain.Services;

namespace Lykke.BilService.EthereumClassicApi.Domain.Services
{
    [UsedImplicitly]
    public class EthereumClassicAssetService : DefaultAssetServiceBase
    {
        public EthereumClassicAssetService() : base(18, "", "ETC", "ETC")
        {
            
        }
    }
}