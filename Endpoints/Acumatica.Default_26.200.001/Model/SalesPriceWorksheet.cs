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
	/// Corresponds to the screen <c>AR202010</c> in the Acumatica ERP
	/// <para>Key Fields: ReferenceNbr</para>
	/// </summary>
	[DataContract]
	public class SalesPriceWorksheet : Entity, ITopLevelEntity
	{

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: Descr</para>
		/// <para>DAC: PX.Objects.AR.ARPriceWorksheet</para>
		/// <para>SQL Type: nvarchar(150)</para>
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARPriceWorksheet</para>
		/// <para>Display Name: Effective Date</para>
		/// </summary>
		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateOnlyValue? EffectiveDate { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARPriceWorksheet</para>
		/// <para>Display Name: Expiration Date</para>
		/// </summary>
		[DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
		public DateOnlyValue? ExpirationDate { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: OverwriteOverlapping</para>
		/// <para>DAC: PX.Objects.AR.ARPriceWorksheet</para>
		/// <para>Display Name: Overwrite Overlapping Prices</para>
		/// </summary>
		[DataMember(Name="OverwriteOverlappingPrices", EmitDefaultValue=false)]
		public BooleanValue? OverwriteOverlappingPrices { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RefNbr</para>
		/// <para>DAC: PX.Objects.AR.ARPriceWorksheet</para>
		/// <para>Display Name: Reference Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		[DataMember(Name="SalesPrices", EmitDefaultValue=false)]
		public List<SalesPricesWorksheetDetail>? SalesPrices { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.AR.ARPriceWorksheet</para>
		/// <para>SQL Type: char(1)</para>
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringSingleSelectValue? Status { get; set; }

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
			public const string SalesPrices = "SalesPrices";

			//Intentionally excluded
			//public const string All = "Files,Translations,SalesPrices";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/Default/26.200.001";
		}
	}
}