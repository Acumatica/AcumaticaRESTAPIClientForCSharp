using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.DeviceHub_26_100_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>SM206530</c> in the Acumatica ERP
	/// </summary>
	public class Scales : Entity, ITopLevelEntity
	{

		#region Fields
		public StringValue? Description { get; set; }

		public StringValue? DeviceHub { get; set; }

		public DateTimeValue? LastUpdated { get; set; }

		public DecimalValue? LastWeight { get; set; }

		public StringValue? ScaleID { get; set; }

		public DecimalValue? ScaleLastWeight { get; set; }

		public StringValue? ScaleUOM { get; set; }

		public StringValue? UOM { get; set; }

		#endregion

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