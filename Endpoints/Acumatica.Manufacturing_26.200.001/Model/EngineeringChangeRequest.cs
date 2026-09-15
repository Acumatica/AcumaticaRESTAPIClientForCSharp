using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AM210000</c> in the Acumatica ERP
	/// <para>Key Fields: ECRID</para>
	/// </summary>
	[DataContract]
	public class EngineeringChangeRequest : Entity, ITopLevelEntity
	{

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<EngineeringChangeRequestAttribute>? Attributes { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMECRItem</para>
		/// <para>Display Name: BOM ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="BOMID", EmitDefaultValue=false)]
		public StringValue? BOMID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: BOMRevisionID</para>
		/// <para>DAC: PX.Objects.AM.AMECRItem</para>
		/// <para>Display Name: BOM Revision</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="BOMRevision", EmitDefaultValue=false)]
		public StringValue? BOMRevision { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AM.AMECRItem</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMECRItem</para>
		/// <para>Display Name: ECO ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// </summary>
		[DataMember(Name="ECOID", EmitDefaultValue=false)]
		public StringValue? ECOID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMECRItem</para>
		/// <para>Display Name: ECR ID</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ECRID", EmitDefaultValue=false)]
		public StringValue? ECRID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMECRItem</para>
		/// <para>Display Name: Effective Date</para>
		/// </summary>
		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMECRItem</para>
		/// <para>Display Name: Inventory ID</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="Operations", EmitDefaultValue=false)]
		public List<EngineeringChangeRequestOperation>? Operations { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMECRItem</para>
		/// </summary>
		[DataMember(Name="Priority", EmitDefaultValue=false)]
		public IntValue? Priority { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMECRItem</para>
		/// <para>Display Name: Request Date</para>
		/// </summary>
		[DataMember(Name="RequestDate", EmitDefaultValue=false)]
		public DateTimeValue? RequestDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMECRItem</para>
		/// </summary>
		[DataMember(Name="Requestor", EmitDefaultValue=false)]
		public StringValue? Requestor { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RevisionID</para>
		/// <para>DAC: PX.Objects.AM.AMECRItem</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// </summary>
		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue? Revision { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AM.AMECRItem</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SubItemID</para>
		/// <para>DAC: PX.Objects.AM.AMECRItem</para>
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.AM.AMECRItem</para>
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

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
			public const string Translations = "Translations";
			public const string Attributes = "Attributes";
			public const string Operations = "Operations";

			//Intentionally excluded
			//public const string All = "Files,Translations,Attributes,Operations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/26.200.001";
		}
	}
}