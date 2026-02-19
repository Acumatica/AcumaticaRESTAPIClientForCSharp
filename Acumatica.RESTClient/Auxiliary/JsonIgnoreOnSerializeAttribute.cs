using System;

namespace Acumatica.RESTClient.Auxiliary
{
	/// <summary>
	/// Attribute to indicate that a property should be ignored during JSON serialization.
	/// </summary>
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class JsonIgnoreOnSerializeAttribute : Attribute { }
}
