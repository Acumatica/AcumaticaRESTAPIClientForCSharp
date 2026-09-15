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
	public class TaxZoneDetail : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: TaxZone__DfltTaxCategoryID</para>
		/// <para>DAC: PX.Objects.TX.TaxZoneDet</para>
		/// </summary>
		[DataMember(Name="DefaultTaxCategory", EmitDefaultValue=false)]
		public StringValue? DefaultTaxCategory { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TaxZone__Descr</para>
		/// <para>DAC: PX.Objects.TX.TaxZoneDet</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The tax ID. This is the key field, which can be specified by the user.
		/// <para>DAC: PX.Objects.TX.Tax</para>
		/// <para>Display Name: Tax ID</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="TaxID", EmitDefaultValue=false)]
		public StringValue? TaxID { get; set; }

		/// <summary>
		/// The foreign key to TaxZone.
		/// <para>DAC: PX.Objects.TX.TaxZoneDet</para>
		/// <para>Display Name: Tax Zone ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="TaxZoneID", EmitDefaultValue=false)]
		public StringValue? TaxZoneID { get; set; }

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