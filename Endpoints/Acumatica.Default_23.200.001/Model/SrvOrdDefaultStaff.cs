using System;
using System.Collections.Generic;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	public class SrvOrdDefaultStaff : Entity
	{

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSSODet</para>
		/// <para>Display Name: Equipment Action Comment</para>
		/// <para>SQL Type: varchar(255)</para>
		/// </summary>
		public StringValue? Comment { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FSSODetEmployee__TranDesc</para>
		/// <para>DAC: PX.Objects.FS.FSSOEmployee</para>
		/// </summary>
		public StringValue? Description { get; set; }

		/// <summary>
		/// <para>DAC Field Name: FSSODetEmployee__InventoryID</para>
		/// <para>DAC: PX.Objects.FS.FSSOEmployee</para>
		/// </summary>
		public StringValue? InventoryID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSSODet</para>
		/// <para>Display Name: Line Nbr.</para>
		/// Key Field
		/// </summary>
		public IntValue? LineNbr { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSSOEmployee</para>
		/// <para>Display Name: Detail Ref. Nbr.</para>
		/// <para>SQL Type: char(4)</para>
		/// </summary>
		public StringValue? ServiceLineRef { get; set; }

		/// <summary>
		/// <para>DAC Field Name: RefNbr</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Order Nbr.</para>
		/// <para>SQL Type: nvarchar(15)</para>
		/// Key Field
		/// </summary>
		public StringValue? ServiceOrderNbr { get; set; }

		/// <summary>
		/// <para>DAC Field Name: SrvOrdType</para>
		/// <para>DAC: PX.Objects.FS.FSServiceOrder</para>
		/// <para>Display Name: Order Type</para>
		/// <para>SQL Type: char(4)</para>
		/// Key Field
		/// </summary>
		public StringValue? ServiceOrderType { get; set; }

		/// <summary>
		/// <para>DAC Field Name: EmployeeID</para>
		/// <para>DAC: PX.Objects.FS.FSProfitability</para>
		/// <para>Display Name: Staff Member</para>
		/// </summary>
		public StringValue? StaffMemberID { get; set; }

		/// <summary>
		/// <para>DAC: PX.Objects.FS.FSSOEmployee</para>
		/// <para>SQL Type: char(2)</para>
		/// </summary>
		public StringValue? Type { get; set; }

	}
}