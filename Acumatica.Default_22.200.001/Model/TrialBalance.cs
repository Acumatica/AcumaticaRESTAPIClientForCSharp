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
		/// 
		/// Display Name:
		/// DAC Field Name: BatchNbr 
		/// DAC: PX.Objects.GL.GLTrialBalanceImportMap 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BatchNbr", EmitDefaultValue=false)]
		public StringValue? BatchNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OrgBAccountID 
		/// DAC: PX.Objects.GL.GLTrialBalanceImportMap 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TotalBalance 
		/// DAC: PX.Objects.GL.GLTrialBalanceImportMap 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ControlTotal", EmitDefaultValue=false)]
		public DecimalValue? ControlTotal { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CreditTotalBalance 
		/// DAC: PX.Objects.GL.GLTrialBalanceImportMap 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CreditTotal", EmitDefaultValue=false)]
		public DecimalValue? CreditTotal { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DebitTotalBalance 
		/// DAC: PX.Objects.GL.GLTrialBalanceImportMap 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DebitTotal", EmitDefaultValue=false)]
		public DecimalValue? DebitTotal { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Description 
		/// DAC: PX.Objects.GL.GLTrialBalanceImportMap 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<TrialBalanceDetail>? Details { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ImportDate 
		/// DAC: PX.Objects.GL.GLTrialBalanceImportMap 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ImportDate", EmitDefaultValue=false)]
		public DateTimeValue? ImportDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Number 
		/// DAC: PX.Objects.GL.GLTrialBalanceImportMap 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ImportNbr", EmitDefaultValue=false)]
		public StringValue? ImportNbr { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LedgerID 
		/// DAC: PX.Objects.GL.GLTrialBalanceImportMap 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Ledger", EmitDefaultValue=false)]
		public StringValue? Ledger { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FinPeriodID 
		/// DAC: PX.Objects.GL.GLTrialBalanceImportMap 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Period", EmitDefaultValue=false)]
		public StringValue? Period { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Status 
		/// DAC: PX.Objects.GL.GLTrialBalanceImportMap 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}