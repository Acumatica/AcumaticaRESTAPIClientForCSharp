using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.DeviceHub_23_200_001.Model
{
	[DataContract]
	public class Scanner : Entity
	{

        [DataMember(Name = "Description", EmitDefaultValue = false)]
        public StringValue Description { get; set; }

        [DataMember(Name = "DeviceHub", EmitDefaultValue = false)]
        public StringValue DeviceHub { get; set; }

        [DataMember(Name = "FileTypeComboValues", EmitDefaultValue = false)]
        public StringValue FileTypeComboValues { get; set; }

        [DataMember(Name = "FileTypeDefValue", EmitDefaultValue = false)]
        public StringValue FileTypeDefValue { get; set; }

        [DataMember(Name = "IsActive", EmitDefaultValue = false)]
        public BooleanValue IsActive { get; set; }

        [DataMember(Name = "PaperSourceComboValues", EmitDefaultValue = false)]
        public StringValue PaperSourceComboValues { get; set; }

        [DataMember(Name = "PaperSourceDefValue", EmitDefaultValue = false)]
        public StringValue PaperSourceDefValue { get; set; }

        [DataMember(Name = "PixelTypeComboValues", EmitDefaultValue = false)]
        public StringValue PixelTypeComboValues { get; set; }

        [DataMember(Name = "PixelTypeDefValue", EmitDefaultValue = false)]
        public StringValue PixelTypeDefValue { get; set; }

        [DataMember(Name = "ResolutionComboValues", EmitDefaultValue = false)]
        public StringValue ResolutionComboValues { get; set; }

        [DataMember(Name = "ResolutionDefValue", EmitDefaultValue = false)]
        public StringValue ResolutionDefValue { get; set; }

        [DataMember(Name = "ScannerName", EmitDefaultValue = false)]
        public StringValue ScannerName { get; set; }

    }
}