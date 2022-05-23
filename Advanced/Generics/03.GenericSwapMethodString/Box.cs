using System;
using System.Collections.Generic;
using System.Text;

namespace _03.GenericSwapMethodString
{
    public class Box<T>
    {
        public Box()
        {

        }
        public Box(T value)
        {
            Value = value;
        }

        public T Value { get; set; }

        public override string ToString() => $"{typeof(T)}: {Value}";        
    }
}
