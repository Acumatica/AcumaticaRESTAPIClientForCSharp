using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_26_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>IN204060</c> in the Acumatica ERP
	/// <para>Key Fields: CategoryID</para>
	/// </summary>
	public class BCItemSalesCategory : Entity, ITopLevelEntity
	{

		#region Fields
		/// <summary>
		/// <para>DAC: PX.Objects.IN.INCategory</para>
		/// <para>Display Name: Category ID</para>
		/// Key Field
		/// </summary>
		public IntValue? CategoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: //Description</para>
		/// <para>DAC: PX.Objects.IN.INCategory</para>
		/// <para>Display Name: Description</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Path { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INCategory</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ParentID</para>
		/// <para>DAC: PX.Objects.IN.INCategory</para>
		/// <para>Display Name: Parent Category</para>
		/// </summary>
		public IntValue? ParentCategoryID { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public GuidValue? NoteID { get; set; }

		public IntValue? SortOrder { get; set; }

		#endregion

		protected override string GetDebuggerDisplay()
		{
			return $"{nameof(BCItemSalesCategory)} - \"{CategoryID}\"";
		}

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

			//Intentionally excluded
			//public const string All = "Files,Translations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/eCommerce/26.200.001";
		}
	}
}