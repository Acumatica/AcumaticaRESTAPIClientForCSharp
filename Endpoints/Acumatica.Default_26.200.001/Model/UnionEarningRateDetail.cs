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
	public class UnionEarningRateDetail : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.PM.PMUnion</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The date on which the labor cost rate becomes effective.
		/// <para>DAC: PX.Objects.PM.PMLaborCostRate</para>
		/// <para>Display Name: Effective Date</para>
		/// </summary>
		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// The identifier of the inventory item associated with the labor cost rate.
		/// <para>DAC Field Name: InventoryID</para>
		/// <para>DAC: PX.Objects.PM.PMLaborCostRate</para>
		/// <para>Display Name: Labor Item</para>
		/// </summary>
		[DataMember(Name="LaborItem", EmitDefaultValue=false)]
		public StringValue? LaborItem { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// The wage rate for the labor cost rate.
		/// <para>DAC: PX.Objects.PM.PMLaborCostRate</para>
		/// <para>Display Name: Wage Rate</para>
		/// </summary>
		[DataMember(Name="WageRate", EmitDefaultValue=false)]
		public DecimalValue? WageRate { get; set; }

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