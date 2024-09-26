using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AP202010 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class VendorPriceWorksheet : Entity, ITopLevelEntity
	{

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AP.APPriceWorksheet 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: EffectiveDate 
		/// DAC: PX.Objects.AP.APPriceWorksheet 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ExpirationDate 
		/// DAC: PX.Objects.AP.APPriceWorksheet 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
		public DateTimeValue? ExpirationDate { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OverwriteOverlapping 
		/// DAC: PX.Objects.AP.APPriceWorksheet 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OverwriteOverlappingPrices", EmitDefaultValue=false)]
		public BooleanValue? OverwriteOverlappingPrices { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsPromotional 
		/// DAC: PX.Objects.AP.APPriceWorksheet 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Promotional", EmitDefaultValue=false)]
		public BooleanValue? Promotional { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RefNbr 
		/// DAC: PX.Objects.AP.APPriceWorksheet 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Status 
		/// DAC: PX.Objects.AP.APPriceWorksheet 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		[DataMember(Name="VendorSalesPrices", EmitDefaultValue=false)]
		public List<VendorPriceWorksheetDetail>? VendorSalesPrices { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}