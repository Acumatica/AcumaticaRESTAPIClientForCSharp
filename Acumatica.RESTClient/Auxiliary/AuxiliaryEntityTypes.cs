using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acumatica.RESTClient.Model
{
    public enum ReturnBehavior
    {
        Default,
        All,
        None,
        OnlySystem,
        OnlySpecified,
    }
    public class EntityField
    {
        public object Value;
        public Type Type;
        public string Name;
        public EntityField(Type type, object value, string name)
        {
            Value = value;
            Type = type;
            Name = name;
        }
    }
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
    public class DetailEntity
    {
        public IEnumerable<Entity> Details;
        public string Name;
        public Type Type;
        public DetailEntity(Type type, IEnumerable details, string name)
        {
            Details = details.Cast<Entity>();
            Name = name;
            Type = type;
        }
    }
}
