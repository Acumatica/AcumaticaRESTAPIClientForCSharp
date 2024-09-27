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
		/// When set to true, indicates that the system must use the Ledger as a source Ledger for consolidation.
		/// DAC Field Name: ConsolAllowed 
		/// DAC: PX.Objects.GL.Ledger 
		/// Display Name: Consolidation Source 
		/// </summary>
		[DataMember(Name="ConsolidationSource", EmitDefaultValue=false)]
		public BooleanValue? ConsolidationSource { get; set; }

		/// <summary>
		/// Base Currency of the Ledger.
		/// DAC Field Name: BaseCuryID 
		/// DAC: PX.Objects.GL.Ledger 
		/// SQL Type: nvarchar(5) 
		/// </summary>
		[DataMember(Name="Currency", EmitDefaultValue=false)]
		public StringValue? Currency { get; set; }

		/// <summary>
		/// The description of the Ledger.
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.GL.Ledger 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// Key field.Unique user-friendly identifier of the Ledger.
		/// DAC Field Name: LedgerCD 
		/// DAC: PX.Objects.GL.Ledger 
		/// Display Name: Ledger ID 
		/// SQL Type: nvarchar(10) 
		/// Key Field
		/// </summary>
		[DataMember(Name="LedgerID", EmitDefaultValue=false)]
		public StringValue? LedgerID { get; set; }

		/// <summary>
		/// The type of the balance of the ledger.
		/// DAC Field Name: BalanceType 
		/// DAC: PX.Objects.GL.Ledger 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}