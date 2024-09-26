using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
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
		/// DAC Field Name: AccrualLimit 
		/// DAC: PX.Objects.PR.PREmployeeClassPTOBank 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AccrualLimit", EmitDefaultValue=false)]
		public DecimalValue? AccrualLimit { get; set; }

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
		/// DAC Field Name: AllowNegativeBalance 
		/// DAC: PX.Objects.PR.PREmployeeClassPTOBank 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AllowNegativeBalance", EmitDefaultValue=false)]
		public BooleanValue? AllowNegativeBalance { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: StartDate 
		/// DAC: PX.Objects.PR.PRPTOBank 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BankStartDate", EmitDefaultValue=false)]
		public DateTimeValue? BankStartDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DisburseFromCarryover 
		/// DAC: PX.Objects.PR.PREmployeeClassPTOBank 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CanOnlyDisbursefromCarryover", EmitDefaultValue=false)]
		public BooleanValue? CanOnlyDisbursefromCarryover { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CarryoverAmount 
		/// DAC: PX.Objects.PR.PREmployeeClassPTOBank 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CarryoverAmount", EmitDefaultValue=false)]
		public DecimalValue? CarryoverAmount { get; set; }

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
		/// DAC Field Name: AccrualRate 
		/// DAC: PX.Objects.PR.PREmployeeClassPTOBank 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DefaultAccrualPercent", EmitDefaultValue=false)]
		public DecimalValue? DefaultAccrualPercent { get; set; }

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
		[DataMember(Name="DisbursingEarningCode", EmitDefaultValue=false)]
		public StringValue? DisbursingEarningCode { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FrontLoadingAmount 
		/// DAC: PX.Objects.PR.PREmployeeClassPTOBank 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FrontLoadingAmount", EmitDefaultValue=false)]
		public DecimalValue? FrontLoadingAmount { get; set; }

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

		[DataMember(Name="PayCarryoverafterMonths", EmitDefaultValue=false)]
		public IntValue? PayCarryoverafterMonths { get; set; }

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

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}