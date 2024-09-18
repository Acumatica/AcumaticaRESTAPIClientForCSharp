using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Acumatica.RESTClient.ContractBasedApi.FileApi.Model
{
    [DataContract]
    public class Links
    {
        [DataMember(Name = "self", EmitDefaultValue = false)]
        public string? Self { get; set; }

        [DataMember(Name = "files:put", EmitDefaultValue = false)]
        public string? FileUploadLink { get; set; }

    }
}
