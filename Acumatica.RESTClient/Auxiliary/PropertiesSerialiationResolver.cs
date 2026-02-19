using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using System.Reflection;

namespace Acumatica.RESTClient.Auxiliary
{
	public sealed class PropertiesSerialiationResolver : DefaultContractResolver
	{
		protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
		{
			var prop = base.CreateProperty(member, memberSerialization);

			// Only suppress during serialization (writing). Deserialization still happens.
			if (member is PropertyInfo pi &&
				pi.GetCustomAttribute<JsonIgnoreOnSerializeAttribute>() != null)
			{
				prop.ShouldSerialize = _ => false;
			}

			return prop;
		}
	}
}
