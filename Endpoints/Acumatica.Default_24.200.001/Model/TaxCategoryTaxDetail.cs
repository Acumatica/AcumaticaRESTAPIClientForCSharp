using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class TaxCategoryTaxDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: Tax__TaxCalcRule 
		/// DAC: PX.Objects.TX.TaxCategoryDet 
		/// </summary>
		[DataMember(Name="CalculateOn", EmitDefaultValue=false)]
		public StringValue? CalculateOn { get; set; }

		/// <summary>
		/// DAC Field Name: Tax__TaxApplyTermsDisc 
		/// DAC: PX.Objects.TX.TaxCategoryDet 
		/// </summary>
		[DataMember(Name="CashDiscount", EmitDefaultValue=false)]
		public StringValue? CashDiscount { get; set; }

		/// <summary>
		/// DAC Field Name: Tax__Descr 
		/// DAC: PX.Objects.TX.TaxCategoryDet 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The tax category ID. This is the key field, which can be specified by the user.
		/// DAC Field Name: TaxCategoryID 
		/// DAC: PX.Objects.TX.TaxCategory 
		/// Display Name: Tax Category ID 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="TaxCategory", EmitDefaultValue=false)]
		public StringValue? TaxCategory { get; set; }

		/// <summary>
		/// The foreign key to Tax.
		/// DAC: PX.Objects.TX.TaxCategoryDet 
		/// Display Name: Tax ID 
		/// SQL Type: nvarchar(60) 
		/// Key Field
		/// </summary>
		[DataMember(Name="TaxID", EmitDefaultValue=false)]
		public StringValue? TaxID { get; set; }

		/// <summary>
		/// DAC Field Name: Tax__TaxType 
		/// DAC: PX.Objects.TX.TaxCategoryDet 
		/// </summary>
		[DataMember(Name="TaxType", EmitDefaultValue=false)]
		public StringValue? TaxType { get; set; }

	}
}