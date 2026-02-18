using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM215000</c> in the Acumatica ERP
	/// <para>Key Fields: ECOID</para>
	/// </summary>
	public class EngineeringChangeOrder : Entity, ITopLevelEntity
	{

		public List<EngineeringChangeOrderAttribute>? Attributes { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMECOItem</para>
		/// <para>Display Name: BOM ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		public StringValue? BOMID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BOMRevisionID</para>
		/// <para>DAC: PX.Objects.AM.AMECOItem</para>
		/// <para>Display Name: BOM Revision</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? BOMRevision { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.AMECOItem</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMECOItem</para>
		/// <para>Display Name: ECO ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? ECOID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMECOItem</para>
		/// <para>Display Name: Effective Date</para>
		/// </summary>
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMECOItem</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		public List<EngineeringChangeOrderOperation>? Operations { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMECOItem</para>
		/// </summary>
		public IntValue? Priority { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMECOItem</para>
		/// <para>Display Name: Request Date</para>
		/// </summary>
		public DateTimeValue? RequestDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMECOItem</para>
		/// </summary>
		public StringValue? Requestor { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RevisionID</para>
		/// <para>DAC: PX.Objects.AM.AMECOItem</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		public StringValue? Revision { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMECOItem</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Status { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.AM.AMECOItem</para>
		/// </summary>
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.AMECOItem</para>
		/// </summary>
		public StringValue? Warehouse { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string Attributes = "Attributes";
			public const string Operations = "Operations";
			public const string Operations_Files = "Operations/Files";
			public const string Operations_Material = "Operations/Material";
			public const string Operations_Material_Files = "Operations/Material/Files";
			public const string Operations_Material_ReferenceDesignators = "Operations/Material/ReferenceDesignators";
			public const string Operations_Material_ReferenceDesignators_Files = "Operations/Material/ReferenceDesignators/Files";
			public const string Operations_Overheads = "Operations/Overheads";
			public const string Operations_Overheads_Files = "Operations/Overheads/Files";
			public const string Operations_Steps = "Operations/Steps";
			public const string Operations_Steps_Files = "Operations/Steps/Files";
			public const string Operations_Tools = "Operations/Tools";
			public const string Operations_Tools_Files = "Operations/Tools/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,Attributes,Operations,Operations/Files,Operations/Material,Operations/Material/Files,Operations/Material/ReferenceDesignators,Operations/Material/ReferenceDesignators/Files,Operations/Overheads,Operations/Overheads/Files,Operations/Steps,Operations/Steps/Files,Operations/Tools,Operations/Tools/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}