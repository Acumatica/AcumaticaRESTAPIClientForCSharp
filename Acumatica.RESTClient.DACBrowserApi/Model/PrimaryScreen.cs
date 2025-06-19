using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace Acumatica.RESTClient.DACBrowserApi.Model
{
    [DataContract]
    public class PrimaryScreen
    {
        [DataMember(Name = "screenId", EmitDefaultValue = false)]
        public string ScreenId { get; set; }

        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

    }
}
