using Acumatica.RESTClient.Model;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class CloseProductionOrders : Entity_v4
	{

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<CloseProductionOrdersDetail> Details { get; set; }

		[DataMember(Name="Period", EmitDefaultValue=false)]
		public StringValue Period { get; set; }

	}
}