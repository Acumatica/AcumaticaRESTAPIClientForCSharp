using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class BCShipments : Entity, ITopLevelEntity
	{

		[DataMember(Name="OrderNbr", EmitDefaultValue=false)]
		public StringValue? OrderNbr { get; set; }

		[DataMember(Name="Results", EmitDefaultValue=false)]
		public List<BCShipmentsResult>? Results { get; set; }

		[DataMember(Name="ShippingNoteID", EmitDefaultValue=false)]
		public GuidValue? ShippingNoteID { get; set; }

		[DataMember(Name="LastModified", EmitDefaultValue=false)]
		public DateTimeValue? LastModified { get; set; }

		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		[DataMember(Name="BindingID", EmitDefaultValue=false)]
		public IntValue? BindingID { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/eCommerce/20.200.001";
		}
	}
}