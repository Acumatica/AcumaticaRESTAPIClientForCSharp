using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen CM202000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Currency : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsActive 
		/// DAC: PX.Objects.CM.CurrencyList 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.CM.CurrencyList 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CurySymbol 
		/// DAC: PX.Objects.CM.CurrencyList 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CurrencySymbol", EmitDefaultValue=false)]
		public StringValue? CurrencySymbol { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DecimalPlaces 
		/// DAC: PX.Objects.CM.CurrencyList 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DecimalPrecision", EmitDefaultValue=false)]
		public ShortValue? DecimalPrecision { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Description 
		/// DAC: PX.Objects.CM.CurrencyList 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsFinancial 
		/// DAC: PX.Objects.CM.CurrencyList 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UseForAccounting", EmitDefaultValue=false)]
		public BooleanValue? UseForAccounting { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}