using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_23_200_001.Model
{
	[DataContract]
	public class AppResourceEquipment : Entity
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
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Equipment Action Comment 
		/// SQL Type: varchar(255) 
		/// </summary>
		[DataMember(Name="Comment", EmitDefaultValue=false)]
		public StringValue? Comment { get; set; }

		/// <summary>
		/// DAC Field Name: FSEquipment__Descr 
		/// DAC: PX.Objects.FS.FSAppointmentResource 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC Field Name: SMEquipmentID 
		/// DAC: PX.Objects.FS.FSAppointmentDet 
		/// Display Name: Target Equipment ID 
		/// </summary>
		[DataMember(Name="EquipmentID", EmitDefaultValue=false)]
		public StringValue? EquipmentID { get; set; }

		/// <summary>
		/// DAC Field Name: SrvOrdType 
		/// DAC: PX.Objects.FS.FSAppointment 
		/// Display Name: Service Order Type 
		/// SQL Type: char(4) 
		/// Key Field
		/// </summary>
		[DataMember(Name="ServiceOrderType", EmitDefaultValue=false)]
		public StringValue? ServiceOrderType { get; set; }

	}
}