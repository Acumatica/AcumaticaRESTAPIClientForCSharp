using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class TaxZoneDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: TaxZone__DfltTaxCategoryID 
		/// DAC: PX.Objects.TX.TaxZoneDet 
		/// </summary>
		[DataMember(Name="DefaultTaxCategory", EmitDefaultValue=false)]
		public StringValue? DefaultTaxCategory { get; set; }

		/// <summary>
		/// DAC Field Name: TaxZone__Descr 
		/// DAC: PX.Objects.TX.TaxZoneDet 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// The tax ID. This is the key field, which can be specified by the user.
		/// DAC: PX.Objects.TX.Tax 
		/// Display Name: Tax ID 
		/// SQL Type: nvarchar(60) 
		/// Key Field
		/// </summary>
		[DataMember(Name="TaxID", EmitDefaultValue=false)]
		public StringValue? TaxID { get; set; }

		/// <summary>
		/// The foreign key to TaxZone.
		/// DAC: PX.Objects.TX.TaxZoneDet 
		/// Display Name: Tax Zone ID 
		/// SQL Type: nvarchar(10) 
		/// Key Field
		/// </summary>
		[DataMember(Name="TaxZoneID", EmitDefaultValue=false)]
		public StringValue? TaxZoneID { get; set; }

	}
}