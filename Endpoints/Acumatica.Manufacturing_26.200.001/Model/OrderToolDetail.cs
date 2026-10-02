using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_26_200_001.Model
{
	public class OrderToolDetail : Entity
	{

		#region Fields
		public StringValue? Description { get; set; }

		public IntValue? LineID { get; set; }

		public StringValue? PhantomBomID { get; set; }

		public IntValue? PhantomBOMLineID { get; set; }

		public StringValue? PhantomBOMOperNbr { get; set; }

		public StringValue? PhantomBOMRevision { get; set; }

		public IntValue? PhantomLevel { get; set; }

		public StringValue? PhantomMatlBOMID { get; set; }

		public IntValue? PhantomMatlLineID { get; set; }

		public StringValue? PhantomMatlOperNbr { get; set; }

		public StringValue? PhantomMatlRevision { get; set; }

		public DecimalValue? QtyRequired { get; set; }

		public StringValue? ToolID { get; set; }

		public StringValue? ToolIDDescription { get; set; }

		public StringValue? ToolIDToolID { get; set; }

		public DecimalValue? TotalActualCost { get; set; }

		public DecimalValue? TotalActualUses { get; set; }

		public DecimalValue? UnitCost { get; set; }

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