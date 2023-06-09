using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ReminderDetail : Entity
	{

		[DataMember(Name="IsActive", EmitDefaultValue=false)]
		public BooleanValue IsActive { get; set; }

		[DataMember(Name="RemindAtDate", EmitDefaultValue=false)]
		public DateTimeValue RemindAtDate { get; set; }

		[DataMember(Name="RemindAtTime", EmitDefaultValue=false)]
		public DateTimeValue RemindAtTime { get; set; }

	}
}