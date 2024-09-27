using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AR202010 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class SalesPriceWorksheet : Entity, ITopLevelEntity
	{

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AR.ARPriceWorksheet 
		/// SQL Type: nvarchar(150) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.ARPriceWorksheet 
		/// Display Name: Effective Date 
		/// </summary>
		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.ARPriceWorksheet 
		/// Display Name: Expiration Date 
		/// </summary>
		[DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
		public DateTimeValue? ExpirationDate { get; set; }

		[DataMember(Name="Hold", EmitDefaultValue=false)]
		public BooleanValue? Hold { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// DAC Field Name: OverwriteOverlapping 
		/// DAC: PX.Objects.AR.ARPriceWorksheet 
		/// Display Name: Overwrite Overlapping Prices 
		/// </summary>
		[DataMember(Name="OverwriteOverlappingPrices", EmitDefaultValue=false)]
		public BooleanValue? OverwriteOverlappingPrices { get; set; }

		/// <summary>
		/// DAC Field Name: RefNbr 
		/// DAC: PX.Objects.AR.ARPriceWorksheet 
		/// Display Name: Reference Nbr. 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ReferenceNbr", EmitDefaultValue=false)]
		public StringValue? ReferenceNbr { get; set; }

		[DataMember(Name="SalesPrices", EmitDefaultValue=false)]
		public List<SalesPricesWorksheetDetail>? SalesPrices { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AR.ARPriceWorksheet 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}