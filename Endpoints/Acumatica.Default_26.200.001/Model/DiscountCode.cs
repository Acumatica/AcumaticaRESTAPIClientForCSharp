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
	/// Corresponds to the screen <c>AR209000</c> in the Acumatica ERP
	/// <para>Key Fields: DiscountCodeID</para>
	/// </summary>
	[DataContract]
	public class DiscountCode : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARDiscount</para>
		/// <para>Display Name: Applicable To</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		[DataMember(Name="ApplicableTo", EmitDefaultValue=false)]
		public StringValue? ApplicableTo { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARDiscount</para>
		/// <para>SQL Type: nvarchar(250)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DiscountID</para>
		/// <para>DAC: PX.Objects.AR.ARDiscount</para>
		/// <para>Display Name: Discount Code</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="DiscountCodeID", EmitDefaultValue=false)]
		public StringValue? DiscountCodeID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Type</para>
		/// <para>DAC: PX.Objects.AR.ARDiscount</para>
		/// <para>Display Name: Discount Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="DiscountType", EmitDefaultValue=false)]
		public StringValue? DiscountType { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

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

			//Intentionally excluded
			//public const string All = "Files,Translations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}