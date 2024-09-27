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
		/// The name of the branch.
		/// DAC: PX.Objects.GL.Branch 
		/// Display Name: Branch Name 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="AcctName", EmitDefaultValue=false)]
		public StringValue? AcctName { get; set; }

		/// <summary>
		/// Key field.User-friendly unique identifier of the Branch.
		/// DAC: PX.Objects.GL.Branch 
		/// Display Name: Branch ID 
		/// SQL Type: nvarchar(30) 
		/// Key Field
		/// </summary>
		[DataMember(Name="BranchCD", EmitDefaultValue=false)]
		public StringValue? BranchCD { get; set; }

		/// <summary>
		/// DAC Field Name: Organization__OrganizationCD 
		/// DAC: PX.Objects.GL.Branch 
		/// </summary>
		[DataMember(Name="OrganizationCD", EmitDefaultValue=false)]
		public StringValue? OrganizationCD { get; set; }

		/// <summary>
		/// DAC Field Name: Ledger__LedgerCD 
		/// DAC: PX.Objects.GL.Branch 
		/// </summary>
		[DataMember(Name="LedgerCD", EmitDefaultValue=false)]
		public StringValue? LedgerCD { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/GLConsolidation/22.200.001";
		}
	}
}