using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    /// <summary>
    /// Customer class to be used in full project - partial project doesn't require customer
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Customer constructor to add new customers
        /// Customer Id is assigned in the class
        /// </summary>
        /// <param name="name">name of customer</param>
        /// <param name="address">1st line of address of customer</param>
        /// <param name="postcode">postcode of customer</param>
        /// <param name="email">email address of customer</param>
        public Customer(string name, string address, string postcode, string email)
        {
            CustomerName = name;
            CustomerAddress = address;
            CustomerPostcode = postcode;
            CustomerEmail = email;
            _lastCustId++;
            CustomerId = _lastCustId;
        }

        public int CustomerId { get; private set; }
        public string CustomerName { get; private set; }
        public string CustomerAddress { get; private set; }
        public string CustomerPostcode { get; private set; }
        public string CustomerEmail { get; private set; }

        // get customer id working
        private int _lastCustId = 0;
    }
}
