using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_20_200_001.Model
{
	[DataContract]
	public class TaxCategory : Entity, ITopLevelEntity
	{

		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="CreatedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? CreatedDateTime { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<TaxCategoryTaxDetail>? Details { get; set; }

		[DataMember(Name="ExcludeListedTaxes", EmitDefaultValue=false)]
		public BooleanValue? ExcludeListedTaxes { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="TaxCategoryID", EmitDefaultValue=false)]
		public StringValue? TaxCategoryID { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/eCommerce/20.200.001";
		}
	}
}