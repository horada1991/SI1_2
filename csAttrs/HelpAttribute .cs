using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csAttrs
{
    // The attribute AttributeUsage specifies the language elements to which the attribute can be applied.
    [AttributeUsage(AttributeTargets.All)]
    class HelpAttribute : System.Attribute
    {
        // Positional parameters must be specified every time the attribute is used.
        // Positional parameters are specified as constructor arguments to the attribute class.
        public readonly string Url;

        // Named parameters are optional.If they are specified when the attribute is used, the name of the parameter must be used.
        // Named parameters are defined by having a nonstatic field or property.
        public string Topic { get; set; }

        /*
         Attribute parameters are restricted to constant values of the following types:
            Simple types (bool, byte, char, short, int, long, float, and double)
            string
            System.Type
            enums
            object (The argument to an attribute parameter of type object must be a constant value of one of the above types.)
            One-dimensional arrays of any of the above types
        */
        public HelpAttribute(string url)
        {
            this.Url = url;
        }
    }
}
