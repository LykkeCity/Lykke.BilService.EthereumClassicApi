using System.Threading.Tasks;
using Lykke.BilService.EthereumClassicApi.Settings;
using Lykke.Quintessence;

namespace Lykke.BilService.EthereumClassicApi
{
    internal static class Program
    {
        #if DEBUG
        
        private const bool IsDebug = true;
        
        #else

        private const bool IsDebug = false;

        #endif
        
        private static Task Main()
        {
            return ApiStarter
                .StartAsync<Startup, EthereumClassicApiSettings>(IsDebug);
        }
    }
}