using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_24_200_001.Model
{
	[DataContract]
	public class BCItemSalesCategory : Entity, ITopLevelEntity
	{

		[DataMember(Name="CategoryID", EmitDefaultValue=false)]
		public IntValue? CategoryID { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="NoteID", EmitDefaultValue=false)]
		public GuidValue? NoteID { get; set; }

		[DataMember(Name="ParentCategoryID", EmitDefaultValue=false)]
		public IntValue? ParentCategoryID { get; set; }

		[DataMember(Name="Path", EmitDefaultValue=false)]
		public StringValue? Path { get; set; }

		[DataMember(Name="SortOrder", EmitDefaultValue=false)]
		public IntValue? SortOrder { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/eCommerce/24.200.001";
		}
	}
}