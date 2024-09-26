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
	/// Corresponds to the screen GL203000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Subaccount : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Active 
		/// DAC: PX.Objects.GL.Sub 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Description 
		/// DAC: PX.Objects.GL.Sub 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Secured 
		/// DAC: PX.Objects.GL.Sub 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Secured", EmitDefaultValue=false)]
		public BooleanValue? Secured { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SubCD 
		/// DAC: PX.Objects.GL.Sub 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SubaccountCD", EmitDefaultValue=false)]
		public StringValue? SubaccountCD { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SubID 
		/// DAC: PX.Objects.GL.Sub 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SubaccountID", EmitDefaultValue=false)]
		public IntValue? SubaccountID { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}