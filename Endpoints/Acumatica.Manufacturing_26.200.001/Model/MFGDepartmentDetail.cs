using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_26_200_001.Model
{
	public class MFGDepartmentDetail : Entity
	{

		#region Fields
		public BooleanValue? Active { get; set; }

		public BooleanValue? AllowClockEntryforMultipleProductionOrders { get; set; }

		public BooleanValue? BackflushLabor { get; set; }

		public BooleanValue? BackflushMaterials { get; set; }

		public StringValue? BasisforCapacity { get; set; }

		public BooleanValue? ControlPoint { get; set; }

		public StringValue? Description { get; set; }

		public BooleanValue? OutsideProcess { get; set; }

		public StringValue? ScrapActionDefault { get; set; }

		public DecimalValue? StandardCost { get; set; }

		public StringValue? Warehouse { get; set; }

		public StringValue? WorkCenter { get; set; }

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