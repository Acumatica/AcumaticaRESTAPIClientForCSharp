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
	/// Corresponds to the screen GL509001 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ConsolidationData : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BranchCD 
		/// DAC: PX.Objects.GL.Consolidation.ConsolSourceDataMaint+ConsolRecordsFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BranchCD", EmitDefaultValue=false)]
		public StringValue? BranchCD { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LedgerCD 
		/// DAC: PX.Objects.GL.Consolidation.ConsolSourceDataMaint+ConsolRecordsFilter 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="LedgerCD", EmitDefaultValue=false)]
		public StringValue? LedgerCD { get; set; }

		[DataMember(Name="Result", EmitDefaultValue=false)]
		public List<ConsolidationItem>? Result { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/GLConsolidation/22.200.001";
		}
	}
}