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
	/// Corresponds to the screen AM101000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class BomPreferences : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AllowArchiveWithoutUpdatePending 
		/// DAC: PX.Objects.AM.AMBSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AllowArchivewithoutUpdatePending", EmitDefaultValue=false)]
		public BooleanValue? AllowArchivewithoutUpdatePending { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AllowEmptyBOMSubItemID 
		/// DAC: PX.Objects.AM.AMBSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AllowEmptyBOMItemSubItemID", EmitDefaultValue=false)]
		public BooleanValue? AllowEmptyBOMItemSubItemID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: AutoArchiveWhenUpdatePending 
		/// DAC: PX.Objects.AM.AMBSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AutoArchivewhenUpdatePending", EmitDefaultValue=false)]
		public BooleanValue? AutoArchivewhenUpdatePending { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BOMNumberingID 
		/// DAC: PX.Objects.AM.AMBSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="BOMNumberingSequence", EmitDefaultValue=false)]
		public StringValue? BOMNumberingSequence { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DefaultFinishTime 
		/// DAC: PX.Objects.AM.AMBSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DefaultFinishTime", EmitDefaultValue=false)]
		public StringValue? DefaultFinishTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DefaultMoveTime 
		/// DAC: PX.Objects.AM.AMBSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DefaultMoveTime", EmitDefaultValue=false)]
		public StringValue? DefaultMoveTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DefaultQueueTime 
		/// DAC: PX.Objects.AM.AMBSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DefaultQueueTime", EmitDefaultValue=false)]
		public StringValue? DefaultQueueTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DefaultRevisionID 
		/// DAC: PX.Objects.AM.AMBSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DefaultRevision", EmitDefaultValue=false)]
		public StringValue? DefaultRevision { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: WcID 
		/// DAC: PX.Objects.AM.AMBSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DefaultWorkCenter", EmitDefaultValue=false)]
		public StringValue? DefaultWorkCenter { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DuplicateItemOnBOM 
		/// DAC: PX.Objects.AM.AMBSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DuplicatesonBOM", EmitDefaultValue=false)]
		public StringValue? DuplicatesonBOM { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: DuplicateItemOnOper 
		/// DAC: PX.Objects.AM.AMBSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="DuplicatesonOperation", EmitDefaultValue=false)]
		public StringValue? DuplicatesonOperation { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ECONumberingID 
		/// DAC: PX.Objects.AM.AMBSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ECONumberingSequence", EmitDefaultValue=false)]
		public StringValue? ECONumberingSequence { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ECORequestApproval 
		/// DAC: PX.Objects.AM.AMBSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ECORequireApproval", EmitDefaultValue=false)]
		public BooleanValue? ECORequireApproval { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ECRNumberingID 
		/// DAC: PX.Objects.AM.AMBSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ECRNumberingSequence", EmitDefaultValue=false)]
		public StringValue? ECRNumberingSequence { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ECRRequestApproval 
		/// DAC: PX.Objects.AM.AMBSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ECRRequireApproval", EmitDefaultValue=false)]
		public BooleanValue? ECRRequireApproval { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BOMHoldRevisionsOnEntry 
		/// DAC: PX.Objects.AM.AMBSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="HoldBOMRevisionsonEntry", EmitDefaultValue=false)]
		public BooleanValue? HoldBOMRevisionsonEntry { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: OperationTimeFormat 
		/// DAC: PX.Objects.AM.AMBSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="OperationTimeFormat", EmitDefaultValue=false)]
		public StringValue? OperationTimeFormat { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ForceECR 
		/// DAC: PX.Objects.AM.AMBSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PreventNewRevisionsWithoutECR", EmitDefaultValue=false)]
		public BooleanValue? PreventNewRevisionsWithoutECR { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: RequireECRBeforeECO 
		/// DAC: PX.Objects.AM.AMBSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="RequireECRbeforeCreatingECO", EmitDefaultValue=false)]
		public BooleanValue? RequireECRbeforeCreatingECO { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ProductionTimeFormat 
		/// DAC: PX.Objects.AM.AMBSetup 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TotalTimeFormat", EmitDefaultValue=false)]
		public StringValue? TotalTimeFormat { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/MANUFACTURING/24.200.001";
		}
	}
}