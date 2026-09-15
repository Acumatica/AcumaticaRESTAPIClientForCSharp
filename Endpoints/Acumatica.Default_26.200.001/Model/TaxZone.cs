using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>TX206000</c> in the Acumatica ERP
	/// <para>Key Fields: TaxZoneID</para>
	/// </summary>
	[DataContract]
	public class TaxZone : Entity, ITopLevelEntity
	{

		[DataMember(Name="ApplicableTaxes", EmitDefaultValue=false)]
		public List<TaxZoneApplicableTaxDetail>? ApplicableTaxes { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// The description of the tax zone, which can be specified by the user.
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.TX.TaxZone</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// A key field, which can be specified by the user.
		/// <para>DAC: PX.Objects.TX.TaxZone</para>
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
			public const string Translations = "Translations";
			public const string ApplicableTaxes = "ApplicableTaxes";

			//Intentionally excluded
			//public const string All = "Files,Translations,ApplicableTaxes";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}