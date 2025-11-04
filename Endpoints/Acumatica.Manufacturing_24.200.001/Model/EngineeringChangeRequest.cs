using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen AM210000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class EngineeringChangeRequest : Entity, ITopLevelEntity
	{

		[DataMember(Name="Attributes", EmitDefaultValue=false)]
		public List<EngineeringChangeRequestAttribute>? Attributes { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMECRItem 
		/// Display Name: BOM ID 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="BOMID", EmitDefaultValue=false)]
		public StringValue? BOMID { get; set; }

		/// <summary>
		/// DAC Field Name: BOMRevisionID 
		/// DAC: PX.Objects.AM.AMECRItem 
		/// Display Name: BOM Revision 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="BOMRevision", EmitDefaultValue=false)]
		public StringValue? BOMRevision { get; set; }

		/// <summary>
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.AM.AMECRItem 
		/// SQL Type: nvarchar(256) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMECRItem 
		/// Display Name: ECO ID 
		/// SQL Type: nvarchar(15) 
		/// </summary>
		[DataMember(Name="ECOID", EmitDefaultValue=false)]
		public StringValue? ECOID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMECRItem 
		/// Display Name: ECR ID 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ECRID", EmitDefaultValue=false)]
		public StringValue? ECRID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMECRItem 
		/// Display Name: Effective Date 
		/// </summary>
		[DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
		public DateTimeValue? EffectiveDate { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMECRItem 
		/// Display Name: Inventory ID 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		[DataMember(Name="Operations", EmitDefaultValue=false)]
		public List<EngineeringChangeRequestOperation>? Operations { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMECRItem 
		/// </summary>
		[DataMember(Name="Priority", EmitDefaultValue=false)]
		public IntValue? Priority { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMECRItem 
		/// Display Name: Request Date 
		/// </summary>
		[DataMember(Name="RequestDate", EmitDefaultValue=false)]
		public DateTimeValue? RequestDate { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMECRItem 
		/// </summary>
		[DataMember(Name="Requestor", EmitDefaultValue=false)]
		public StringValue? Requestor { get; set; }

		/// <summary>
		/// DAC Field Name: RevisionID 
		/// DAC: PX.Objects.AM.AMECRItem 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="Revision", EmitDefaultValue=false)]
		public StringValue? Revision { get; set; }

		/// <summary>
		/// DAC: PX.Objects.AM.AMECRItem 
		/// SQL Type: char(1) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// DAC Field Name: SubItemID 
		/// DAC: PX.Objects.AM.AMECRItem 
		/// </summary>
		[DataMember(Name="Subitem", EmitDefaultValue=false)]
		public StringValue? Subitem { get; set; }

		/// <summary>
		/// DAC Field Name: SiteID 
		/// DAC: PX.Objects.AM.AMECRItem 
		/// </summary>
		[DataMember(Name="Warehouse", EmitDefaultValue=false)]
		public StringValue? Warehouse { get; set; }

		public static class Expand
		{
			public const string Files = "Files";
			public const string Attributes = "Attributes";
			public const string Operations = "Operations";
			public const string Operations_Files = "Operations/Files";
			public const string Operations_Material = "Operations/Material";
			public const string Operations_Material_Files = "Operations/Material/Files";
			public const string Operations_Material_ReferenceDesignators = "Operations/Material/ReferenceDesignators";
			public const string Operations_Material_ReferenceDesignators_Files = "Operations/Material/ReferenceDesignators/Files";
			public const string Operations_Overheads = "Operations/Overheads";
			public const string Operations_Overheads_Files = "Operations/Overheads/Files";
			public const string Operations_Steps = "Operations/Steps";
			public const string Operations_Steps_Files = "Operations/Steps/Files";
			public const string Operations_Tools = "Operations/Tools";
			public const string Operations_Tools_Files = "Operations/Tools/Files";

			//Intentionally excluded
			//public const string All = "Files,Attributes,Operations,Operations/Files,Operations/Material,Operations/Material/Files,Operations/Material/ReferenceDesignators,Operations/Material/ReferenceDesignators/Files,Operations/Overheads,Operations/Overheads/Files,Operations/Steps,Operations/Steps/Files,Operations/Tools,Operations/Tools/Files";
		}
		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}