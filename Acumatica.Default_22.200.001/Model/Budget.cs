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
	/// Corresponds to the screen GL302010 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Budget : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.GL.BudgetFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CompareToBranchID 
		/// DAC: PX.Objects.GL.BudgetFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ComparetoBranch", EmitDefaultValue=false)]
		public StringValue? ComparetoBranch { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CompareToLedgerID 
		/// DAC: PX.Objects.GL.BudgetFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ComparetoLedger", EmitDefaultValue=false)]
		public StringValue? ComparetoLedger { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CompareToFinYear 
		/// DAC: PX.Objects.GL.BudgetFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ComparetoYear", EmitDefaultValue=false)]
		public StringValue? ComparetoYear { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<BudgetDetail>? Details { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FinYear 
		/// DAC: PX.Objects.GL.BudgetFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FinancialYear", EmitDefaultValue=false)]
		public StringValue? FinancialYear { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LedgerId 
		/// DAC: PX.Objects.GL.BudgetFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Ledger", EmitDefaultValue=false)]
		public StringValue? Ledger { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SubIDFilter 
		/// DAC: PX.Objects.GL.BudgetFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SubaccountFilter", EmitDefaultValue=false)]
		public StringValue? SubaccountFilter { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TreeNodeFilter 
		/// DAC: PX.Objects.GL.BudgetFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TreeNodeFilter", EmitDefaultValue=false)]
		public StringValue? TreeNodeFilter { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}