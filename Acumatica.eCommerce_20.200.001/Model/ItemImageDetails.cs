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
	public class ItemImageDetails : Entity
	{

		[DataMember(Name="Extension", EmitDefaultValue=false)]
		public StringValue? Extension { get; set; }

		[DataMember(Name="FileID", EmitDefaultValue=false)]
		public GuidValue? FileID { get; set; }

		[DataMember(Name="FileName", EmitDefaultValue=false)]
		public StringValue? FileName { get; set; }

		[DataMember(Name="FileNoteID", EmitDefaultValue=false)]
		public GuidValue? FileNoteID { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="InventoryLastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? InventoryLastModifiedDateTime { get; set; }

		[DataMember(Name="InventoryNoteID", EmitDefaultValue=false)]
		public GuidValue? InventoryNoteID { get; set; }

		[DataMember(Name="IsDefault", EmitDefaultValue=false)]
		public BooleanValue? IsDefault { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		[DataMember(Name="TemplateItemID", EmitDefaultValue=false)]
		public StringValue? TemplateItemID { get; set; }

	}
}