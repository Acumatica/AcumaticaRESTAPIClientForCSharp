using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_25_200_001.Model
{
	[DataContract]
	public class Commissions : Entity
	{

		/// <summary>
		/// The identifier of the salesperson to be used by defaultfor each sales order line.The field is included in the SalesPerson foreign key.
		/// <para>DAC Field Name: SalesPersonID</para>
		/// <para>DAC: PX.Objects.SO.SOOrder</para>
		/// <para>Display Name: Default Salesperson</para>
		/// </summary>
		[DataMember(Name="DefaultSalesperson", EmitDefaultValue=false)]
		public StringValue? DefaultSalesperson { get; set; }

		[DataMember(Name="SalesPersons", EmitDefaultValue=false)]
		public List<SalesPersonDetail>? SalesPersons { get; set; }

	}
}