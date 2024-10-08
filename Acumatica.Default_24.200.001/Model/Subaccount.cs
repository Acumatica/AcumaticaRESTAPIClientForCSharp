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
	/// Corresponds to the screen GL203000 in the Acumatica ERP
	/// </summary>
	[DataContract]
	public class Subaccount : Entity, ITopLevelEntity
	{

		/// <summary>
		/// Indicates whether the Subaccount is active.Inactive subaccounts do not appear in the lists of available subaccounts andthus can't be selected for documents, transactions and other entities.
		/// DAC: PX.Objects.GL.Sub 
		/// </summary>
		[DataMember(Name="Active", EmitDefaultValue=false)]
		public BooleanValue? Active { get; set; }

		/// <summary>
		/// The description of the Subaccount.
		/// DAC: PX.Objects.GL.Sub 
		/// SQL Type: nvarchar(255) 
		/// </summary>
		[DataMember(Name="Description", EmitDefaultValue=false)]
		public StringValue? Description { get; set; }

		/// <summary>
		/// DAC: PX.Objects.GL.Sub 
		/// </summary>
		[DataMember(Name="Secured", EmitDefaultValue=false)]
		public BooleanValue? Secured { get; set; }

		/// <summary>
		/// Key field.Unique user-friendly segmented key of the Subaccount.
		/// DAC Field Name: SubCD 
		/// DAC: PX.Objects.GL.Sub 
		/// Display Name: Subaccount 
		/// SQL Type: nvarchar(30) 
		/// Key Field
		/// </summary>
		[DataMember(Name="SubaccountCD", EmitDefaultValue=false)]
		public StringValue? SubaccountCD { get; set; }

		/// <summary>
		/// Database identity.Unique identifier of the Subaccount.
		/// DAC Field Name: SubID 
		/// DAC: PX.Objects.GL.Sub 
		/// Display Name: Sub. ID 
		/// </summary>
		[DataMember(Name="SubaccountID", EmitDefaultValue=false)]
		public IntValue? SubaccountID { get; set; }

		public virtual string GetEndpointPath()
		{
			return "entity/Default/24.200.001";
		}
	}
}