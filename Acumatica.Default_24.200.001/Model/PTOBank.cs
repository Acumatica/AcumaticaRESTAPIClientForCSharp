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
	/// Corresponds to the screen PR204000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class PTOBank : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AccrualMethod 
		/// DAC: PX.Objects.PR.PRPTOBank 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AccrualMethod", EmitDefaultValue=false)]
		public StringValue? AccrualMethod { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsCertifiedJobAccrual 
		/// DAC: PX.Objects.PR.PRPTOBank 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AccrueonCertifiedJobOnly", EmitDefaultValue=false)]
		public BooleanValue? AccrueonCertifiedJobOnly { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsActive 
		/// DAC: PX.Objects.PR.PRPTOBank 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ApplyBandingRules 
		/// DAC: PX.Objects.PR.PRPTOBank 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ApplyBandingRules", EmitDefaultValue=false)]
		public BooleanValue? ApplyBandingRules { get; set; }

		[DataMember(Name="BandingRules", EmitDefaultValue=false)]
		public PTOBankBandingRule? BandingRules { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CarryoverType 
		/// DAC: PX.Objects.PR.PRPTOBank 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CarryoverType", EmitDefaultValue=false)]
		public StringValue? CarryoverType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CreateFinancialTransaction 
		/// DAC: PX.Objects.PR.PRPTOBank 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CreateFinTransactions", EmitDefaultValue=false)]
		public BooleanValue? CreateFinTransactions { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DisbursingType 
		/// DAC: PX.Objects.PR.PRPTOBank 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DefaultDisbursingType", EmitDefaultValue=false)]
		public StringValue? DefaultDisbursingType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Description 
		/// DAC: PX.Objects.PR.PRPTOBank 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: EarningTypeCD 
		/// DAC: PX.Objects.PR.PRPTOBank 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DisbursingEarningType", EmitDefaultValue=false)]
		public StringValue? DisbursingEarningType { get; set; }

		[DataMember(Name="EmployeeClassSettings", EmitDefaultValue=false)]
		public List<PTOBankEmployeeClassSetting>? EmployeeClassSettings { get; set; }

		[DataMember(Name="GLAccounts", EmitDefaultValue=false)]
		public PTOBankGLAccounts? GLAccounts { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SettlementBalanceType 
		/// DAC: PX.Objects.PR.PRPTOBank 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OnSettlement", EmitDefaultValue=false)]
		public StringValue? OnSettlement { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BankID 
		/// DAC: PX.Objects.PR.PRPTOBank 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PTOBankID", EmitDefaultValue=false)]
		public StringValue? PTOBankID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StartDate 
		/// DAC: PX.Objects.PR.PRPTOBank 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TransferDate", EmitDefaultValue=false)]
		public DateTimeValue? TransferDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StartDateDay 
		/// DAC: PX.Objects.PR.PRPTOBank 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TransferDateDay", EmitDefaultValue=false)]
		public IntValue? TransferDateDay { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StartDateMonth 
		/// DAC: PX.Objects.PR.PRPTOBank 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TransferDateMonth", EmitDefaultValue=false)]
		public StringValue? TransferDateMonth { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TransferDateType 
		/// DAC: PX.Objects.PR.PRPTOBank 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TransferDateType", EmitDefaultValue=false)]
		public StringValue? TransferDateType { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}