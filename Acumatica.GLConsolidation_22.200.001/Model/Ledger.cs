using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.GLConsolidation_22_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen GL103003 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Ledger : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BalanceType 
		/// DAC: PX.Objects.GL.Ledger 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BalanceType", EmitDefaultValue=false)]
		public StringValue? BalanceType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.GL.Ledger 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Descr", EmitDefaultValue=false)]
		public StringValue? Descr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LedgerCD 
		/// DAC: PX.Objects.GL.Ledger 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LedgerCD", EmitDefaultValue=false)]
		public StringValue? LedgerCD { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/GLConsolidation/22.200.001";
		}
	}
}