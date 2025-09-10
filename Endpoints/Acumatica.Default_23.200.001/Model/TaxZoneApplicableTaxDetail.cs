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
	public class TaxZoneApplicableTaxDetail : Entity
	{

		/// <summary>
		/// The field contains ID of a tax that would be used to create tax transactions in documents.
		/// DAC: PX.Objects.TX.TaxZone 
		/// Display Name: Tax ID 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="TaxID", EmitDefaultValue=false)]
		public StringValue? TaxID { get; set; }

	}
}