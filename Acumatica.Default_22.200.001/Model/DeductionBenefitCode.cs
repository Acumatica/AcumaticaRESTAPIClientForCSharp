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
	/// Corresponds to the screen PR101060 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class DeductionBenefitCode : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AcaApplicable 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ACAApplicable", EmitDefaultValue=false)]
		public BooleanValue? ACAApplicable { get; set; }

		[DataMember(Name="ACAInformation", EmitDefaultValue=false)]
		public ACAInformation? ACAInformation { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsActive 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AffectsTaxes 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AffectsTaxCalculation", EmitDefaultValue=false)]
		public BooleanValue? AffectsTaxCalculation { get; set; }

		[DataMember(Name="ApplicableWage", EmitDefaultValue=false)]
		public ApplicableWage? ApplicableWage { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AssociatedSource 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AssociatedWith", EmitDefaultValue=false)]
		public StringValue? AssociatedWith { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ContribType 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ContributionType", EmitDefaultValue=false)]
		public StringValue? ContributionType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CodeCD 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DeductionBenefitCodeID", EmitDefaultValue=false)]
		public StringValue? DeductionBenefitCodeID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Description 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="EmployeeDeduction", EmitDefaultValue=false)]
		public EmployeeDeduction? EmployeeDeduction { get; set; }

		[DataMember(Name="EmployerContribution", EmitDefaultValue=false)]
		public EmployerContribution? EmployerContribution { get; set; }

		[DataMember(Name="GLAccounts", EmitDefaultValue=false)]
		public DeductionOrBenefitCodeGLAccounts? GLAccounts { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DedInvDescrType 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="InvoiceDescrSource", EmitDefaultValue=false)]
		public StringValue? InvoiceDescrSource { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsGarnishment 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="IsGarnishment", EmitDefaultValue=false)]
		public BooleanValue? IsGarnishment { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsPayableBenefit 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PayableBenefit", EmitDefaultValue=false)]
		public BooleanValue? PayableBenefit { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ShowApplicableWageTab 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ShowApplicableWageTab", EmitDefaultValue=false)]
		public BooleanValue? ShowApplicableWageTab { get; set; }

		[DataMember(Name="TaxSettingsCA", EmitDefaultValue=false)]
		public TaxSettingsCA? TaxSettingsCA { get; set; }

		[DataMember(Name="TaxSettingsUS", EmitDefaultValue=false)]
		public TaxSettingsUS? TaxSettingsUS { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BAccountID 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Vendor", EmitDefaultValue=false)]
		public StringValue? Vendor { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: VndInvDescr 
		/// DAC: PX.Objects.PR.PRDeductCode 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="VendorInvoiceDescription", EmitDefaultValue=false)]
		public StringValue? VendorInvoiceDescription { get; set; }

		[DataMember(Name="WCCCode", EmitDefaultValue=false)]
		public DeductionBenefitWCCCode? WCCCode { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}