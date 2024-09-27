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
	public class StateDetail : Entity
	{

		/// <summary>
		/// Indicates whether the record is selected or not.
		/// DAC: PX.Objects.CS.Country 
		/// </summary>
		[DataMember(Name="Selected", EmitDefaultValue=false)]
		public BooleanValue? Selected { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CS.State 
		/// Display Name: State ID 
		/// SQL Type: nvarchar(50) 
		/// Key Field
		/// </summary>
		[DataMember(Name="StateID", EmitDefaultValue=false)]
		public StringValue? StateID { get; set; }

		/// <summary>
		/// The name of Sales territory. 
		/// DAC Field Name: Name 
		/// DAC: PX.Objects.CS.SalesTerritory 
		/// Display Name: Territory Name 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		[DataMember(Name="StateName", EmitDefaultValue=false)]
		public StringValue? StateName { get; set; }

		/// <summary>
		/// The CountryID identifier for Sales Territories of type byState 
		/// DAC Field Name: CountryID 
		/// DAC: PX.Objects.CS.SalesTerritory 
		/// SQL Type: nvarchar(2) 
		/// </summary>
		[DataMember(Name="Country", EmitDefaultValue=false)]
		public StringValue? Country { get; set; }

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