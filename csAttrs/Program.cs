using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csAttrs
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Reflection.MemberInfo info = typeof(MyClass);
            object[] attrs = info.GetCustomAttributes(true);
            foreach (object attr in attrs)
            {
                Debug.WriteLine(attr);
            }
        }
    }
}
