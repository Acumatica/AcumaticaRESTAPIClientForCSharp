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
	/// Corresponds to the screen PR205000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class PayGroup : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BenefitExpenseAcctID 
		/// DAC: PX.Objects.PR.PRPayGroup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BenefitExpenseAccount", EmitDefaultValue=false)]
		public StringValue? BenefitExpenseAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BenefitExpenseSubID 
		/// DAC: PX.Objects.PR.PRPayGroup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BenefitExpenseSub", EmitDefaultValue=false)]
		public StringValue? BenefitExpenseSub { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BenefitLiabilityAcctID 
		/// DAC: PX.Objects.PR.PRPayGroup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BenefitLiabilityAccount", EmitDefaultValue=false)]
		public StringValue? BenefitLiabilityAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BenefitLiabilitySubID 
		/// DAC: PX.Objects.PR.PRPayGroup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BenefitLiabilitySub", EmitDefaultValue=false)]
		public StringValue? BenefitLiabilitySub { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DedLiabilityAcctID 
		/// DAC: PX.Objects.PR.PRPayGroup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DeductionLiabilityAccount", EmitDefaultValue=false)]
		public StringValue? DeductionLiabilityAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DedLiabilitySubID 
		/// DAC: PX.Objects.PR.PRPayGroup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DeductionLiabilitySub", EmitDefaultValue=false)]
		public StringValue? DeductionLiabilitySub { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: EarningsAcctID 
		/// DAC: PX.Objects.PR.PRPayGroup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EarningsAccount", EmitDefaultValue=false)]
		public StringValue? EarningsAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: EarningsSubID 
		/// DAC: PX.Objects.PR.PRPayGroup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EarningsSub", EmitDefaultValue=false)]
		public StringValue? EarningsSub { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsDefault 
		/// DAC: PX.Objects.PR.PRPayGroup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="IsDefault", EmitDefaultValue=false)]
		public BooleanValue? IsDefault { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PayGroupID 
		/// DAC: PX.Objects.PR.PRPayGroup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PayGroupID", EmitDefaultValue=false)]
		public StringValue? PayGroupID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Description 
		/// DAC: PX.Objects.PR.PRPayGroup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PayGroupName", EmitDefaultValue=false)]
		public StringValue? PayGroupName { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PTOAssetAcctID 
		/// DAC: PX.Objects.PR.PRPayGroup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PTOAssetAccount", EmitDefaultValue=false)]
		public StringValue? PTOAssetAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PTOAssetSubID 
		/// DAC: PX.Objects.PR.PRPayGroup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PTOAssetSub", EmitDefaultValue=false)]
		public StringValue? PTOAssetSub { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PTOExpenseAcctID 
		/// DAC: PX.Objects.PR.PRPayGroup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PTOExpenseAccount", EmitDefaultValue=false)]
		public StringValue? PTOExpenseAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PTOExpenseSubID 
		/// DAC: PX.Objects.PR.PRPayGroup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PTOExpenseSub", EmitDefaultValue=false)]
		public StringValue? PTOExpenseSub { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PTOLiabilityAcctID 
		/// DAC: PX.Objects.PR.PRPayGroup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PTOLiabilityAccount", EmitDefaultValue=false)]
		public StringValue? PTOLiabilityAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: PTOLiabilitySubID 
		/// DAC: PX.Objects.PR.PRPayGroup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PTOLiabilitySub", EmitDefaultValue=false)]
		public StringValue? PTOLiabilitySub { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TaxExpenseAcctID 
		/// DAC: PX.Objects.PR.PRPayGroup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TaxExpenseAccount", EmitDefaultValue=false)]
		public StringValue? TaxExpenseAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TaxExpenseSubID 
		/// DAC: PX.Objects.PR.PRPayGroup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TaxExpenseSub", EmitDefaultValue=false)]
		public StringValue? TaxExpenseSub { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TaxLiabilityAcctID 
		/// DAC: PX.Objects.PR.PRPayGroup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TaxLiabilityAccount", EmitDefaultValue=false)]
		public StringValue? TaxLiabilityAccount { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TaxLiabilitySubID 
		/// DAC: PX.Objects.PR.PRPayGroup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TaxLiabilitySub", EmitDefaultValue=false)]
		public StringValue? TaxLiabilitySub { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RoleName 
		/// DAC: PX.Objects.PR.PRPayGroup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UserRole", EmitDefaultValue=false)]
		public StringValue? UserRole { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}