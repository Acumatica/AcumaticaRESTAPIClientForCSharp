using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.ISVCB_19_1.Model
{
	[DataContract]
	public class Customers : Entity
	{

		[DataMember(Name="InstalledAcumaticaVersion", EmitDefaultValue=false)]
		public StringValue InstalledAcumaticaVersion { get; set; }

		[DataMember(Name="PartnerAccountName", EmitDefaultValue=false)]
		public StringValue PartnerAccountName { get; set; }

		[DataMember(Name="ContractID", EmitDefaultValue=false)]
		public StringValue ContractID { get; set; }

		[DataMember(Name="Customer", EmitDefaultValue=false)]
		public StringValue Customer { get; set; }

		[DataMember(Name="CustomerName", EmitDefaultValue=false)]
		public StringValue CustomerName { get; set; }

		[DataMember(Name="DateLiveISVSolution", EmitDefaultValue=false)]
		public DateTimeValue DateLiveISVSolution { get; set; }

		[DataMember(Name="InstalledISVVersion", EmitDefaultValue=false)]
		public StringValue InstalledISVVersion { get; set; }

	}
}