using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExtension.Extension
{
    public static class ObjectExtension
    {
        public static Array ToArray(this object obj)
        {
            Type myType = obj.GetType();
            Array array = Array.CreateInstance(myType, 1);
            array.SetValue(obj, 0);
            return array;
        }
    }
}
