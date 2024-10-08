using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	/// <summary>
	/// Corresponds to the screen AM203000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class MPSType : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC: PX.Objects.AM.AMMPSType 
		/// </summary>
		[DataMember(Name="Dependent", EmitDefaultValue=false)]
		public BooleanValue? Dependent { get; set; }

		/// <summary>
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AM.AMMPSType 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: MPSNumberingID 
		/// DAC: PX.Objects.AM.AMMPSType 
		/// Display Name: Numbering Sequence 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="NumberingSequence", EmitDefaultValue=false)]
		public StringValue? NumberingSequence { get; set; }

		/// <summary>
		/// DAC Field Name: MPSTypeID 
		/// DAC: PX.Objects.AM.AMMPSType 
		/// Display Name: Type ID 
		/// SQL Type: nvarchar(20) 
		/// Key Field
		/// </summary>
		[DataMember(Name="TypeID", EmitDefaultValue=false)]
		public StringValue? TypeID { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.100.001";
		}
	}
}