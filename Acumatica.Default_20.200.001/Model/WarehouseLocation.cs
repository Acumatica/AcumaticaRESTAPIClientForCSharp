using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class WarehouseLocation : Entity_v4
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue Active { get; set; }

		[DataMember(Name="AssemblyAllowed", EmitDefaultValue=false)]
		public BooleanValue AssemblyAllowed { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue LocationID { get; set; }

		[DataMember(Name="PickPriority", EmitDefaultValue=false)]
		public ShortValue PickPriority { get; set; }

		[DataMember(Name="ReceiptsAllowed", EmitDefaultValue=false)]
		public BooleanValue ReceiptsAllowed { get; set; }

		[DataMember(Name="SalesAllowed", EmitDefaultValue=false)]
		public BooleanValue SalesAllowed { get; set; }

		[DataMember(Name="TransfersAllowed", EmitDefaultValue=false)]
		public BooleanValue TransfersAllowed { get; set; }

	}
}