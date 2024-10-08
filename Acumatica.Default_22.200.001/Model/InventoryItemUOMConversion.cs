using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class InventoryItemUOMConversion : Entity
	{

		/// <summary>
		/// DAC Field Name: UnitRate 
		/// DAC: PX.Objects.IN.INUnit 
		/// Display Name: Conversion Factor 
		/// </summary>
		[DataMember(Name="ConversionFactor", EmitDefaultValue=false)]
		public DecimalValue? ConversionFactor { get; set; }

		/// <summary>
		/// DAC Field Name: FromUnit 
		/// DAC: PX.Objects.IN.INUnit 
		/// Display Name: From Unit 
		/// SQL Type: nvarchar(6) 
		/// Key Field
		/// </summary>
		[DataMember(Name="FromUOM", EmitDefaultValue=false)]
		public StringValue? FromUOM { get; set; }

		/// <summary>
		/// DAC Field Name: UnitMultDiv 
		/// DAC: PX.Objects.IN.INUnit 
		/// Display Name: Multiply/Divide 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="MultiplyOrDivide", EmitDefaultValue=false)]
		public StringValue? MultiplyOrDivide { get; set; }

		[DataMember(Name="ToUOM", EmitDefaultValue=false)]
		public StringValue? ToUOM { get; set; }

	}
}