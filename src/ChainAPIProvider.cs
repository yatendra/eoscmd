using EOSNewYork.EOSCore;
namespace eoscmd
{
    public static class ChainAPIProvider
    {
        private static ChainAPI chainAPI = null;
        private static string host;
        public static ChainAPI GetInstance(string host)
        {
            if(string.IsNullOrEmpty(host) || ChainAPIProvider.host == host)
            {
                return chainAPI;
            }
            ChainAPIProvider.host = host;
            chainAPI = new ChainAPI(host, 120);
            return chainAPI;
        }
    }
}