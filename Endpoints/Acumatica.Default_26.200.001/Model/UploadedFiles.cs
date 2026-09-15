using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>PM509001</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class UploadedFiles : Entity, ITopLevelEntity
	{

		[DataMember(Name="DocumentNumber", EmitDefaultValue=false)]
		public GuidValue? DocumentNumber { get; set; }

		[DataMember(Name="File", EmitDefaultValue=false)]
		public GuidValue? File { get; set; }

		[DataMember(Name="FileName", EmitDefaultValue=false)]
		public StringValue? FileName { get; set; }

		[DataMember(Name="LinkType", EmitDefaultValue=false)]
		public StringValue? LinkType { get; set; }

		[DataMember(Name="Name", EmitDefaultValue=false)]
		public StringValue? Name { get; set; }

		[DataMember(Name="ProjectID", EmitDefaultValue=false)]
		public StringValue? ProjectID { get; set; }

		[DataMember(Name="TagID", EmitDefaultValue=false)]
		public GuidValue? TagID { get; set; }

		[DataMember(Name="TagName", EmitDefaultValue=false)]
		public StringValue? TagName { get; set; }

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
			public const string Translations = "Translations";

			//Intentionally excluded
			//public const string All = "Files,Translations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}