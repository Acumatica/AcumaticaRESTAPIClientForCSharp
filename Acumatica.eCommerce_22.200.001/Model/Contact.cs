using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_22_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen CR302000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Contact : Acumatica.Default_22_200_001.Model.Contact, ITopLevelEntity
	{

		[DataMember(Name="RoleAssignments", EmitDefaultValue=false)]
		public List<BCRoleAssignment>? RoleAssignments { get; set; }

		public override string GetEndpointPath()
		{
			return "entity/eCommerce/22.200.001";
		}
	}
}