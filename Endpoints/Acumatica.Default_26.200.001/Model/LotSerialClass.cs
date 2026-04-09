using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	[DataContract]
	public class LotSerialClass : Entity, ITopLevelEntity
	{

		[DataMember(Name="AssignmentMethod", EmitDefaultValue=false)]
		public StringValue? AssignmentMethod { get; set; }

		[DataMember(Name="ClassID", EmitDefaultValue=false)]
		public StringValue? ClassID { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="IssueMethod", EmitDefaultValue=false)]
		public StringValue? IssueMethod { get; set; }

		[DataMember(Name="Segments", EmitDefaultValue=false)]
		public List<LotSerialClassSegment>? Segments { get; set; }

		[DataMember(Name="TrackExpirationDate", EmitDefaultValue=false)]
		public BooleanValue? TrackExpirationDate { get; set; }

		[DataMember(Name="TrackingMethod", EmitDefaultValue=false)]
		public StringValue? TrackingMethod { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Segments = "Segments";
			public const string Segments_Files = "Segments/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Segments,Segments/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}