using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.RESTClient.ContractBasedApi
{
    public static class EntityStructureHelper
    {
        public static bool IsDetail(PropertyInfo property)
        {
            return typeof(IEnumerable).IsAssignableFrom(property.PropertyType)
                    && property.Name != nameof(Entity.Custom)
                    && property.Name != nameof(Entity.CustomFields)
                    && property.Name != nameof(Entity.Files)
                    && property.PropertyType != typeof(CustomField[])
                    && property.PropertyType != typeof(string);
        }
        public static bool IsLinkedEntity(PropertyInfo property)
        {
            return typeof(Entity).IsAssignableFrom(property.PropertyType);
        }
    }
}
