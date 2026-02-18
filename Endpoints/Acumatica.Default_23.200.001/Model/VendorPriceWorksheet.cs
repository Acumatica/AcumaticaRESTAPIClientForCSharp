using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AP202010</c> in the Acumatica ERP
	/// <para>Key Fields: ReferenceNbr</para>
	/// </summary>
	public class VendorPriceWorksheet : Entity, ITopLevelEntity
	{

		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AP.APPriceWorksheet</para>
		/// <para>SQL Type: nvarchar(150)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AP.APPriceWorksheet</para>
		/// <para>Display Name: Effective Date</para>
		/// </summary>
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AP.APPriceWorksheet</para>
		/// <para>Display Name: Expiration Date</para>
		/// </summary>
		public DateTimeValue? ExpirationDate { get; set; }

		public BooleanValue? Hold { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OverwriteOverlapping</para>
		/// <para>DAC: PX.Objects.AP.APPriceWorksheet</para>
		/// <para>Display Name: Overwrite Overlapping Prices</para>
		/// </summary>
		public BooleanValue? OverwriteOverlappingPrices { get; set; }

		/// <summary>
		/// <para>DAC Field Name: IsPromotional</para>
		/// <para>DAC: PX.Objects.AP.APPriceWorksheet</para>
		/// </summary>
		public BooleanValue? Promotional { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RefNbr</para>
		/// <para>DAC: PX.Objects.AP.APPriceWorksheet</para>
		/// <para>Display Name: Reference Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AP.APPriceWorksheet</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Status { get; set; }

		public List<VendorPriceWorksheetDetail>? VendorSalesPrices { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string VendorSalesPrices = "VendorSalesPrices";
			public const string VendorSalesPrices_Files = "VendorSalesPrices/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,VendorSalesPrices,VendorSalesPrices/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}