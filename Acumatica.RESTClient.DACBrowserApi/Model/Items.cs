using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Acumatica.RESTClient.DACBrowserApi.Model
{
    [DataContract]
    public class ItemsRoot
    {
        [DataMember(Name = "items", EmitDefaultValue = false)]
        public Item[] Items { get; set; }

    }
    [DataContract]
    public class Item
    {
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        [DataMember(Name = "dacs", EmitDefaultValue = false)]
        public DACReference[] DACs { get; set; }

    }
}
