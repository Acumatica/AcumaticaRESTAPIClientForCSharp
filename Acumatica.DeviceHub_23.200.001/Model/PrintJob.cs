using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.DeviceHub_23_200_001.Model
{
	[DataContract]
	public class PrintJob : Entity
	{

        [DataMember(Name = "CreatedBy", EmitDefaultValue = false)]
        public StringValue? CreatedBy { get; set; }

        [DataMember(Name = "CreationDateTime", EmitDefaultValue = false)]
        public DateTimeValue? CreationDateTime { get; set; }

        [DataMember(Name = "Description", EmitDefaultValue = false)]
        public StringValue? Description { get; set; }

        [DataMember(Name = "DeviceHub", EmitDefaultValue = false)]
        public StringValue? DeviceHub { get; set; }

        [DataMember(Name = "JobID", EmitDefaultValue = false)]
        public IntValue? JobID { get; set; }

        [DataMember(Name = "NumberofCopies", EmitDefaultValue = false)]
        public IntValue? NumberofCopies { get; set; }

        [DataMember(Name = "Printer", EmitDefaultValue = false)]
        public StringValue? Printer { get; set; }

        [DataMember(Name = "ReportID", EmitDefaultValue = false)]
        public StringValue? ReportID { get; set; }

        [DataMember(Name = "Selected", EmitDefaultValue = false)]
        public BooleanValue? Selected { get; set; }

        [DataMember(Name = "Status", EmitDefaultValue = false)]
        public StringValue? Status { get; set; }

        [DataMember(Name = "ModifiedDateTime", EmitDefaultValue = false)]
        public DateTimeValue? ModifiedDateTime { get; set; }

        [DataMember(Name = "Parameters", EmitDefaultValue = false)]
        public List<PrintJobParameter>? Parameters { get; set; }

    }
}