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
	/// Corresponds to the screen GL103004 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Organization : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The name of the organization.
		/// DAC: PX.Objects.GL.DAC.Organization 
		/// Display Name: Company Name 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="OrganizationName", EmitDefaultValue=false)]
		public StringValue? OrganizationName { get; set; }

		/// <summary>
		/// DAC: PX.Objects.GL.DAC.Organization 
		/// Display Name: Company ID 
		/// SQL Type: nvarchar(30) 
		/// Key Field
		/// </summary>
		[DataMember(Name="OrganizationCD", EmitDefaultValue=false)]
		public StringValue? OrganizationCD { get; set; }

		/// <summary>
		/// DAC Field Name: Ledger__LedgerCD 
		/// DAC: PX.Objects.GL.DAC.Organization 
		/// </summary>
		[DataMember(Name="LedgerCD", EmitDefaultValue=false)]
		public StringValue? LedgerCD { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/GLConsolidation/22.200.001";
		}
	}
}