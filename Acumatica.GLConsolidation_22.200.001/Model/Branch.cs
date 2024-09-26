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
	/// Corresponds to the screen GL103002 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Branch : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AcctName 
		/// DAC: PX.Objects.GL.Branch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AcctName", EmitDefaultValue=false)]
		public StringValue? AcctName { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BranchCD 
		/// DAC: PX.Objects.GL.Branch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BranchCD", EmitDefaultValue=false)]
		public StringValue? BranchCD { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Organization__OrganizationCD 
		/// DAC: PX.Objects.GL.Branch 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OrganizationCD", EmitDefaultValue=false)]
		public StringValue? OrganizationCD { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Ledger__LedgerCD 
		/// DAC: PX.Objects.GL.Branch 
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