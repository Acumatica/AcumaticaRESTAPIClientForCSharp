namespace Acumatica.RESTClient.DACBrowserApi.Model
{
    public class Field
    {
        public string Name { get; set; }

        public bool IsKey { get; set; }

        public string DacName { get; set; }

        public string DisplayName { get; set; }

        public string SqlType { get; set; }

        public Documentation? Documentation { get; set; }

    }
}
