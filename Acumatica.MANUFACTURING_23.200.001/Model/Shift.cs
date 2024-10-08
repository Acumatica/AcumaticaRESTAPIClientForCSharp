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
	/// Corresponds to the screen AM205000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Shift : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC Field Name: AMCrewSize 
		/// DAC: PX.Objects.EP.EPShiftCode 
		/// </summary>
		[DataMember(Name="CrewSize", EmitDefaultValue=false)]
		public DecimalValue? CrewSize { get; set; }

		/// <summary>
		/// DAC: PX.Objects.EP.EPShiftCode 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC: PX.Objects.EP.EPShiftCode 
		/// </summary>
		[DataMember(Name="DiffType", EmitDefaultValue=false)]
		public StringValue? DiffType { get; set; }

		/// <summary>
		/// DAC Field Name: ShiftCD 
		/// DAC: PX.Objects.EP.EPShiftCode 
		/// Display Name: Code 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="shift", EmitDefaultValue=false)]
		public StringValue? shift { get; set; }

		/// <summary>
		/// DAC Field Name: ShftDiff 
		/// DAC: PX.Objects.EP.EPShiftCode 
		/// </summary>
		[DataMember(Name="ShiftDiff", EmitDefaultValue=false)]
		public DecimalValue? ShiftDiff { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/23.200.001";
		}
	}
}