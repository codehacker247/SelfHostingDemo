using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MathServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IMathService
    {
        [OperationContract]
        int Add(MyNumbers obj);
        [OperationContract]
        int Subtract(MyNumbers obj);    
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "MathServiceLibrary.ContractType".
    [DataContract]
    public class MyNumbers
    {
        [DataMember]
        public int Number1 { get; set; }    
        [DataMember]
        public int Number2 { get; set; }    

    }
}
