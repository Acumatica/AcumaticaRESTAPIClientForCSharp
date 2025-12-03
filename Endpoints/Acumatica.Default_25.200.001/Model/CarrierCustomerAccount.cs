using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	[DataContract]
	public class CarrierCustomerAccount : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.CS.CarrierPluginCustomer</para>
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CarrierPluginCustomer</para>
		/// <para>Display Name: Carrier Billing Account</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="CarrierAccount", EmitDefaultValue=false)]
		public StringValue? CarrierAccount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CarrierPluginCustomer</para>
		/// <para>Display Name: Customer ID</para>
		/// </summary>
		[DataMember(Name="CustomerID", EmitDefaultValue=false)]
		public StringValue? CustomerID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CustomerID_description</para>
		/// <para>DAC: PX.Objects.CS.CarrierPluginCustomer</para>
		/// </summary>
		[DataMember(Name="CustomerName", EmitDefaultValue=false)]
		public StringValue? CustomerName { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CustomerLocationID</para>
		/// <para>DAC: PX.Objects.CS.CarrierPluginCustomer</para>
		/// <para>Display Name: Customer Location</para>
		/// </summary>
		[DataMember(Name="Location", EmitDefaultValue=false)]
		public StringValue? Location { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CarrierPluginCustomer</para>
		/// <para>Display Name: Billing Postal Code</para>
		/// <para>SQL Type: varchar(10)</para>
		/// </summary>
		[DataMember(Name="PostalCode", EmitDefaultValue=false)]
		public StringValue? PostalCode { get; set; }

		[DataMember(Name="RecordID", EmitDefaultValue=false)]
		public IntValue? RecordID { get; set; }

	}
}