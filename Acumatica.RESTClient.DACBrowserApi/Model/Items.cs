namespace Acumatica.RESTClient.DACBrowserApi.Model
{
    public class ItemsRoot
    {
        public Item[] Items { get; set; }

    }
    public class Item
    {
        public string Name { get; set; }

        public DACReference[] DACs { get; set; }

    }
}
