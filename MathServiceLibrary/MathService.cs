using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MathServiceLibrary
{
    public class MathService : IMathService
    {
        public int Add(MyNumbers obj)
        {
            return(obj.Number1 + obj.Number2);  
        }
        public int Subtract(MyNumbers obj)
        {
            return (obj.Number1 - obj.Number2);
        }
    }
}
