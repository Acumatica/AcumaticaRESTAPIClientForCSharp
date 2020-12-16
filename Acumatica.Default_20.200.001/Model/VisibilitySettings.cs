using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class VisibilitySettings : Entity_v4
	{

		[DataMember(Name="AP", EmitDefaultValue=false)]
		public BooleanValue AP { get; set; }

		[DataMember(Name="AR", EmitDefaultValue=false)]
		public BooleanValue AR { get; set; }

		[DataMember(Name="CA", EmitDefaultValue=false)]
		public BooleanValue CA { get; set; }

		[DataMember(Name="CRM", EmitDefaultValue=false)]
		public BooleanValue CRM { get; set; }

		[DataMember(Name="Expenses", EmitDefaultValue=false)]
		public BooleanValue Expenses { get; set; }

		[DataMember(Name="GL", EmitDefaultValue=false)]
		public BooleanValue GL { get; set; }

		[DataMember(Name="IN", EmitDefaultValue=false)]
		public BooleanValue IN { get; set; }

		[DataMember(Name="PO", EmitDefaultValue=false)]
		public BooleanValue PO { get; set; }

		[DataMember(Name="SO", EmitDefaultValue=false)]
		public BooleanValue SO { get; set; }

		[DataMember(Name="TimeEntries", EmitDefaultValue=false)]
		public BooleanValue TimeEntries { get; set; }

	}
}