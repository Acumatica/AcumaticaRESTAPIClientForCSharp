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
		/// The type of the balance of the ledger.
		/// DAC: PX.Objects.GL.Ledger 
		/// Display Name: Type 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="BalanceType", EmitDefaultValue=false)]
		public StringValue? BalanceType { get; set; }

		/// <summary>
		/// The description of the Ledger.
		/// DAC: PX.Objects.GL.Ledger 
		/// Display Name: Description 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="Descr", EmitDefaultValue=false)]
		public StringValue? Descr { get; set; }

		/// <summary>
		/// Key field.Unique user-friendly identifier of the Ledger.
		/// DAC: PX.Objects.GL.Ledger 
		/// Display Name: Ledger ID 
		/// SQL Type: nvarchar(10) 
		/// Key Field
		/// </summary>
		[DataMember(Name="LedgerCD", EmitDefaultValue=false)]
		public StringValue? LedgerCD { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/GLConsolidation/22.200.001";
		}
	}
}