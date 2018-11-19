using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Domain;
using System.Net.Security;

namespace WcfCarService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICarService" in both code and config file together.
    [ServiceContract]
    public interface IServiceCar
    {

        [OperationContract]
        void AddCar(string registrationNumber, string brand, string model, int? year);

        [OperationContract]
        Car[] GetCarList();

        [OperationContract]//(ProtectionLevel = ProtectionLevel.EncryptAndSign)
        Car GetCarByRegNr(string reg);

        [OperationContract]
        void DeleteCar(string carId);

        [OperationContract]
        void ReturnCar(string carId);


    }
}
