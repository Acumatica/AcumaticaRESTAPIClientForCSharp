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
	/// Corresponds to the screen <c>PR201000</c> in the Acumatica ERP
	/// <para>Key Fields: PayGroup, Year</para>
	/// </summary>
	[DataContract]
	public class PayPeriod : Entity, ITopLevelEntity
	{

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FinPeriods</para>
		/// <para>DAC: PX.Objects.PR.PRPayGroupYear</para>
		/// <para>Display Name: Number of Periods</para>
		/// </summary>
		[DataMember(Name="NumberofPeriods", EmitDefaultValue=false)]
		public ShortValue? NumberofPeriods { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OverrideFinPeriods</para>
		/// <para>DAC: PX.Objects.PR.PRPayGroupYear</para>
		/// </summary>
		[DataMember(Name="Override", EmitDefaultValue=false)]
		public BooleanValue? Override { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PayGroupID</para>
		/// <para>DAC: PX.Objects.PR.PRPayGroupYear</para>
		/// <para>Display Name: Pay Group</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="PayGroup", EmitDefaultValue=false)]
		public StringValue? PayGroup { get; set; }

		[DataMember(Name="PaymentPeriods", EmitDefaultValue=false)]
		public List<PaymentPeriod>? PaymentPeriods { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PRPayGroupYear</para>
		/// <para>Display Name: Start Date</para>
		/// </summary>
		[DataMember(Name="StartDate", EmitDefaultValue=false)]
		public DateTimeValue? StartDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PR.PRPayGroupYear</para>
		/// <para>SQL Type: char(4)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="Year", EmitDefaultValue=false)]
		public StringValue? Year { get; set; }

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
			public const string PaymentPeriods = "PaymentPeriods";

			//Intentionally excluded
			//public const string All = "Files,Translations,PaymentPeriods";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}