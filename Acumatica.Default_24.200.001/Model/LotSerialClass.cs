using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen IN207000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class LotSerialClass : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LotSerAssign 
		/// DAC: PX.Objects.IN.INLotSerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="AssignmentMethod", EmitDefaultValue=false)]
		public StringValue? AssignmentMethod { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LotSerClassID 
		/// DAC: PX.Objects.IN.INLotSerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ClassID", EmitDefaultValue=false)]
		public StringValue? ClassID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Descr 
		/// DAC: PX.Objects.IN.INLotSerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LotSerIssueMethod 
		/// DAC: PX.Objects.IN.INLotSerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="IssueMethod", EmitDefaultValue=false)]
		public StringValue? IssueMethod { get; set; }

		[DataMember(Name="Segments", EmitDefaultValue=false)]
		public List<LotSerialClassSegment>? Segments { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LotSerTrackExpiration 
		/// DAC: PX.Objects.IN.INLotSerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TrackExpirationDate", EmitDefaultValue=false)]
		public BooleanValue? TrackExpirationDate { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LotSerTrack 
		/// DAC: PX.Objects.IN.INLotSerClass 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="TrackingMethod", EmitDefaultValue=false)]
		public StringValue? TrackingMethod { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}