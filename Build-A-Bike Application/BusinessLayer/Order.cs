using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Order
    {
        /// <summary>
        /// Constructor for order
        /// Order Id automatically assigned
        /// </summary>
        /// <param name="customerId">Id of the customer setting up the order</param>
        public Order( int customerId)
        {
            CustomerId = customerId;
        }

        public int OrderId { get; private set; }
        public int OrderCost { get; private set; }
        public int CustomerId { get; private set; }

        public void NewOrder()
        {

        }

        public void CancelOrder(int orderId)
        {

        }

        public void PayDeposit()
        {

        }

        public void GenerateReceipt()
        {

        }

        public void AddNewBike()
        {

        }
    }
}
