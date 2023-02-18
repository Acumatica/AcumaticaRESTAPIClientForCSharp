using System;

namespace Acumatica.RESTClient.Model
{

    // TODO: Remove
    [Obsolete("Needed only for SOAP-Like client. Do not use.")]
    public class LinkedEntity
    {
        public Entity Value;
        public Type Type;
        public string Name;
        public LinkedEntity(Type type, Entity value, string name)
        {
            Value = value;
            Type = type;
            Name = name;
        }
    }
}
