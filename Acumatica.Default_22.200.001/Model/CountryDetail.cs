using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class CountryDetail : Entity
	{

		/// <summary>
		/// Indicates whether the record is selected or not.
		/// DAC: PX.Objects.CS.Country 
		/// </summary>
		[DataMember(Name="Selected", EmitDefaultValue=false)]
		public BooleanValue? Selected { get; set; }

		/// <summary>
		/// The CountryID identifier for Sales Territories of type byState 
		/// DAC: PX.Objects.CS.SalesTerritory 
		/// Display Name: Country 
		/// SQL Type: nvarchar(2) 
		/// </summary>
		[DataMember(Name="CountryID", EmitDefaultValue=false)]
		public StringValue? CountryID { get; set; }

		/// <summary>
		/// The complete name of the Country.
		/// DAC Field Name: Description 
		/// DAC: PX.Objects.CS.Country 
		/// Display Name: Country Name 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="CountryName", EmitDefaultValue=false)]
		public StringValue? CountryName { get; set; }

		/// <summary>
		/// The primary key. 
		/// DAC: PX.Objects.CS.SalesTerritory 
		/// Display Name: Sales Territory 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="SalesTerritoryID", EmitDefaultValue=false)]
		public StringValue? SalesTerritoryID { get; set; }

	}
}