using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class CarrierCustomerAccount : Entity
	{

		/// <summary>
		/// DAC Field Name: IsActive 
		/// DAC: PX.Objects.CS.CarrierPluginCustomer 
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CS.CarrierPluginCustomer 
		/// Display Name: Carrier Billing Account 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="CarrierAccount", EmitDefaultValue=false)]
		public StringValue? CarrierAccount { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CS.CarrierPluginCustomer 
		/// Display Name: Customer ID 
		/// </summary>
		[DataMember(Name="CustomerID", EmitDefaultValue=false)]
		public StringValue? CustomerID { get; set; }

		/// <summary>
		/// DAC Field Name: CustomerID_description 
		/// DAC: PX.Objects.CS.CarrierPluginCustomer 
		/// </summary>
		[DataMember(Name="CustomerName", EmitDefaultValue=false)]
		public StringValue? CustomerName { get; set; }

		/// <summary>
		/// DAC Field Name: CustomerLocationID 
		/// DAC: PX.Objects.CS.CarrierPluginCustomer 
		/// Display Name: Customer Location 
		/// </summary>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CS.CarrierPluginCustomer 
		/// Display Name: Billing Postal Code 
		/// SQL Type: varchar(10) 
		/// </summary>
		[DataMember(Name="PostalCode", EmitDefaultValue=false)]
		public StringValue? PostalCode { get; set; }

		[DataMember(Name="RecordID", EmitDefaultValue=false)]
		public IntValue? RecordID { get; set; }

	}
}