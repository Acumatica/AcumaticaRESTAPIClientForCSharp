using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen CS203100 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class UnitsOfMeasure : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: UnitRate 
		/// DAC: PX.Objects.IN.INUnit 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ConversionFactor", EmitDefaultValue=false)]
		public DecimalValue? ConversionFactor { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: FromUnit 
		/// DAC: PX.Objects.IN.INUnit 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="FromUOM", EmitDefaultValue=false)]
		public StringValue? FromUOM { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: UnitMultDiv 
		/// DAC: PX.Objects.IN.INUnit 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="MultiplyOrDivide", EmitDefaultValue=false)]
		public StringValue? MultiplyOrDivide { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ToUnit 
		/// DAC: PX.Objects.IN.INUnit 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ToUOM", EmitDefaultValue=false)]
		public StringValue? ToUOM { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}