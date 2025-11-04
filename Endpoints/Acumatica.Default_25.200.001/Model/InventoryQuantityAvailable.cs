using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen SO640590 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class InventoryQuantityAvailable : Entity, ITopLevelEntity
	{

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="Results", EmitDefaultValue=false)]
		public List<InventoryQuantityAvailableDetail>? Results { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Results = "Results";
			public const string Results_Files = "Results/Files";

			//Intentionally excluded
			//public const string All = "Files,Results,Results/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/25.200.001";
		}
	}
}