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
	public class BusinessAccountLocation : Entity
	{

		/// <summary>
		/// This field indicates whether the location is active.
		/// DAC Field Name: IsActive 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// DAC Field Name: Address__City 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		[DataMember(Name="City", EmitDefaultValue=false)]
		public StringValue? City { get; set; }

		/// <summary>
		/// DAC Field Name: Address__CountryID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		[DataMember(Name="Country", EmitDefaultValue=false)]
		public StringValue? Country { get; set; }

		/// <summary>
		/// This field indicates whether the location is default for the corresponding business account.
		/// DAC Field Name: IsDefault 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		[DataMember(Name="Default", EmitDefaultValue=false)]
		public BooleanValue? Default { get; set; }

		/// <summary>
		/// The human-readable identifier of the location that is specified by the user when they create a location.This field is a natural key as opposed to the LocationID surrogate key.
		/// DAC Field Name: LocationCD 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// SQL Type: nvarchar(30) 
		/// Key Field
		/// </summary>
		[DataMember(Name="LocationID", EmitDefaultValue=false)]
		public StringValue? LocationID { get; set; }

		/// <summary>
		/// The name of the location.
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Location Name 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="LocationName", EmitDefaultValue=false)]
		public StringValue? LocationName { get; set; }

		/// <summary>
		/// The price class of the customer.
		/// DAC Field Name: CPriceClassID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Price Class 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="PriceClass", EmitDefaultValue=false)]
		public StringValue? PriceClass { get; set; }

		[DataMember(Name="SalesAccount", EmitDefaultValue=false)]
		public StringValue? SalesAccount { get; set; }

		[DataMember(Name="SalesSubaccount", EmitDefaultValue=false)]
		public StringValue? SalesSubaccount { get; set; }

		/// <summary>
		/// DAC Field Name: Address__State 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// </summary>
		[DataMember(Name="State", EmitDefaultValue=false)]
		public StringValue? State { get; set; }

		/// <summary>
		/// The customer's tax zone.
		/// DAC Field Name: CTaxZoneID 
		/// DAC: PX.Objects.CR.Standalone.Location 
		/// Display Name: Tax Zone 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="TaxZone", EmitDefaultValue=false)]
		public StringValue? TaxZone { get; set; }

	}
}