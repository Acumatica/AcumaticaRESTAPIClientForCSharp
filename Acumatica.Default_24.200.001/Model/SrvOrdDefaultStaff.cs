using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_24_200_001.Model
{
	[DataContract]
	public class SrvOrdDefaultStaff : Entity
	{

		/// <summary>
		/// DAC: PX.Objects.FS.FSSODet 
		/// Display Name: Equipment Action Comment 
		/// SQL Type: varchar(255) 
		/// </summary>
		[DataMember(Name="Comment", EmitDefaultValue=false)]
		public StringValue? Comment { get; set; }

		/// <summary>
		/// DAC Field Name: FSSODetEmployee__TranDesc 
		/// DAC: PX.Objects.FS.FSSOEmployee 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: FSSODetEmployee__InventoryID 
		/// DAC: PX.Objects.FS.FSSOEmployee 
		/// </summary>
		[DataMember(Name="InventoryID", EmitDefaultValue=false)]
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSSODet 
		/// Display Name: Line Nbr. 
		/// Key Field
		/// </summary>
		[DataMember(Name="LineNbr", EmitDefaultValue=false)]
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSSOEmployee 
		/// Display Name: Detail Ref. Nbr. 
		/// SQL Type: char(4) 
		/// </summary>
		[DataMember(Name="ServiceLineRef", EmitDefaultValue=false)]
		public StringValue? ServiceLineRef { get; set; }

		/// <summary>
		/// DAC Field Name: RefNbr 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// Display Name: Order Nbr. 
		/// SQL Type: nvarchar(15) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ServiceOrderNbr", EmitDefaultValue=false)]
		public StringValue? ServiceOrderNbr { get; set; }

		/// <summary>
		/// DAC Field Name: SrvOrdType 
		/// DAC: PX.Objects.FS.FSServiceOrder 
		/// Display Name: Order Type 
		/// SQL Type: char(4) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ServiceOrderType", EmitDefaultValue=false)]
		public StringValue? ServiceOrderType { get; set; }

		/// <summary>
		/// DAC Field Name: EmployeeID 
		/// DAC: PX.Objects.FS.FSProfitability 
		/// Display Name: Staff Member 
		/// SQL Type: nvarchar(30) 
		/// </summary>
		[DataMember(Name="StaffMemberID", EmitDefaultValue=false)]
		public StringValue? StaffMemberID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSSOEmployee 
		/// SQL Type: char(2) 
		/// </summary>
		[DataMember(Name="Type", EmitDefaultValue=false)]
		public StringValue? Type { get; set; }

	}
}