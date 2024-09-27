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
	public class DiscountCustomerPriceClassesDetail : Entity
	{

		/// <summary>
		/// DAC Field Name: CustomerPriceClassID 
		/// DAC: PX.Objects.AR.DiscountCustomerPriceClass 
		/// Display Name: Price Class ID 
		/// SQL Type: nvarchar(10) 
		/// Key Field
		/// </summary>
		[DataMember(Name="PriceClassID", EmitDefaultValue=false)]
		public StringValue? PriceClassID { get; set; }

	}
}