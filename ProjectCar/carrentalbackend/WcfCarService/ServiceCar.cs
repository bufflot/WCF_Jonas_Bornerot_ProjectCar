using ContextService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using UnitsOfWork.UnitofWorkPattern;
using Services;
using Repository;
using Domain;

namespace WcfCarService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CarService" in both code and config file together.
    public class ServiceCar : IServiceCar
    {
        IUnitOfWork unitOfWork = new UnitOfWork(new DatabaseContext());

        public void AddCar(string registrationNumber, string brand, string model, int? year)
        {
            try
            {
            unitOfWork.CarService.Insert(new Car { Brand = brand, Model = model, Year = year, RegistrationNumber = registrationNumber, Avaliable = true});
            unitOfWork.Save();
            }
            catch (Exception e)
            {
                throw new FaultException("Make sure year is set to 4 integers only. Log: " + e.Message);
            }
        }

        public Car[] GetCarList()
        {
            try
            {
                Car[] cars = unitOfWork.CarService.GetAll().ToArray();
                return cars;
                //return unitOfWork.CarService.GetAll().ToArray();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new FaultException(e.Message);
            }
        }

        public Car GetCarByRegNr(string reg)
        {
            try
            {
                Car x = unitOfWork.CarService.Find(c => c.RegistrationNumber == reg).FirstOrDefault();
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new FaultException ("Found no Car with the matching reg nr.  Log: " + e.Message);
            }
        }

        public void DeleteCar(string carId)
        {
            try
            {
                int Id = int.Parse(carId);
                Car x = unitOfWork.CarService.FindByID(Id);
                Console.WriteLine("Deleting Car with ID" + x.ID);
                unitOfWork.CarService.Delete(x);
                unitOfWork.Save();
            }
            catch (Exception e)
            {
               throw new FaultException("Error deleting car. Log: "+ e.Message);
            }
        }

        public void ReturnCar(string carId)
        {
           Car car = unitOfWork.CarService.FindByID(Convert.ToInt32(carId));
            car.Avaliable = true;
            unitOfWork.Save();
        }
    }
}
