using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MenuService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string AddItem(Item item);
        [OperationContract]
        DataSet getItems();
        [OperationContract]
        string DeleteItem(Item item);
        [OperationContract]
        DataSet SearchItem(Item item);
        [OperationContract]
        string UpdateItem(Item item);
        
        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "MenuService.ContractType".
    [DataContract]
    public class Item
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int Price { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public string Category { get; set; }
        [DataMember]
        public string Status { get; set; }
    }
}
