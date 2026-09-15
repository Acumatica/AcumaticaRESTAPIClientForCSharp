using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>IN305000</c> in the Acumatica ERP
	/// <para>Key Fields: ReferenceNbr</para>
	/// </summary>
	[DataContract]
	public class PhysicalInventoryReview : Entity, ITopLevelEntity
	{

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.IN.INPIHeader</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<PhysicalInventoryReviewDetail>? Details { get; set; }

		/// <summary>
		/// <para>DAC Field Name: CountDate</para>
		/// <para>DAC: PX.Objects.IN.INPIHeader</para>
		/// <para>Display Name: Freeze Date</para>
		/// </summary>
		[DataMember(Name="FreezeDate", EmitDefaultValue=false)]
		public DateTimeValue? FreezeDate { get; set; }

		/// <summary>
		/// <para>DAC Field Name: PIID</para>
		/// <para>DAC: PX.Objects.IN.INPIHeader</para>
		/// <para>Display Name: Reference Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INPIHeader</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringSingleSelectValue? Status { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INPIHeader</para>
		/// <para>Display Name: Total Physical Qty.</para>
		/// </summary>
		[DataMember(Name="TotalPhysicalQty", EmitDefaultValue=false)]
		public DecimalValue? TotalPhysicalQty { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TotalVarCost</para>
		/// <para>DAC: PX.Objects.IN.INPIHeader</para>
		/// <para>Display Name: Total Variance Cost</para>
		/// </summary>
		[DataMember(Name="TotalVarianceCost", EmitDefaultValue=false)]
		public DecimalValue? TotalVarianceCost { get; set; }

		/// <summary>
		/// <para>DAC Field Name: TotalVarQty</para>
		/// <para>DAC: PX.Objects.IN.INPIHeader</para>
		/// <para>Display Name: Total Variance Qty.</para>
		/// </summary>
		[DataMember(Name="TotalVarianceQty", EmitDefaultValue=false)]
		public DecimalValue? TotalVarianceQty { get; set; }

		[DataMember(Name="TypeID", EmitDefaultValue=false)]
		public StringValue? TypeID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SiteID</para>
		/// <para>DAC: PX.Objects.IN.INPIHeader</para>
		/// <para>Display Name: Warehouse</para>
		/// </summary>
		[DataMember(Name="WarehouseID", EmitDefaultValue=false)]
		public StringValue? WarehouseID { get; set; }

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
			public const string Details = "Details";

			//Intentionally excluded
			//public const string All = "Files,Translations,Details";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}