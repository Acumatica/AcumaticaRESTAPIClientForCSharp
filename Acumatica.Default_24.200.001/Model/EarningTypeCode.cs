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
		/// 
		/// Display Name:
		/// DAC Field Name: AccruePTO 
		/// DAC: PX.Objects.EP.EPEarningType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AccrueTimeOff", EmitDefaultValue=false)]
		public BooleanValue? AccrueTimeOff { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsActive 
		/// DAC: PX.Objects.EP.EPEarningType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: EarningTypeCategory 
		/// DAC: PX.Objects.EP.EPEarningType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Category", EmitDefaultValue=false)]
		public StringValue? Category { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsWCCCalculation 
		/// DAC: PX.Objects.EP.EPEarningType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ContributestoWCCCalculation", EmitDefaultValue=false)]
		public BooleanValue? ContributestoWCCCalculation { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Description 
		/// DAC: PX.Objects.EP.EPEarningType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TypeCD 
		/// DAC: PX.Objects.EP.EPEarningType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EarningTypeCodeID", EmitDefaultValue=false)]
		public StringValue? EarningTypeCodeID { get; set; }

		[DataMember(Name="GLAccounts", EmitDefaultValue=false)]
		public EarningCodeGLAccounts? GLAccounts { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OvertimeMultiplier 
		/// DAC: PX.Objects.EP.EPEarningType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Multiplier", EmitDefaultValue=false)]
		public DecimalValue? Multiplier { get; set; }

		[DataMember(Name="ProjectSettings", EmitDefaultValue=false)]
		public EarningCodeProjectSettings? ProjectSettings { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PublicHoliday 
		/// DAC: PX.Objects.EP.EPEarningType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PublicHoliday", EmitDefaultValue=false)]
		public BooleanValue? PublicHoliday { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RegularTypeCD 
		/// DAC: PX.Objects.EP.EPEarningType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
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