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
	/// Corresponds to the screen GL401000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class AccountSummaryInquiry : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AccountClassID 
		/// DAC: PX.Objects.GL.GLHistoryEnqFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AccountClass", EmitDefaultValue=false)]
		public StringValue? AccountClass { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OrgBAccountID 
		/// DAC: PX.Objects.GL.GLHistoryEnqFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue? Branch { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LedgerID 
		/// DAC: PX.Objects.GL.GLHistoryEnqFilter 
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
		/// DAC: PX.Objects.GL.GLHistoryEnqFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Period", EmitDefaultValue=false)]
		public StringValue? Period { get; set; }

		[DataMember(Name="Results", EmitDefaultValue=false)]
		public List<AccountSummaryRow>? Results { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SubCD 
		/// DAC: PX.Objects.GL.GLHistoryEnqFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Subaccount", EmitDefaultValue=false)]
		public StringValue? Subaccount { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}