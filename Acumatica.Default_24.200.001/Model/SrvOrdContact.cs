using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class SrvOrdContact : Entity
	{

		/// <summary>
		/// DAC: PX.Objects.FS.FSContact 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="Attention", EmitDefaultValue=false)]
		public StringValue? Attention { get; set; }

		/// <summary>
		/// DAC Field Name: FullName 
		/// DAC: PX.Objects.FS.FSContact 
		/// Display Name: Account Name 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="CompanyName", EmitDefaultValue=false)]
		public StringValue? CompanyName { get; set; }

		/// <summary>
		/// DAC Field Name: EMail 
		/// DAC: PX.Objects.FS.FSContact 
		/// SQL Type: varchar(255) 
		/// </summary>
		[DataMember(Name="Email", EmitDefaultValue=false)]
		public StringValue? Email { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSContact 
		/// Display Name: Phone 1 
		/// SQL Type: varchar(50) 
		/// </summary>
		[DataMember(Name="Phone1", EmitDefaultValue=false)]
		public StringValue? Phone1 { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSContact 
		/// Display Name: Phone 1 Type 
		/// SQL Type: varchar(3) 
		/// </summary>
		[DataMember(Name="Phone1Type", EmitDefaultValue=false)]
		public StringValue? Phone1Type { get; set; }

	}
}