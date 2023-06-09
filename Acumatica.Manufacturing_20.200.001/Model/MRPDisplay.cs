using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_20_200_001.Model
{
	[DataContract]
	public class MRPDisplay : Entity
	{

		[DataMember(Name="ActionDate", EmitDefaultValue=false)]
		public DateTimeValue ActionDate { get; set; }

		[DataMember(Name="ActionLeadTime", EmitDefaultValue=false)]
		public IntValue ActionLeadTime { get; set; }

		[DataMember(Name="BaseQty", EmitDefaultValue=false)]
		public DecimalValue BaseQty { get; set; }

		[DataMember(Name="BaseUOM", EmitDefaultValue=false)]
		public StringValue BaseUOM { get; set; }

		[DataMember(Name="BOMID", EmitDefaultValue=false)]
		public StringValue BOMID { get; set; }

		[DataMember(Name="BOMRevision", EmitDefaultValue=false)]
		public StringValue BOMRevision { get; set; }

		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue Description { get; set; }

		[DataMember(Name="EmployeeName", EmitDefaultValue=false)]
		public StringValue EmployeeName { get; set; }

		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue InventoryID { get; set; }

		[DataMember(Name="ItemClass", EmitDefaultValue=false)]
		public StringValue ItemClass { get; set; }

		[DataMember(Name="MRPDate", EmitDefaultValue=false)]
		public DateTimeValue MRPDate { get; set; }

		[DataMember(Name="ParentInventoryID", EmitDefaultValue=false)]
		public StringValue ParentInventoryID { get; set; }

		[DataMember(Name="ParentSubitem", EmitDefaultValue=false)]
		public StringValue ParentSubitem { get; set; }

		[DataMember(Name="PreferredVendorID", EmitDefaultValue=false)]
		public StringValue PreferredVendorID { get; set; }

		[DataMember(Name="ProductInventoryID", EmitDefaultValue=false)]
		public StringValue ProductInventoryID { get; set; }

		[DataMember(Name="ProductManagerID", EmitDefaultValue=false)]
		public StringValue ProductManagerID { get; set; }

		[DataMember(Name="ProductSubitem", EmitDefaultValue=false)]
		public StringValue ProductSubitem { get; set; }

		[DataMember(Name="PromiseDate", EmitDefaultValue=false)]
		public DateTimeValue PromiseDate { get; set; }

		[DataMember(Name="RecordID", EmitDefaultValue=false)]
		public IntValue RecordID { get; set; }

		[DataMember(Name="ReferenceType", EmitDefaultValue=false)]
		public StringValue ReferenceType { get; set; }

		[DataMember(Name="RelatedDocument", EmitDefaultValue=false)]
		public GuidValue RelatedDocument { get; set; }

		[DataMember(Name="RelatedParentDocument", EmitDefaultValue=false)]
		public GuidValue RelatedParentDocument { get; set; }

		[DataMember(Name="RelatedProductDocument", EmitDefaultValue=false)]
		public GuidValue RelatedProductDocument { get; set; }

		[DataMember(Name="SDFlag", EmitDefaultValue=false)]
		public StringValue SDFlag { get; set; }

		[DataMember(Name="Selected", EmitDefaultValue=false)]
		public BooleanValue Selected { get; set; }

		[DataMember(Name="Source", EmitDefaultValue=false)]
		public StringValue Source { get; set; }

		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue Subitem { get; set; }

		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue Type { get; set; }

		[DataMember(Name="VendorName", EmitDefaultValue=false)]
		public StringValue VendorName { get; set; }

		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue Warehouse { get; set; }

	}
}