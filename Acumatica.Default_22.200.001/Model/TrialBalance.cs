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
	/// Corresponds to the screen GL303010 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class TrialBalance : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC: PX.Objects.GL.GLTrialBalanceImportMap 
		/// Display Name: Batch Number 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="BatchNbr", EmitDefaultValue=false)]
		public StringValue? BatchNbr { get; set; }

		/// <summary>
		/// A reference to the BAccountAn integer identifier of the organizational entity.BAccountID of the Organization if OrganizationType != OrganizationTypes.WithBranchesBalancingBAccountID of the Branch if OrganizationType = OrganizationTypes.WithBranchesBalancing
		/// DAC Field Name: OrgBAccountID 
		/// DAC: PX.Objects.GL.GLTrialBalanceImportMap 
		/// Display Name: Company/Branch 
		/// </summary>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// DAC Field Name: TotalBalance 
		/// DAC: PX.Objects.GL.GLTrialBalanceImportMap 
		/// Display Name: Control Total 
		/// </summary>
		[DataMember(Name="ControlTotal", EmitDefaultValue=false)]
		public DecimalValue? ControlTotal { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// DAC Field Name: CreditTotalBalance 
		/// DAC: PX.Objects.GL.GLTrialBalanceImportMap 
		/// Display Name: Credit Total 
		/// </summary>
		[DataMember(Name="CreditTotal", EmitDefaultValue=false)]
		public DecimalValue? CreditTotal { get; set; }

		/// <summary>
		/// DAC Field Name: DebitTotalBalance 
		/// DAC: PX.Objects.GL.GLTrialBalanceImportMap 
		/// Display Name: Debit Total 
		/// </summary>
		[DataMember(Name="DebitTotal", EmitDefaultValue=false)]
		public DecimalValue? DebitTotal { get; set; }

		/// <summary>
		/// DAC: PX.Objects.GL.GLTrialBalanceImportMap 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<TrialBalanceDetail>? Details { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		/// <summary>
		/// DAC: PX.Objects.GL.GLTrialBalanceImportMap 
		/// Display Name: Import Date 
		/// </summary>
		[DataMember(Name="ImportDate", EmitDefaultValue=false)]
		public DateTimeValue? ImportDate { get; set; }

		/// <summary>
		/// DAC Field Name: Number 
		/// DAC: PX.Objects.GL.GLTrialBalanceImportMap 
		/// Display Name: Import Number 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ImportNbr", EmitDefaultValue=false)]
		public StringValue? ImportNbr { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// DAC Field Name: LedgerID 
		/// DAC: PX.Objects.GL.GLTrialBalanceImportMap 
		/// </summary>
		[DataMember(Name="Ledger", EmitDefaultValue=false)]
		public StringValue? Ledger { get; set; }

		/// <summary>
		/// DAC Field Name: FinPeriodID 
		/// DAC: PX.Objects.GL.GLTrialBalanceImportMap 
		/// SQL Type: char(6) 
		/// </summary>
		[DataMember(Name="Period", EmitDefaultValue=false)]
		public StringValue? Period { get; set; }

		/// <summary>
		/// DAC: PX.Objects.GL.GLTrialBalanceImportMap 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}