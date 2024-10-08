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
		/// Specifies (if set to true) that the transaction has been approved by a responsible person.This field is displayed if the RequestApproval field is set to true.
		/// DAC: PX.Objects.CA.CAAdj 
		/// </summary>
		[DataMember(Name="Approved", EmitDefaultValue=false)]
		public BooleanValue? Approved { get; set; }

		/// <summary>
		/// The cash account that is the source account for the transaction.
		/// DAC Field Name: CashAccountID 
		/// DAC: PX.Objects.CA.CAAdj 
		/// Display Name: Cash Account 
		/// </summary>
		[DataMember(Name="CashAccountCD", EmitDefaultValue=false)]
		public StringValue? CashAccountCD { get; set; }

		/// <summary>
		/// The description of the transaction.
		/// DAC Field Name: TranDesc 
		/// DAC: PX.Objects.CA.CAAdj 
		/// SQL Type: nvarchar(512) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<CashTransactionDetail>? Details { get; set; }

		/// <summary>
		/// The user-defined transaction type. Selects the appropriate type from the list of entry types defined for the selected cash account.
		/// DAC Field Name: EntryTypeID 
		/// DAC: PX.Objects.CA.CAAdj 
		/// Display Name: Entry Type 
		/// SQL Type: nvarchar(10) 
		/// </summary>
		[DataMember(Name="EntryTypeCD", EmitDefaultValue=false)]
		public StringValue? EntryTypeCD { get; set; }

		/// <summary>
		/// The reference number of the external document.
		/// DAC Field Name: ExtRefNbr 
		/// DAC: PX.Objects.CA.CAAdj 
		/// Display Name: Document Ref. 
		/// SQL Type: nvarchar(40) 
		/// </summary>
		[DataMember(Name="ExternalReferenceNumber", EmitDefaultValue=false)]
		public StringValue? ExternalReferenceNumber { get; set; }

		/// <summary>
		/// The date of the transaction.
		/// DAC Field Name: TranDate 
		/// DAC: PX.Objects.CA.CAAdj 
		/// Display Name: Tran. Date 
		/// </summary>
		[DataMember(Name="PostedDate", EmitDefaultValue=false)]
		public DateTimeValue? PostedDate { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/eCommerce/23.200.001";
		}
	}
}