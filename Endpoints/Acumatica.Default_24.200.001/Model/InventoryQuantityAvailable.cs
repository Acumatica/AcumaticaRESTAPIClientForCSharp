using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>SO640590</c> in the Acumatica ERP
	/// </summary>
	public class InventoryQuantityAvailable : Entity, ITopLevelEntity
	{

		#region Fields
		public StringValue? InventoryID { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		#endregion

		#region Details
		public List<InventoryQuantityAvailableDetail>? Results { get; set; }

		#endregion

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Results = "Results";
			public const string Results_Files = "Results/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Results,Results/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}