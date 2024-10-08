using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AM505000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class RegenerateMRP : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC Field Name: LastMrpRegenCompletedDateTime 
		/// DAC: PX.Objects.AM.MrpProcessingSetup 
		/// Display Name: Last Completed At 
		/// </summary>
		[DataMember(Name="LastCompletedAt", EmitDefaultValue=false)]
		public DateTimeValue? LastCompletedAt { get; set; }

		/// <summary>
		/// DAC Field Name: LastMrpRegenCompletedByID 
		/// DAC: PX.Objects.AM.MrpProcessingSetup 
		/// Display Name: Last Completed By 
		/// </summary>
		[DataMember(Name="LastCompletedBy", EmitDefaultValue=false)]
		public StringValue? LastCompletedBy { get; set; }

		[DataMember(Name="Messages", EmitDefaultValue=false)]
		public List<RegenerateMRPMessage>? Messages { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.200.001";
		}
	}
}