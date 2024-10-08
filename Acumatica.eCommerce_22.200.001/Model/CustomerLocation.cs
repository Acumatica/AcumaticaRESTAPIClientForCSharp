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
	/// Corresponds to the screen AR303020 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class CustomerLocation : Acumatica.Default_22_200_001.Model.CustomerLocation, ITopLevelEntity
	{

		/// <summary>
		/// This field indicates whether the location is default for the corresponding business account.
		/// DAC Field Name: IsDefault 
		/// DAC: PX.Objects.CR.Location 
		/// </summary>
		[DataMember(Name="Default", EmitDefaultValue=false)]
		public BooleanValue? Default { get; set; }

		/// <summary>
		/// The current status of the location.
		/// DAC: PX.Objects.CR.Location 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="RoleAssignments", EmitDefaultValue=false)]
		public List<BCRoleAssignment>? RoleAssignments { get; set; }

		public override string GetEndpointPath()
		{
			return "entity/eCommerce/22.200.001";
		}
	}
}