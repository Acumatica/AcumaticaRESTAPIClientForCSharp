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
	public class ItemImageDetails : Entity
	{

		/// <summary>
		/// <para>DAC Field Name: UploadFile_extansion</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="Extension", EmitDefaultValue=false)]
		public StringValue? Extension { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UploadFile_fileID</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="FileID", EmitDefaultValue=false)]
		public GuidValue? FileID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UploadFile_name</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="FileName", EmitDefaultValue=false)]
		public StringValue? FileName { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UploadFile_noteID</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="FileNoteID", EmitDefaultValue=false)]
		public GuidValue? FileNoteID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InventoryItem_inventoryCD</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InventoryItem_lastModifiedDateTime</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="InventoryLastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? InventoryLastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InventoryItem_noteID</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="InventoryNoteID", EmitDefaultValue=false)]
		public GuidValue? InventoryNoteID { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InventoryItem_Formula0c812287c27b492e980dba53a73007c1</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="IsDefault", EmitDefaultValue=false)]
		public BooleanValue? IsDefault { get; set; }

		/// <summary>
		/// <para>DAC Field Name: UploadFileRevision_createdDateTime</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// <para>DAC Field Name: InventoryItem_templateItemID</para>
		/// <para>DAC: PX.Data.GenericResult</para>
		/// </summary>
		[DataMember(Name="TemplateItemID", EmitDefaultValue=false)]
		public StringValue? TemplateItemID { get; set; }

	}
}