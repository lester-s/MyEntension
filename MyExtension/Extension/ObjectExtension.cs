using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExtension.Extension
{
    public static class ObjectExtension
    {
        public static Array ToArray(this object j)
        {
            Type myType = j.GetType();
            Array array = Array.CreateInstance(myType, 1);
            array.SetValue(j, 0);
            return array;
        }
    }
}
