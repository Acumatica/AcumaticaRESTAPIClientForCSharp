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
	/// Corresponds to the screen GL201500 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Ledger : Entity, ITopLevelEntity
	{

		[DataMember(Name="Branches", EmitDefaultValue=false)]
		public List<LedgerBranches>? Branches { get; set; }

		[DataMember(Name="Companies", EmitDefaultValue=false)]
		public List<LedgerCompanies>? Companies { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ConsolAllowed 
		/// DAC: PX.Objects.GL.Ledger 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ConsolidationSource", EmitDefaultValue=false)]
		public BooleanValue? ConsolidationSource { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BaseCuryID 
		/// DAC: PX.Objects.GL.Ledger 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Currency", EmitDefaultValue=false)]
		public StringValue? Currency { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.GL.Ledger 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LedgerCD 
		/// DAC: PX.Objects.GL.Ledger 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LedgerID", EmitDefaultValue=false)]
		public StringValue? LedgerID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BalanceType 
		/// DAC: PX.Objects.GL.Ledger 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}