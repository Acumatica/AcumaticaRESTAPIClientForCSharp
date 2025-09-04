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
	public class CustomerSalesPerson : Entity
	{

		/// <summary>
		/// The default sales commission percentage received by the salesperson for the specified customer and location.
		/// DAC Field Name: CommisionPct 
		/// DAC: PX.Objects.AR.CustSalesPeople 
		/// Display Name: Commission % 
		/// </summary>
		[DataMember(Name="Commission", EmitDefaultValue=false)]
		public DecimalValue? Commission { get; set; }

		/// <summary>
		/// This field indicates whether the location is default for the corresponding business account.
		/// DAC Field Name: IsDefault 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		[DataMember(Name="Default", EmitDefaultValue=false)]
		public BooleanValue? Default { get; set; }

		/// <summary>
		/// The integer identifier of the customer location. This field is a part of the compound key of the record.
		/// DAC: PX.Objects.AR.CustSalesPeople 
		/// Display Name: Location 
		/// Key Field
		/// </summary>
		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue? LocationID { get; set; }

		/// <summary>
		/// DAC Field Name: LocationID_description 
		/// DAC: PX.Objects.AR.CustSalesPeople 
		/// </summary>
		[DataMember(Name="LocationName", EmitDefaultValue=false)]
		public StringValue? LocationName { get; set; }

		/// <summary>
		/// DAC Field Name: SalesPersonID_SalesPerson_descr 
		/// DAC: PX.Objects.AR.CustSalesPeople 
		/// </summary>
		[DataMember(Name="Name", EmitDefaultValue=false)]
		public StringValue? Name { get; set; }

		/// <summary>
		/// The integer identifier of the salesperson. This field is a part of the compound key of the record.
		/// DAC Field Name: SalesPersonID 
		/// DAC: PX.Objects.AR.CustSalesPeople 
		/// Key Field
		/// </summary>
		[DataMember(Name="SalespersonID", EmitDefaultValue=false)]
		public StringValue? SalespersonID { get; set; }

	}
}