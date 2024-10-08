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
	public class SrvOrdAddress : Entity
	{

		/// <summary>
		/// DAC: PX.Objects.FS.FSAddress 
		/// Display Name: Address Line 1 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		[DataMember(Name="AddressLine1", EmitDefaultValue=false)]
		public StringValue? AddressLine1 { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAddress 
		/// Display Name: Address Line 2 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		[DataMember(Name="AddressLine2", EmitDefaultValue=false)]
		public StringValue? AddressLine2 { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAddress 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		[DataMember(Name="City", EmitDefaultValue=false)]
		public StringValue? City { get; set; }

		/// <summary>
		/// DAC Field Name: CountryID 
		/// DAC: PX.Objects.FS.FSAddress 
		/// SQL Type: nvarchar(2) 
		/// </summary>
		[DataMember(Name="Country", EmitDefaultValue=false)]
		public StringValue? Country { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAddress 
		/// Display Name: Postal Code 
		/// SQL Type: varchar(20) 
		/// </summary>
		[DataMember(Name="PostalCode", EmitDefaultValue=false)]
		public StringValue? PostalCode { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAddress 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		[DataMember(Name="State", EmitDefaultValue=false)]
		public StringValue? State { get; set; }

	}
}