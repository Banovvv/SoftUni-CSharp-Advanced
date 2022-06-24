using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ValidationAttributes.Attributes;

namespace ValidationAttributes.Models
{
    public class Validator
    {
        public static bool IsValid(object obj)
        {
            Type type = obj.GetType();

            PropertyInfo[] propertyInfos = type.GetProperties();

            foreach (var propertyInfo in propertyInfos)
            {
                List<MyValidationAttribute> attributes = propertyInfo.GetCustomAttributes<MyValidationAttribute>().ToList();

                var propertyValue = propertyInfo.GetValue(obj);

                foreach (var attribute in attributes)
                {
                    if (attribute.IsValid(propertyValue))
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
