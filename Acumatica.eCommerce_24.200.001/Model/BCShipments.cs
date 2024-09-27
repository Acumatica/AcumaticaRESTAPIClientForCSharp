using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen BC408030 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class BCShipments : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC: PX.Data.GenericFilter 
		/// </summary>
		[DataMember(Name="LastModified", EmitDefaultValue=false)]
		public DateTimeValue? LastModified { get; set; }

		/// <summary>
		/// DAC: PX.Data.GenericFilter 
		/// </summary>
		[DataMember(Name="ShippingNoteID", EmitDefaultValue=false)]
		public GuidValue? ShippingNoteID { get; set; }

		/// <summary>
		/// DAC: PX.Data.GenericFilter 
		/// </summary>
		[DataMember(Name="OrderNbr", EmitDefaultValue=false)]
		public StringValue? OrderNbr { get; set; }

		/// <summary>
		/// DAC: PX.Data.GenericFilter 
		/// </summary>
		[DataMember(Name="OrderType", EmitDefaultValue=false)]
		public StringValue? OrderType { get; set; }

		/// <summary>
		/// DAC: PX.Data.GenericFilter 
		/// </summary>
		[DataMember(Name="BindingID", EmitDefaultValue=false)]
		public IntValue? BindingID { get; set; }

		[DataMember(Name="Results", EmitDefaultValue=false)]
		public List<BCShipmentsResult>? Results { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/eCommerce/24.200.001";
		}
	}
}