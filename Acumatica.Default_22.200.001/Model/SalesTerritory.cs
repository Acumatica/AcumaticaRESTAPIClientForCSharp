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
		/// 
		/// Display Name:
		/// DAC Field Name: SalesTerritoryID 
		/// DAC: PX.Objects.CS.SalesTerritory 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SalesTerritoryID", EmitDefaultValue=false)]
		public StringValue? SalesTerritoryID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Name 
		/// DAC: PX.Objects.CS.SalesTerritory 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="SalesTerritoryName", EmitDefaultValue=false)]
		public StringValue? SalesTerritoryName { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsActive 
		/// DAC: PX.Objects.CS.SalesTerritory 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: SalesTerritoryType 
		/// DAC: PX.Objects.CS.SalesTerritory 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TerritoryType", EmitDefaultValue=false)]
		public StringValue? TerritoryType { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CountryID 
		/// DAC: PX.Objects.CS.SalesTerritory 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
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