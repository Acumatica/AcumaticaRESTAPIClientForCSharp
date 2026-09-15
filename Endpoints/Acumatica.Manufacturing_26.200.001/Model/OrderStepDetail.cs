using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_26_200_001.Model
{
	[DataContract]
	public class OrderStepDetail : Entity
	{

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="LineID", EmitDefaultValue=false)]
		public IntValue? LineID { get; set; }

		[DataMember(Name="LineOrder", EmitDefaultValue=false)]
		public IntValue? LineOrder { get; set; }

		[DataMember(Name="PhantomBomID", EmitDefaultValue=false)]
		public StringValue? PhantomBomID { get; set; }

		[DataMember(Name="PhantomBOMLineID", EmitDefaultValue=false)]
		public IntValue? PhantomBOMLineID { get; set; }

		[DataMember(Name="PhantomBOMOperNbr", EmitDefaultValue=false)]
		public StringValue? PhantomBOMOperNbr { get; set; }

		[DataMember(Name="PhantomBOMRevision", EmitDefaultValue=false)]
		public StringValue? PhantomBOMRevision { get; set; }

		[DataMember(Name="PhantomLevel", EmitDefaultValue=false)]
		public IntValue? PhantomLevel { get; set; }

		[DataMember(Name="PhantomMatlBOMID", EmitDefaultValue=false)]
		public StringValue? PhantomMatlBOMID { get; set; }

		[DataMember(Name="PhantomMatlLineID", EmitDefaultValue=false)]
		public IntValue? PhantomMatlLineID { get; set; }

		[DataMember(Name="PhantomMatlOperNbr", EmitDefaultValue=false)]
		public StringValue? PhantomMatlOperNbr { get; set; }

		[DataMember(Name="PhantomMatlRevision", EmitDefaultValue=false)]
		public StringValue? PhantomMatlRevision { get; set; }

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