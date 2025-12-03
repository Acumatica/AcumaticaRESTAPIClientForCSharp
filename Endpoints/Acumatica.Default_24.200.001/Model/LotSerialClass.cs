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
	/// Corresponds to the screen <c>IN207000</c> in the Acumatica ERP
	/// <para>Key Fields: ClassID</para>
	/// </summary>
	[DataContract]
	public class LotSerialClass : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC Field Name: LotSerAssign</para>
		/// <para>DAC: PX.Objects.IN.INLotSerClass</para>
		/// <para>Display Name: Assignment Method</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="AssignmentMethod", EmitDefaultValue=false)]
		public StringValue? AssignmentMethod { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LotSerClassID</para>
		/// <para>DAC: PX.Objects.IN.INLotSerClass</para>
		/// <para>Display Name: Class ID</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ClassID", EmitDefaultValue=false)]
		public StringValue? ClassID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.IN.INLotSerClass</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LotSerIssueMethod</para>
		/// <para>DAC: PX.Objects.IN.INLotSerClass</para>
		/// <para>Display Name: Issue Method</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="IssueMethod", EmitDefaultValue=false)]
		public StringValue? IssueMethod { get; set; }

		[DataMember(Name="Segments", EmitDefaultValue=false)]
		public List<LotSerialClassSegment>? Segments { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LotSerTrackExpiration</para>
		/// <para>DAC: PX.Objects.IN.INLotSerClass</para>
		/// <para>Display Name: Track Expiration Date</para>
		/// </summary>
		[DataMember(Name="TrackExpirationDate", EmitDefaultValue=false)]
		public BooleanValue? TrackExpirationDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: LotSerTrack</para>
		/// <para>DAC: PX.Objects.IN.INLotSerClass</para>
		/// <para>Display Name: Tracking Method</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="TrackingMethod", EmitDefaultValue=false)]
		public StringValue? TrackingMethod { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Segments = "Segments";
			public const string Segments_Files = "Segments/Files";

			//Intentionally excluded
			//public const string All = "Files,Segments,Segments/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}