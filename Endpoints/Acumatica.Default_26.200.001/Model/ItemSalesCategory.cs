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
	/// Corresponds to the screen <c>IN204060</c> in the Acumatica ERP
	/// <para>Key Fields: CategoryID</para>
	/// </summary>
	[DataContract]
	public class ItemSalesCategory : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INCategory</para>
		/// <para>Display Name: Category ID</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="CategoryID", EmitDefaultValue=false)]
		public IntValue? CategoryID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INCategory</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="Members", EmitDefaultValue=false)]
		public List<ItemSalesCategoryMember>? Members { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ParentID</para>
		/// <para>DAC: PX.Objects.IN.INCategory</para>
		/// <para>Display Name: Parent Category</para>
		/// </summary>
		[DataMember(Name="ParentCategoryID", EmitDefaultValue=false)]
		public IntValue? ParentCategoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: //Description</para>
		/// <para>DAC: PX.Objects.IN.INCategory</para>
		/// <para>Display Name: Description</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		[DataMember(Name="Path", EmitDefaultValue=false)]
		public StringValue? Path { get; set; }

		[DataMember(Name="SortOrder", EmitDefaultValue=false)]
		public IntValue? SortOrder { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

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
			public const string Members = "Members";

			//Intentionally excluded
			//public const string All = "Files,Translations,Members";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}