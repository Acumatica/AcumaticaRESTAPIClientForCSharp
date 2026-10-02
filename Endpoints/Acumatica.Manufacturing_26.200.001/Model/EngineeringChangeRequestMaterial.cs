using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_26_200_001.Model
{
	public class EngineeringChangeRequestMaterial : Entity
	{

		#region Fields
		public BooleanValue? Backflush { get; set; }

		public DecimalValue? BatchSize { get; set; }

		public StringValue? BubbleNbr { get; set; }

		public StringValue? ChangeStatus { get; set; }

		public StringValue? CompBOMID { get; set; }

		public StringValue? CompBOMRevision { get; set; }

		public StringValue? Description { get; set; }

		public StringValue? ECRID { get; set; }

		public DateTimeValue? EffectiveDate { get; set; }

		public DateTimeValue? ExpirationDate { get; set; }

		public StringValue? InventoryID { get; set; }

		public IntValue? LineNbr { get; set; }

		public IntValue? LineOrder { get; set; }

		public StringValue? Location { get; set; }

		public StringValue? MaterialType { get; set; }

		public StringValue? OperationID { get; set; }

		public StringValue? PhantomRouting { get; set; }

		public DecimalValue? PlannedCost { get; set; }

		public DecimalValue? QtyRequired { get; set; }

		public StringValue? Revision { get; set; }

		public DecimalValue? ScrapFactor { get; set; }

		public StringValue? SubcontractSource { get; set; }

		public StringValue? Subitem { get; set; }

		public DecimalValue? UnitCost { get; set; }

		public StringValue? UOM { get; set; }

		public StringValue? Warehouse { get; set; }

		#endregion

		#region Details
		public List<ECRReferenceDesignator>? ReferenceDesignators { get; set; }

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
			public const string ReferenceDesignators = "ReferenceDesignators";

			//Intentionally excluded
			//public const string All = "Files,ReferenceDesignators";
		}
	}
}