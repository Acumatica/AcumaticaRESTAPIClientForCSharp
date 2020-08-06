using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ValidateProjectBalance : EntityAction<Project>
	{
		public ValidateProjectBalance(Project entity) : base(entity)
		{ }
		public ValidateProjectBalance() : base()
		{ }
	}
}
