using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	public class LotSerialClassSegment : Entity
	{

		#region Fields
		/// <summary>
		/// <para>DAC Field Name: SegmentID</para>
		/// <para>DAC: PX.Objects.IN.INLotSerSegment</para>
		/// <para>Display Name: Segment Number</para>
		/// Key Field
		/// </summary>
		public ShortValue? SegmentNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SegmentType</para>
		/// <para>DAC: PX.Objects.IN.INLotSerSegment</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Type { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SegmentValue</para>
		/// <para>DAC: PX.Objects.IN.INLotSerSegment</para>
		/// <para>SQL Type: nvarchar(30)</para>
		/// </summary>
		public StringValue? Value { get; set; }

		#endregion

		/// <summary>
		/// Names that can be passed in the <c>$expand</c> parameter.
		/// <para>This endpoint uses system contract 5, where a nested entity is expanded
		/// as <c>Parent($expand=Child)</c> rather than <c>Parent/Child</c>, so only the names
		/// that can be expanded directly on this entity are listed here. Use the nested
		/// entity's own <c>Expand</c> class for the inner names.</para>
		/// </summary>
		public static class Expand
		{
			public const string Files = "Files";

			//Intentionally excluded
			//public const string All = "Files";
		}
	}
}