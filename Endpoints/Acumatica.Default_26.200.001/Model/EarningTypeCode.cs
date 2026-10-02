using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>PR102000</c> in the Acumatica ERP
	/// <para>Key Fields: EarningTypeCodeID</para>
	/// </summary>
	public class EarningTypeCode : Entity, ITopLevelEntity
	{

		#region Fields
		/// <summary>
		/// <para>DAC Field Name: TypeCD</para>
		/// <para>DAC: PX.Objects.EP.EPEarningType</para>
		/// <para>Display Name: Code</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? EarningTypeCodeID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.EP.EPEarningType</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// The category to which an earning type belongs.
		/// <para>DAC Field Name: EarningTypeCategory</para>
		/// <para>DAC: PX.Objects.EP.EPEarningType</para>
		/// <para>Display Name: Earning Type Category</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		public StringValue? Category { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OvertimeMultiplier</para>
		/// <para>DAC: PX.Objects.EP.EPEarningType</para>
		/// </summary>
		public DecimalValue? Multiplier { get; set; }

		/// <summary>
		/// The user-friendly unique identifier of the earning type to be used for calculation of the PTO amount.The field is included in RegularEarningType.
		/// <para>DAC Field Name: RegularTypeCD</para>
		/// <para>DAC: PX.Objects.EP.EPEarningType</para>
		/// <para>Display Name: Regular Time Type Code</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? RegularTimeTypeCode { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.EP.EPEarningType</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// A boolean value that specifies (if set to true) that the system uses a WC code from the employee time activities or payroll settings when inserting an earning line in a paycheck or in a payroll batch.
		/// <para>DAC Field Name: IsWCCCalculation</para>
		/// <para>DAC: PX.Objects.EP.EPEarningType</para>
		/// <para>Display Name: Contributes to WCC Calculation</para>
		/// </summary>
		public BooleanValue? ContributestoWCCCalculation { get; set; }

		/// <summary>
		/// A boolean value that specifies (if set to true) that the hours linked with the code will be considered for PTO calculation.The field is obsolete from 2025R1.
		/// <para>DAC Field Name: AccruePTO</para>
		/// <para>DAC: PX.Objects.EP.EPEarningType</para>
		/// </summary>
		public BooleanValue? AccrueTimeOff { get; set; }

		/// <summary>
		/// A boolean value that specifies (if set to true) that the type refers to earnings guaranteed by a mandatory holiday.
		/// <para>DAC: PX.Objects.EP.EPEarningType</para>
		/// <para>Display Name: Public Holiday</para>
		/// </summary>
		public BooleanValue? PublicHoliday { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		#endregion

		#region LinkedEntities
		public EarningCodeGLAccounts? GLAccounts { get; set; }

		public EarningCodeProjectSettings? ProjectSettings { get; set; }

		public TaxAndReportingCA? TaxAndReportingCA { get; set; }

		public TaxAndReportingUS? TaxAndReportingUS { get; set; }

		#endregion

		protected override string GetDebuggerDisplay()
		{
			return $"{nameof(EarningTypeCode)} - \"{EarningTypeCodeID}\"";
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
			public const string GLAccounts = "GLAccounts";
			public const string ProjectSettings = "ProjectSettings";
			public const string TaxAndReportingCA = "TaxAndReportingCA";
			public const string TaxAndReportingUS = "TaxAndReportingUS";

			//Intentionally excluded
			//public const string All = "Files,Translations,GLAccounts,ProjectSettings,TaxAndReportingCA,TaxAndReportingUS";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}