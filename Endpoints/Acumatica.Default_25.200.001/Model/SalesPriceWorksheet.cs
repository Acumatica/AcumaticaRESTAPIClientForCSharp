using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen <c>AR202010</c> in the Acumatica ERP
	/// <para>Key Fields: ReferenceNbr</para>
	/// </summary>
	public class SalesPriceWorksheet : Entity, ITopLevelEntity
	{

		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AR.ARPriceWorksheet</para>
		/// <para>SQL Type: nvarchar(150)</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARPriceWorksheet</para>
		/// <para>Display Name: Effective Date</para>
		/// </summary>
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARPriceWorksheet</para>
		/// <para>Display Name: Expiration Date</para>
		/// </summary>
		public DateTimeValue? ExpirationDate { get; set; }

		public BooleanValue? Hold { get; set; }

		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OverwriteOverlapping</para>
		/// <para>DAC: PX.Objects.AR.ARPriceWorksheet</para>
		/// <para>Display Name: Overwrite Overlapping Prices</para>
		/// </summary>
		public BooleanValue? OverwriteOverlappingPrices { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RefNbr</para>
		/// <para>DAC: PX.Objects.AR.ARPriceWorksheet</para>
		/// <para>Display Name: Reference Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? ReferenceNbr { get; set; }

		public List<SalesPricesWorksheetDetail>? SalesPrices { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARPriceWorksheet</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		public StringValue? Status { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Translations = "Translations";
			public const string SalesPrices = "SalesPrices";
			public const string SalesPrices_Files = "SalesPrices/Files";

			//Intentionally excluded
			//public const string All = "Files,Translations,SalesPrices,SalesPrices/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/25.200.001";
		}
	}
}