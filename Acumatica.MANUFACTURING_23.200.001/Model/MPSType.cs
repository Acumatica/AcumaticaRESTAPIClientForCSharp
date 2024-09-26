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
	/// Corresponds to the screen AM203000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class MPSType : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Dependent 
		/// DAC: PX.Objects.AM.AMMPSType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Dependent", EmitDefaultValue=false)]
		public BooleanValue? Dependent { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AM.AMMPSType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MPSNumberingID 
		/// DAC: PX.Objects.AM.AMMPSType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="NumberingSequence", EmitDefaultValue=false)]
		public StringValue? NumberingSequence { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: MPSTypeID 
		/// DAC: PX.Objects.AM.AMMPSType 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TypeID", EmitDefaultValue=false)]
		public StringValue? TypeID { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.200.001";
		}
	}
}