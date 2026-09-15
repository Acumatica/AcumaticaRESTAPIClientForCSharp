using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.DeviceHub_26_100_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>SM206530</c> in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Scales : Entity, ITopLevelEntity
	{

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="DeviceHub", EmitDefaultValue=false)]
		public StringValue? DeviceHub { get; set; }

		[DataMember(Name="LastUpdated", EmitDefaultValue=false)]
		public DateTimeValue? LastUpdated { get; set; }

		[DataMember(Name="LastWeight", EmitDefaultValue=false)]
		public DecimalValue? LastWeight { get; set; }

		[DataMember(Name="ScaleID", EmitDefaultValue=false)]
		public StringValue? ScaleID { get; set; }

		[DataMember(Name="ScaleLastWeight", EmitDefaultValue=false)]
		public DecimalValue? ScaleLastWeight { get; set; }

		[DataMember(Name="ScaleUOM", EmitDefaultValue=false)]
		public StringValue? ScaleUOM { get; set; }

		[DataMember(Name="UOM", EmitDefaultValue=false)]
		public StringValue? UOM { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";

			//Intentionally excluded
			//public const string All = "Files,Translations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/DeviceHub/26.100.001";
		}
	}
}