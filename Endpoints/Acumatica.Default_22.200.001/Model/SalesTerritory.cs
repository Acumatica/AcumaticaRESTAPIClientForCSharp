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
	/// Corresponds to the screen CS204100 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class SalesTerritory : Entity, ITopLevelEntity
	{

		/// <summary>
		/// The primary key. 
		/// DAC: PX.Objects.CS.SalesTerritory 
		/// Display Name: Sales Territory 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="SalesTerritoryID", EmitDefaultValue=false)]
		public StringValue? SalesTerritoryID { get; set; }

		/// <summary>
		/// The name of Sales territory. 
		/// DAC Field Name: Name 
		/// DAC: PX.Objects.CS.SalesTerritory 
		/// Display Name: Territory Name 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		[DataMember(Name="SalesTerritoryName", EmitDefaultValue=false)]
		public StringValue? SalesTerritoryName { get; set; }

		/// <summary>
		/// Indicates (if set to true) that the sales territory is active.
		/// DAC Field Name: IsActive 
		/// DAC: PX.Objects.CS.SalesTerritory 
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// Type of sales territory SalesTerritoryTypeAttribute.
		/// DAC Field Name: SalesTerritoryType 
		/// DAC: PX.Objects.CS.SalesTerritory 
		/// Display Name: Territory Type 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="TerritoryType", EmitDefaultValue=false)]
		public StringValue? TerritoryType { get; set; }

		/// <summary>
		/// The CountryID identifier for Sales Territories of type byState 
		/// DAC Field Name: CountryID 
		/// DAC: PX.Objects.CS.SalesTerritory 
		/// SQL Type: nvarchar(2) 
		/// </summary>
		[DataMember(Name="Country", EmitDefaultValue=false)]
		public StringValue? Country { get; set; }

		[DataMember(Name="Countries", EmitDefaultValue=false)]
		public List<CountryDetail>? Countries { get; set; }

		[DataMember(Name="CountryStates", EmitDefaultValue=false)]
		public List<StateDetail>? CountryStates { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}