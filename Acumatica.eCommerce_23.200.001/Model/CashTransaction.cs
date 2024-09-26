using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.eCommerce_23_200_001.Model
{
	/// <summary>
	/// Corresponds to the screen CA304000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class CashTransaction : Entity, ITopLevelEntity
	{

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: Approved 
		/// DAC: PX.Objects.CA.CAAdj 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Approved", EmitDefaultValue=false)]
		public BooleanValue? Approved { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: CashAccountID 
		/// DAC: PX.Objects.CA.CAAdj 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="CashAccountCD", EmitDefaultValue=false)]
		public StringValue? CashAccountCD { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TranDesc 
		/// DAC: PX.Objects.CA.CAAdj 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<CashTransactionDetail>? Details { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: EntryTypeID 
		/// DAC: PX.Objects.CA.CAAdj 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="EntryTypeCD", EmitDefaultValue=false)]
		public StringValue? EntryTypeCD { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: ExtRefNbr 
		/// DAC: PX.Objects.CA.CAAdj 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="ExternalReferenceNumber", EmitDefaultValue=false)]
		public StringValue? ExternalReferenceNumber { get; set; }

		/// <summary>
		/// 
		/// Display Name:
		/// DAC Field Name: TranDate 
		/// DAC: PX.Objects.CA.CAAdj 
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		[DataMember(Name="PostedDate", EmitDefaultValue=false)]
		public DateTimeValue? PostedDate { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/eCommerce/23.200.001";
		}
	}
}