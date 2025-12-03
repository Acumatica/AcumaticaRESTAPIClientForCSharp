using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class LotSerialClassSegment : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: SegmentID</para>
		/// <para>DAC: PX.Objects.IN.INLotSerSegment</para>
		/// <para>Display Name: Segment Number</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="SegmentNbr", EmitDefaultValue=false)]
		public ShortValue? SegmentNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SegmentType</para>
		/// <para>DAC: PX.Objects.IN.INLotSerSegment</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SegmentValue</para>
		/// <para>DAC: PX.Objects.IN.INLotSerSegment</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		[DataMember(Name="Value", EmitDefaultValue=false)]
		public StringValue? Value { get; set; }

	}
}