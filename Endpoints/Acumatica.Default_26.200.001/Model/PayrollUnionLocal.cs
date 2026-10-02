using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>PR209700</c> in the Acumatica ERP
	/// <para>Key Fields: PayrollUnionLocalID</para>
	/// </summary>
	public class PayrollUnionLocal : Entity, ITopLevelEntity
	{

		#region Fields
		/// <summary>
		/// The unique identifier of the union local.
		/// <para>DAC Field Name: UnionID</para>
		/// <para>DAC: PX.Objects.PM.PMUnion</para>
		/// <para>Display Name: Union Local ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? PayrollUnionLocalID { get; set; }

		/// <summary>
		/// A Boolean value that indicates (if set to true) whether the union local is active.
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.PM.PMUnion</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PM.PMUnion</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public StringValue? Location { get; set; }

		public StringValue? Vendor { get; set; }

		#endregion

		#region Details
		public List<UnionDeductionOrBenefitDetail>? DeductionsAndBenefits { get; set; }

		public List<UnionEarningRateDetail>? EarningRates { get; set; }

		#endregion

		protected override string GetDebuggerDisplay()
		{
			return $"{nameof(PayrollUnionLocal)} - \"{PayrollUnionLocalID}\"";
		}

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
			public const string DeductionsAndBenefits = "DeductionsAndBenefits";
			public const string EarningRates = "EarningRates";

			//Intentionally excluded
			//public const string All = "Files,Translations,DeductionsAndBenefits,EarningRates";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}