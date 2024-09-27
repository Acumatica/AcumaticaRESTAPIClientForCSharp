using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen PR102000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class EarningTypeCode : Entity, ITopLevelEntity
	{

		/// <summary>
		/// A boolean value that specifies (if set to true) that the hours linked with the code will be considered for PTO calculation.
		/// DAC Field Name: AccruePTO 
		/// DAC: PX.Objects.EP.EPEarningType 
		/// Display Name: Accrue Time Off 
		/// </summary>
		[DataMember(Name="AccrueTimeOff", EmitDefaultValue=false)]
		public BooleanValue? AccrueTimeOff { get; set; }

		/// <summary>
		/// DAC Field Name: IsActive 
		/// DAC: PX.Objects.EP.EPEarningType 
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// The category to which an earning type belongs.
		/// DAC Field Name: EarningTypeCategory 
		/// DAC: PX.Objects.EP.EPEarningType 
		/// Display Name: Earning Type Category 
		/// SQL Type: char(3) 
		/// </summary>
		[DataMember(Name="Category", EmitDefaultValue=false)]
		public StringValue? Category { get; set; }

		/// <summary>
		/// A boolean value that specifies (if set to true) that the system uses a WC code from the employee time activities or payroll settings when inserting an earning line in a paycheck or in a payroll batch.
		/// DAC Field Name: IsWCCCalculation 
		/// DAC: PX.Objects.EP.EPEarningType 
		/// Display Name: Contributes to WCC Calculation 
		/// </summary>
		[DataMember(Name="ContributestoWCCCalculation", EmitDefaultValue=false)]
		public BooleanValue? ContributestoWCCCalculation { get; set; }

		/// <summary>
		/// DAC: PX.Objects.EP.EPEarningType 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: TypeCD 
		/// DAC: PX.Objects.EP.EPEarningType 
		/// Display Name: Code 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="EarningTypeCodeID", EmitDefaultValue=false)]
		public StringValue? EarningTypeCodeID { get; set; }

		[DataMember(Name="GLAccounts", EmitDefaultValue=false)]
		public EarningCodeGLAccounts? GLAccounts { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// DAC Field Name: OvertimeMultiplier 
		/// DAC: PX.Objects.EP.EPEarningType 
		/// </summary>
		[DataMember(Name="Multiplier", EmitDefaultValue=false)]
		public DecimalValue? Multiplier { get; set; }

		[DataMember(Name="ProjectSettings", EmitDefaultValue=false)]
		public EarningCodeProjectSettings? ProjectSettings { get; set; }

		/// <summary>
		/// A boolean value that specifies (if set to true) that the type refers to earnings guaranteed by a mandatory holiday.
		/// DAC: PX.Objects.EP.EPEarningType 
		/// Display Name: Public Holiday 
		/// </summary>
		[DataMember(Name="PublicHoliday", EmitDefaultValue=false)]
		public BooleanValue? PublicHoliday { get; set; }

		/// <summary>
		/// The user-friendly unique identifier of the earning type to be used for calculation of the PTO amount.The field is included in RegularEarningType.
		/// DAC Field Name: RegularTypeCD 
		/// DAC: PX.Objects.EP.EPEarningType 
		/// Display Name: Regular Time Type Code 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="RegularTimeTypeCode", EmitDefaultValue=false)]
		public StringValue? RegularTimeTypeCode { get; set; }

		[DataMember(Name="TaxAndReportingCA", EmitDefaultValue=false)]
		public TaxAndReportingCA? TaxAndReportingCA { get; set; }

		[DataMember(Name="TaxAndReportingUS", EmitDefaultValue=false)]
		public TaxAndReportingUS? TaxAndReportingUS { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}