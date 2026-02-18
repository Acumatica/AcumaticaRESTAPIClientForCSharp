using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>PR102000</c> in the Acumatica ERP
	/// <para>Key Fields: EarningTypeCodeID</para>
	/// </summary>
	public class EarningTypeCode : Entity, ITopLevelEntity
	{

		/// <summary>
		/// A boolean value that specifies (if set to true) that the hours linked with the code will be considered for PTO calculation.The field is obsolete from 2025R1.
		/// <para>DAC Field Name: AccruePTO</para>
		/// <para>DAC: PX.Objects.EP.EPEarningType</para>
		/// </summary>
		public BooleanValue? AccrueTimeOff { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsActive</para>
		/// <para>DAC: PX.Objects.EP.EPEarningType</para>
		/// </summary>
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// The category to which an earning type belongs.
		/// <para>DAC Field Name: EarningTypeCategory</para>
		/// <para>DAC: PX.Objects.EP.EPEarningType</para>
		/// <para>Display Name: Earning Type Category</para>
		/// <para>SQL Type: char(3)</para>
		/// </summary>
		public StringValue? Category { get; set; }

		/// <summary>
		/// A boolean value that specifies (if set to true) that the system uses a WC code from the employee time activities or payroll settings when inserting an earning line in a paycheck or in a payroll batch.
		/// <para>DAC Field Name: IsWCCCalculation</para>
		/// <para>DAC: PX.Objects.EP.EPEarningType</para>
		/// <para>Display Name: Contributes to WCC Calculation</para>
		/// </summary>
		public BooleanValue? ContributestoWCCCalculation { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.EP.EPEarningType</para>
		/// <para>SQL Type: nvarchar(60)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TypeCD</para>
		/// <para>DAC: PX.Objects.EP.EPEarningType</para>
		/// <para>Display Name: Code</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? EarningTypeCodeID { get; set; }

		public EarningCodeGLAccounts? GLAccounts { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OvertimeMultiplier</para>
		/// <para>DAC: PX.Objects.EP.EPEarningType</para>
		/// </summary>
		public DecimalValue? Multiplier { get; set; }

		public EarningCodeProjectSettings? ProjectSettings { get; set; }

		/// <summary>
		/// A boolean value that specifies (if set to true) that the type refers to earnings guaranteed by a mandatory holiday.
		/// <para>DAC: PX.Objects.EP.EPEarningType</para>
		/// <para>Display Name: Public Holiday</para>
		/// </summary>
		public BooleanValue? PublicHoliday { get; set; }

		/// <summary>
		/// The user-friendly unique identifier of the earning type to be used for calculation of the PTO amount.The field is included in RegularEarningType.
		/// <para>DAC Field Name: RegularTypeCD</para>
		/// <para>DAC: PX.Objects.EP.EPEarningType</para>
		/// <para>Display Name: Regular Time Type Code</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? RegularTimeTypeCode { get; set; }

		public TaxAndReportingCA? TaxAndReportingCA { get; set; }

		public TaxAndReportingUS? TaxAndReportingUS { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string GLAccounts = "GLAccounts";
			public const string ProjectSettings = "ProjectSettings";
			public const string TaxAndReportingCA = "TaxAndReportingCA";
			public const string TaxAndReportingCA_TaxDetailsCA = "TaxAndReportingCA/TaxDetailsCA";
			public const string TaxAndReportingCA_TaxDetailsCA_Files = "TaxAndReportingCA/TaxDetailsCA/Files";
			public const string TaxAndReportingUS = "TaxAndReportingUS";
			public const string TaxAndReportingUS_TaxDetailsUS = "TaxAndReportingUS/TaxDetailsUS";
			public const string TaxAndReportingUS_TaxDetailsUS_Files = "TaxAndReportingUS/TaxDetailsUS/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,GLAccounts,ProjectSettings,TaxAndReportingCA,TaxAndReportingCA/TaxDetailsCA,TaxAndReportingCA/TaxDetailsCA/Files,TaxAndReportingUS,TaxAndReportingUS/TaxDetailsUS,TaxAndReportingUS/TaxDetailsUS/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}