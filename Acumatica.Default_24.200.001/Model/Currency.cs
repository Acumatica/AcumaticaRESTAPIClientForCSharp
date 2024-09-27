using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen CM202000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Currency : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC Field Name: IsActive 
		/// DAC: PX.Objects.CM.CurrencyList 
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// DAC Field Name: CuryID 
		/// DAC: PX.Objects.CM.CurrencyList 
		/// Display Name: Currency ID 
		/// SQL Type: nvarchar(5) 
		/// Key Field
		/// </summary>
		[DataMember(Name="CurrencyID", EmitDefaultValue=false)]
		public StringValue? CurrencyID { get; set; }

		/// <summary>
		/// DAC Field Name: CurySymbol 
		/// DAC: PX.Objects.CM.CurrencyList 
		/// Display Name: Currency Symbol 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="CurrencySymbol", EmitDefaultValue=false)]
		public StringValue? CurrencySymbol { get; set; }

		/// <summary>
		/// DAC Field Name: DecimalPlaces 
		/// DAC: PX.Objects.CM.CurrencyList 
		/// Display Name: Decimal Precision 
		/// </summary>
		[DataMember(Name="DecimalPrecision", EmitDefaultValue=false)]
		public ShortValue? DecimalPrecision { get; set; }

		/// <summary>
		/// DAC: PX.Objects.CM.CurrencyList 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// DAC Field Name: IsFinancial 
		/// DAC: PX.Objects.CM.CurrencyList 
		/// Display Name: Use for Accounting 
		/// </summary>
		[DataMember(Name="UseForAccounting", EmitDefaultValue=false)]
		public BooleanValue? UseForAccounting { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}