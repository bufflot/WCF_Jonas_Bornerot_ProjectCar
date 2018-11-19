using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ContextService;
using Repository;
using Domain;
using UnitsOfWork.UnitofWorkPattern;
using Services;



namespace WcfCustomerService
{
    public class ServiceCustomer : IServiceCustomer
    {
        IUnitOfWork unitOfWork = new UnitOfWork(new DatabaseContext());

        public void AddCustomer(string fName, string lName, string eMail, int tel)
        {
            try
            {
                Console.WriteLine("Connected");
                unitOfWork.CustomerService.Insert(new Customer { FirstName = fName, LastName = lName, Email = eMail, Tel = tel });
                Console.WriteLine("Customer Added");
                unitOfWork.Save();
            }
            catch (Exception e)
            {
                throw new FaultException("Telephone can only contain numbers. Log Error: " + e.Message);
            }
        }

        public Customer[] GetCustomerList()
        {
            try
            {
                Customer[] customer = unitOfWork.CustomerService.GetAll().ToArray();

                return customer;
                //return unitOfWork.CarService.GetAll().ToArray();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new FaultException(e.Message);
            }
        }

        public Customer GetCustomerByLastName(string lName)
        {
            try
            {
                Customer x = unitOfWork.CustomerService.Find(c => c.LastName == lName).FirstOrDefault();
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new FaultException("Could not find any matches. Please make sure you spell the lastname correctly. Log: " + e.Message);
            }
        }

        public Customer GetCustomerById(string Id)
        {
            try
            {
                Customer x = unitOfWork.CustomerService.FindByID(int.Parse(Id));
                return x;
            }
            catch (Exception e)
            {
                throw new FaultException(e.Message);
            }
        }

        public void UpdateCustomer(Customer x)
        {
            Customer customer = unitOfWork.CustomerService.FindByID(x.ID);
            customer.FirstName = x.FirstName == "" ? customer.FirstName : x.FirstName;
            customer.LastName = x.LastName == "" ? customer.LastName : x.LastName;
            customer.Email = x.Email == "" ? customer.Email : x.Email;
            customer.Tel = x.Tel == 0 ? customer.Tel : x.Tel;
            unitOfWork.Save();
        }

        public void DeleteCustomer(string customerId)
        {
            try
            {
                int Id = int.Parse(customerId);
                Customer x = unitOfWork.CustomerService.FindByID(Id);
                Console.WriteLine("Deleting Customerr with ID" + x.ID);
                unitOfWork.CustomerService.Delete(x);
            }
            catch (Exception e)
            {
                throw new FaultException("Error deleting customer. Log: " + e.Message);
            }
        }
    }
}
