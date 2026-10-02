using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class CarrierCustomerAccount : Entity
	{

		#region Fields
		/// <summary>
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.CS.CarrierPluginCustomer</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CarrierPluginCustomer</para>
		/// <para>Display Name: Customer ID</para>
		/// </summary>
		public StringValue? CustomerID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CustomerID_description</para>
		/// <para>DAC: PX.Objects.CS.CarrierPluginCustomer</para>
		/// </summary>
		public StringValue? CustomerName { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CustomerLocationID</para>
		/// <para>DAC: PX.Objects.CS.CarrierPluginCustomer</para>
		/// <para>Display Name: Customer Location</para>
		/// </summary>
		public StringValue? Location { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CarrierPluginCustomer</para>
		/// <para>Display Name: Carrier Billing Account</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? CarrierAccount { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.CS.CarrierPluginCustomer</para>
		/// <para>Display Name: Billing Postal Code</para>
		/// <para>SQL Type: varchar(10)</para>
		/// </summary>
		public StringValue? PostalCode { get; set; }

		public IntValue? RecordID { get; set; }

		#endregion

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
	}
}