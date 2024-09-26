using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AM205000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Shift : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AMCrewSize 
		/// DAC: PX.Objects.EP.EPShiftCode 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CrewSize", EmitDefaultValue=false)]
		public DecimalValue? CrewSize { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Description 
		/// DAC: PX.Objects.EP.EPShiftCode 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DiffType 
		/// DAC: PX.Objects.EP.EPShiftCode 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DiffType", EmitDefaultValue=false)]
		public StringValue? DiffType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ShiftCD 
		/// DAC: PX.Objects.EP.EPShiftCode 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="shift", EmitDefaultValue=false)]
		public StringValue? shift { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ShftDiff 
		/// DAC: PX.Objects.EP.EPShiftCode 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ShiftDiff", EmitDefaultValue=false)]
		public DecimalValue? ShiftDiff { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}