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
	public class UnitsOfMeasure : Entity, ITopLevelEntity
	{

		[DataMember(Name="UnitID", EmitDefaultValue=false)]
		public StringValue? UnitID { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="L3Code", EmitDefaultValue=false)]
		public StringValue? L3Code { get; set; }

		[DataMember(Name="Conversion", EmitDefaultValue=false)]
		public List<Units>? Conversion { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Conversion = "Conversion";
			public const string Conversion_Files = "Conversion/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Conversion,Conversion/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}