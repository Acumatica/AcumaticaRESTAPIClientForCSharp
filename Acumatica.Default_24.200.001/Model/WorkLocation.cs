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
	/// Corresponds to the screen PR101040 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class WorkLocation : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: IsActive 
		/// DAC: PX.Objects.PR.PRLocation 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		[DataMember(Name="AddressInfo", EmitDefaultValue=false)]
		public Address? AddressInfo { get; set; }

		[DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
		public DateTimeValue? LastModifiedDateTime { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: BranchID 
		/// DAC: PX.Objects.PR.PRLocation 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="UseAddressfromBranchID", EmitDefaultValue=false)]
		public StringValue? UseAddressfromBranchID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: LocationCD 
		/// DAC: PX.Objects.PR.PRLocation 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="WorkLocationID", EmitDefaultValue=false)]
		public StringValue? WorkLocationID { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Description 
		/// DAC: PX.Objects.PR.PRLocation 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="WorkLocationName", EmitDefaultValue=false)]
		public StringValue? WorkLocationName { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}