using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	[DataContract]
	public class CustomerSalesPerson : Entity
	{

		/// <summary>
		/// The default sales commission percentage received by the salesperson for the specified customer and location.
		/// <para>DAC Field Name: CommisionPct</para>
		/// <para>DAC: PX.Objects.AR.CustSalesPeople</para>
		/// <para>Display Name: Commission %</para>
		/// </summary>
		[DataMember(Name="Commission", EmitDefaultValue=false)]
		public DecimalValue? Commission { get; set; }

		/// <summary>
		/// This field indicates whether the location is default for the corresponding business account.
		/// <para>DAC Field Name: IsDefault</para>
		/// <para>DAC: PX.Objects.CR.Standalone.Location</para>
		/// </summary>
		[DataMember(Name="Default", EmitDefaultValue=false)]
		public BooleanValue? Default { get; set; }

		/// <summary>
		/// The integer identifier of the customer location. This field is a part of the compound key of the record.
		/// <para>DAC: PX.Objects.AR.CustSalesPeople</para>
		/// <para>Display Name: Location</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue? LocationID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LocationID_description</para>
		/// <para>DAC: PX.Objects.AR.CustSalesPeople</para>
		/// </summary>
		[DataMember(Name="LocationName", EmitDefaultValue=false)]
		public StringValue? LocationName { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SalesPersonID_SalesPerson_descr</para>
		/// <para>DAC: PX.Objects.AR.CustSalesPeople</para>
		/// </summary>
		[DataMember(Name="Name", EmitDefaultValue=false)]
		public StringValue? Name { get; set; }

		/// <summary>
		/// The integer identifier of the salesperson. This field is a part of the compound key of the record.
		/// <para>DAC Field Name: SalesPersonID</para>
		/// <para>DAC: PX.Objects.AR.CustSalesPeople</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="SalespersonID", EmitDefaultValue=false)]
		public StringValue? SalespersonID { get; set; }

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