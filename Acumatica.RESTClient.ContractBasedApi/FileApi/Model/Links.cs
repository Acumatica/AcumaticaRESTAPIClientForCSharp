using Newtonsoft.Json;

namespace Acumatica.RESTClient.ContractBasedApi.FileApi.Model
{
    public class Links
    {
        public string? Self { get; set; }

        [JsonProperty("files:put")]
        public string? FileUploadLink { get; set; }

    }
}
