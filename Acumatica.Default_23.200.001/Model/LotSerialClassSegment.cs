using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class LotSerialClassSegment : Entity
	{

		/// <summary>
		/// DAC Field Name: SegmentID 
		/// DAC: PX.Objects.IN.INLotSerSegment 
		/// Display Name: Segment Number 
		/// Key Field
		/// </summary>
		[DataMember(Name="SegmentNbr", EmitDefaultValue=false)]
		public ShortValue? SegmentNbr { get; set; }

		/// <summary>
		/// DAC Field Name: SegmentType 
		/// DAC: PX.Objects.IN.INLotSerSegment 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		/// <summary>
		/// DAC Field Name: SegmentValue 
		/// DAC: PX.Objects.IN.INLotSerSegment 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="Value", EmitDefaultValue=false)]
		public StringValue? Value { get; set; }

	}
}