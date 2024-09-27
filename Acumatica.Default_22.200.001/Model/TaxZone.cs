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
	/// Corresponds to the screen TX206000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class TaxZone : Entity, ITopLevelEntity
	{

		[DataMember(Name="ApplicableTaxes", EmitDefaultValue=false)]
		public List<TaxZoneApplicableTaxDetail>? ApplicableTaxes { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		/// <summary>
		/// The description of the tax zone, which can be specified by the user.
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.TX.TaxZone 
		/// SQL Type: nvarchar(60) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// A key field, which can be specified by the user.
		/// DAC: PX.Objects.TX.TaxZone 
		/// Display Name: Tax Zone ID 
		/// SQL Type: nvarchar(10) 
		/// Key Field
		/// </summary>
		[DataMember(Name="TaxZoneID", EmitDefaultValue=false)]
		public StringValue? TaxZoneID { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/22.200.001";
		}
	}
}