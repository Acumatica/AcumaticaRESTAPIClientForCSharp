using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>IN204060</c> in the Acumatica ERP
	/// <para>Key Fields: CategoryID</para>
	/// </summary>
	public class BCItemSalesCategory : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INCategory</para>
		/// <para>Display Name: Category ID</para>
		/// Key Field
		/// </summary>
		public IntValue? CategoryID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.IN.INCategory</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public GuidValue? NoteID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: ParentID</para>
		/// <para>DAC: PX.Objects.IN.INCategory</para>
		/// <para>Display Name: Parent Category</para>
		/// </summary>
		public IntValue? ParentCategoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: //Description</para>
		/// <para>DAC: PX.Objects.IN.INCategory</para>
		/// <para>Display Name: Description</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// </summary>
		public StringValue? Path { get; set; }

		public IntValue? SortOrder { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";

			//Intentionally excluded
			//public const string All = "Files,Translations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/eCommerce/23.200.001";
		}
	}
}