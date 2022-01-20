using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Manufacturing_21_200_001.Model
{
	[DataContract]
	public class ReleaseDisassemblyEntry : EntityAction<DisassemblyEntry>
	{
		public ReleaseDisassemblyEntry(DisassemblyEntry entity) : base(entity)
		{ }
		public ReleaseDisassemblyEntry() : base()
		{ }
	}
}
