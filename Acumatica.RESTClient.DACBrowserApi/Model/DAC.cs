namespace Acumatica.RESTClient.DACBrowserApi.Model
{
    public class DAC
    {
        public string Namespace { get; set; }

        public string Name { get; set; }
       
        public string DisplayName { get; set; }

        public bool IsHidden { get; set; }

        public bool ExistsInDb { get; set; }

        public PrimaryScreen[] PrimaryScreens { get; set; }

        public Field[] Fields { get; set; }

        public Documentation? Documentation { get; set; }

    }
}
