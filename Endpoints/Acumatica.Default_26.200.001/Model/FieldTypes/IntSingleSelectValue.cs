using System.Runtime.Serialization;

namespace Acumatica.RESTClient.ContractBasedApi.Model
{
    [DataContract]
    public partial class IntSingleSelectValue : RestValueBase<IntSelectInnerValue>
    {
        public static implicit operator int?(IntSingleSelectValue value) => value?.Value?.ID;
        public static implicit operator IntSingleSelectValue(int value) => new IntSingleSelectValue(value);

        public IntSingleSelectValue(int? value = default)
        {
            if(value == null)
            {
                this.Value = null;
                return;
			}
			this.Value = new IntSelectInnerValue(value.Value);
        }
    }
    public class IntSelectInnerValue
	{
        public IntSelectInnerValue(int id)
        {
            ID = id;
        }
		public int ID { get; set; }
        public string? Description { get; set; }
    }
}
