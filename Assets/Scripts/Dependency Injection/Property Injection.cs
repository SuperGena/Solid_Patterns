using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tutorials
{
    public class PropertyInjection : MonoBehaviour
    {
        
    }

    public interface ICustomerDataAccess
    {
        string GetCustomerName(int id);
    }

    public class CustomerDataAccess : ICustomerDataAccess
    {
        public CustomerDataAccess()
        {
        }

        public string GetCustomerName(int id)
        {
            //get the customer name from the db in real application        
            return "Dummy Customer Name";
        }
    }

    public class CustomerBusinessLogic
    {
        public CustomerBusinessLogic()
        {
        }

        public string GetCustomerName(int id)
        {
            return DataAccess.GetCustomerName(id);
        }

        public ICustomerDataAccess DataAccess { get; set; }
    }

    public class CustomerService
    {
        CustomerBusinessLogic _customerBL;

        public CustomerService()
        {
            _customerBL = new CustomerBusinessLogic();
            _customerBL.DataAccess = new CustomerDataAccess();
        }

        public string GetCustomerName(int id)
        {
            return _customerBL.GetCustomerName(id);
        }
    }
}
