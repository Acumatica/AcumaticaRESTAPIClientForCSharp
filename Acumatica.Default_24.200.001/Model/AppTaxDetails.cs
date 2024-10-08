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
	public class AppTaxDetails : Entity
	{

		/// <summary>
		/// DAC Field Name: RefNbr 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Appointment Nbr. 
		/// SQL Type: nvarchar(20) 
		/// Key Field
		/// </summary>
		[DataMember(Name="AppointmentNbr", EmitDefaultValue=false)]
		public StringValue? AppointmentNbr { get; set; }

		/// <summary>
		/// DAC Field Name: Tax__ExemptTax 
		/// DAC: PX.Objects.FS.FSAppointmentTaxTran 
		/// </summary>
		[DataMember(Name="IncludeinVATExemptTotal", EmitDefaultValue=false)]
		public BooleanValue? IncludeinVATExemptTotal { get; set; }

		/// <summary>
		/// DAC Field Name: Tax__PendingTax 
		/// DAC: PX.Objects.FS.FSAppointmentTaxTran 
		/// </summary>
		[DataMember(Name="PendingVAT", EmitDefaultValue=false)]
		public BooleanValue? PendingVAT { get; set; }

		[DataMember(Name="RecordID", EmitDefaultValue=false)]
		public IntValue? RecordID { get; set; }

		/// <summary>
		/// DAC Field Name: Tax__ReverseTax 
		/// DAC: PX.Objects.FS.FSAppointmentTaxTran 
		/// </summary>
		[DataMember(Name="ReverseVAT", EmitDefaultValue=false)]
		public BooleanValue? ReverseVAT { get; set; }

		/// <summary>
		/// DAC Field Name: SrvOrdType 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Service Order Type 
		/// SQL Type: char(4) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ServiceOrderType", EmitDefaultValue=false)]
		public StringValue? ServiceOrderType { get; set; }

		/// <summary>
		/// DAC Field Name: Tax__StatisticalTax 
		/// DAC: PX.Objects.FS.FSAppointmentTaxTran 
		/// </summary>
		[DataMember(Name="StatisticalVAT", EmitDefaultValue=false)]
		public BooleanValue? StatisticalVAT { get; set; }

		/// <summary>
		/// DAC Field Name: CuryTaxableAmt 
		/// DAC: PX.Objects.FS.FSAppointmentTaxTran 
		/// Display Name: Taxable Amount 
		/// </summary>
		[DataMember(Name="TaxableAmount", EmitDefaultValue=false)]
		public DecimalValue? TaxableAmount { get; set; }

		/// <summary>
		/// DAC Field Name: CuryTaxAmt 
		/// DAC: PX.Objects.FS.FSAppointmentTaxTran 
		/// Display Name: Tax Amount 
		/// </summary>
		[DataMember(Name="TaxAmount", EmitDefaultValue=false)]
		public DecimalValue? TaxAmount { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointmentTaxTran 
		/// Display Name: Tax ID 
		/// SQL Type: nvarchar(60) 
		/// Key Field
		/// </summary>
		[DataMember(Name="TaxID", EmitDefaultValue=false)]
		public StringValue? TaxID { get; set; }

		/// <summary>
		/// DAC: PX.Objects.FS.FSAppointmentTaxTran 
		/// Display Name: Tax Rate 
		/// </summary>
		[DataMember(Name="TaxRate", EmitDefaultValue=false)]
		public DecimalValue? TaxRate { get; set; }

		/// <summary>
		/// DAC Field Name: Tax__TaxType 
		/// DAC: PX.Objects.FS.FSAppointmentTaxTran 
		/// </summary>
		[DataMember(Name="TaxType", EmitDefaultValue=false)]
		public StringValue? TaxType { get; set; }

	}
}