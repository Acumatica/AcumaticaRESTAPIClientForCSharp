using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AR209000</c> in the Acumatica ERP
	/// <para>Key Fields: DiscountCodeID</para>
	/// </summary>
	public class DiscountCode : Entity, ITopLevelEntity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARDiscount</para>
		/// <para>Display Name: Applicable To</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? ApplicableTo { get; set; }

		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARDiscount</para>
		/// <para>SQL Type: nvarchar(250)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: DiscountID</para>
		/// <para>DAC: PX.Objects.AR.ARDiscount</para>
		/// <para>Display Name: Discount Code</para>
		/// <para>SQL Type: nvarchar(10)</para>
		/// Key Field
		/// </summary>
		public StringValue? DiscountCodeID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Type</para>
		/// <para>DAC: PX.Objects.AR.ARDiscount</para>
		/// <para>Display Name: Discount Type</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? DiscountType { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";

			//Intentionally excluded
			//public const string All = "Files,Translations";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}