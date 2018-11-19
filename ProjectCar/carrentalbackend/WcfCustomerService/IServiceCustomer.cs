using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Domain;

namespace WcfCustomerService
{
    
    [ServiceContract]
    public interface IServiceCustomer
    {
        [OperationContract]
        void AddCustomer(string fName, string lName, string eMail, int tel);

        [OperationContract]
        Customer[] GetCustomerList();

        [OperationContract]
        Customer GetCustomerByLastName(string lName);

        [OperationContract]
        Customer GetCustomerById(string Id);

        [OperationContract]
        void UpdateCustomer(Customer x);

        [OperationContract]
        void DeleteCustomer(string customerId);


    }
}
