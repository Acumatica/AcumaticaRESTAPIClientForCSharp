using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>PR209700</c> in the Acumatica ERP
	/// <para>Key Fields: PayrollUnionLocalID</para>
	/// </summary>
	public class PayrollUnionLocal : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.PM.PMUnion</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		public List<UnionDeductionOrBenefitDetail>? DeductionsAndBenefits { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.PM.PMUnion</para>
		/// <para>SQL Type: nvarchar(255)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		public List<UnionEarningRateDetail>? EarningRates { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public StringValue? Location { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UnionID</para>
		/// <para>DAC: PX.Objects.PM.PMUnion</para>
		/// <para>Display Name: Union Local ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? PayrollUnionLocalID { get; set; }

		public StringValue? Vendor { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string DeductionsAndBenefits = "DeductionsAndBenefits";
			public const string DeductionsAndBenefits_Files = "DeductionsAndBenefits/Files";
			public const string EarningRates = "EarningRates";
			public const string EarningRates_Files = "EarningRates/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,DeductionsAndBenefits,DeductionsAndBenefits/Files,EarningRates,EarningRates/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}