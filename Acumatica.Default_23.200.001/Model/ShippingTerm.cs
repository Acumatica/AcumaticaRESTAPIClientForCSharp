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
	/// Corresponds to the screen CS208000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class ShippingTerm : Entity, ITopLevelEntity
	{

		/// <summary>
		/// DAC: PX.Objects.CS.ShipTerms 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<ShippingTermDetail>? Details { get; set; }

		/// <summary>
		/// DAC Field Name: ShipTermsID 
		/// DAC: PX.Objects.CS.ShipTerms 
		/// Display Name: Term ID 
		/// SQL Type: nvarchar(10) 
		/// Key Field
		/// </summary>
		[DataMember(Name="TermID", EmitDefaultValue=false)]
		public StringValue? TermID { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/23.200.001";
		}
	}
}