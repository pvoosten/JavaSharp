using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace JavaAstReader
{
    [Serializable]
    public class InvalidJavaSyntaxException : Exception
    {
        public InvalidJavaSyntaxException() { }
        public InvalidJavaSyntaxException(XElement child) : this(string.Format("Unexpected {0} child element of {1} element", child.Name.LocalName, child.Parent.Name.LocalName)) { }
        public InvalidJavaSyntaxException(string message) : base(message) { }
        public InvalidJavaSyntaxException(string message, Exception inner) : base(message, inner) { }
        protected InvalidJavaSyntaxException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
