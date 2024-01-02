using Acumatica.RESTClient.Client;


namespace Acumatica.RESTClient.ODataApi
{
    public class ODataAPI
    {
        protected ODataVersion Version;
        protected string? Tenant;
        protected ApiClient Client;

        public ODataAPI(ApiClient client, ODataVersion version, string? tenant = null) 
        {
            Version = version;
            Tenant = tenant;
            Client = client;
        }
        public string GetMetadata()
        {
            return ODataAPIHelper.GetOdataMetadata(Client, Version, Tenant);
        }
        public string GetOData(string resource, string? select = null, string? filter = null, string? expand = null, int? skip = null, int? top = null)
        {
            return ODataAPIHelper.GetOData(Client, Version, resource, Tenant, select, filter, expand, skip, top);
        }
    }
}
