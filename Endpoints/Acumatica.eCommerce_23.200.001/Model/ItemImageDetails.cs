using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_23_200_001.Model
{
	[DataContract]
	public class ItemImageDetails : Entity
	{

		/// <summary>
		/// DAC Field Name: UploadFile_extansion 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="Extension", EmitDefaultValue=false)]
		public StringValue? Extension { get; set; }

		/// <summary>
		/// DAC Field Name: UploadFile_fileID 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="FileID", EmitDefaultValue=false)]
		public GuidValue? FileID { get; set; }

		/// <summary>
		/// DAC Field Name: UploadFile_name 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="FileName", EmitDefaultValue=false)]
		public StringValue? FileName { get; set; }

		/// <summary>
		/// DAC Field Name: UploadFile_noteID 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="FileNoteID", EmitDefaultValue=false)]
		public GuidValue? FileNoteID { get; set; }

		/// <summary>
		/// DAC Field Name: InventoryItem_inventoryCD 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC Field Name: InventoryItem_lastModifiedDateTime 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="InventoryLastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? InventoryLastModifiedDateTime { get; set; }

		/// <summary>
		/// DAC Field Name: InventoryItem_noteID 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="InventoryNoteID", EmitDefaultValue=false)]
		public GuidValue? InventoryNoteID { get; set; }

		/// <summary>
		/// DAC Field Name: InventoryItem_Formula0c812287c27b492e980dba53a73007c1 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="IsDefault", EmitDefaultValue=false)]
		public BooleanValue? IsDefault { get; set; }

		/// <summary>
		/// DAC Field Name: UploadFileRevision_createdDateTime 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// DAC Field Name: InventoryItem_templateItemID 
		/// DAC: PX.Data.GenericResult 
		/// </summary>
		[DataMember(Name="TemplateItemID", EmitDefaultValue=false)]
		public StringValue? TemplateItemID { get; set; }

	}
}