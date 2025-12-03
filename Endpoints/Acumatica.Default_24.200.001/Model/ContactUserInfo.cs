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
	public class ContactUserInfo : Entity
	{

		/// <summary>
		/// This field indicates whether the system needs to automatically generate the password automatically for this user.
		/// <para>DAC: PX.SM.Users</para>
		/// <para>Display Name: Generate Password</para>
		/// </summary>
		[DataMember(Name="GeneratePassword", EmitDefaultValue=false)]
		public BooleanValue? GeneratePassword { get; set; }

		/// <summary>
		/// The login name for the user.This field is a key field.
		/// <para>DAC Field Name: Username</para>
		/// <para>DAC: PX.SM.Users</para>
		/// <para>SQL Type: nvarchar(256)</para>
		/// Key Field
		/// </summary>
		[DataMember(Name="Login", EmitDefaultValue=false)]
		public StringValue? Login { get; set; }

		/// <summary>
		/// The password of the user.
		/// <para>DAC: PX.SM.Users</para>
		/// <para>SQL Type: nvarchar(512)</para>
		/// </summary>
		[DataMember(Name="Password", EmitDefaultValue=false)]
		public StringValue? Password { get; set; }

		[DataMember(Name="Roles", EmitDefaultValue=false)]
		public List<ContactRoles>? Roles { get; set; }

		/// <summary>
		/// The string identifier of the state or province part of the address.
		/// <para>DAC Field Name: State</para>
		/// <para>DAC: PX.Objects.CR.Address</para>
		/// <para>Display Name: State</para>
		/// <para>SQL Type: nvarchar(50)</para>
		/// </summary>
		[DataMember(Name="Status", EmitDefaultValue=false)]
		public StringValue? Status { get; set; }

		/// <summary>
		/// The type of the user login.
		/// <para>DAC Field Name: LoginTypeID</para>
		/// <para>DAC: PX.SM.Users</para>
		/// <para>Display Name: User Type</para>
		/// </summary>
		[DataMember(Name="UserType", EmitDefaultValue=false)]
		public StringValue? UserType { get; set; }

	}
}