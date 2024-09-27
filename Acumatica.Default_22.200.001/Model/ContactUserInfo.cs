using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class ContactUserInfo : Entity
	{

		/// <summary>
		/// This field indicates whether the system needs to automatically generate the password automatically for this user.
		/// DAC: PX.SM.Users 
		/// Display Name: Generate Password 
		/// </summary>
		[DataMember(Name="GeneratePassword", EmitDefaultValue=false)]
		public BooleanValue? GeneratePassword { get; set; }

		/// <summary>
		/// The login name for the user.This field is a key field.
		/// DAC Field Name: Username 
		/// DAC: PX.SM.Users 
		/// SQL Type: nvarchar(256) 
		/// Key Field
		/// </summary>
		[DataMember(Name="Login", EmitDefaultValue=false)]
		public StringValue? Login { get; set; }

		/// <summary>
		/// The password of the user.
		/// DAC: PX.SM.Users 
		/// SQL Type: nvarchar(512) 
		/// </summary>
		[DataMember(Name="Password", EmitDefaultValue=false)]
		public StringValue? Password { get; set; }

		[DataMember(Name="Roles", EmitDefaultValue=false)]
		public List<ContactRoles>? Roles { get; set; }

		/// <summary>
		/// The string identifier of the state or province part of the address.
		/// DAC Field Name: State 
		/// DAC: PX.Objects.CR.Address 
		/// Display Name: State 
		/// SQL Type: nvarchar(50) 
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// The type of the user login.
		/// DAC Field Name: LoginTypeID 
		/// DAC: PX.SM.Users 
		/// Display Name: User Type 
		/// </summary>
		[DataMember(Name="UserType", EmitDefaultValue=false)]
		public StringValue? UserType { get; set; }

	}
}