using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace Group8FinalProject
{ 
    /// <summary>
    /// this class keeps track of data specific to each customer's order
    /// </summary>
    internal class Order
    {
        /// <summary>
        /// These are the data properties pertaining to each customer's order
        /// </summary>
        public DateTime PickupTime { get; set; }
        public string CustomerName { get; set; } = "";
        public decimal OrderTotal { get; set; } = 0.0m;
        public decimal OrderBudget { get; set; } = 0.0m;
        public bool OrderCompleted { get; set; } = false;
        public int OrderType { set; get; } = 0;

        /// <summary>
        /// This code initializes a new ComboList for every customer
        /// </summary>
        public ComboList customerOrder = new ComboList();

        /// <summary>
        /// Default Constructor for the Order Class
        /// </summary>
        public Order()
        {

        }
 
        /// <summary>
        /// this is the main constructor used for the Order Class
        /// </summary>
        /// <param name="customerName">Customer Name form data</param>
        public Order(string customerName)
        {
            CustomerName = customerName;
        }
        
        /// <summary>
        /// This function gets the remaining information that wasn't input into the form when the constructor was run
        /// </summary>
        /// <param name="pickuptime">pickup time form data</param>
        /// <param name="ordertotal">order total form data</param>
        /// <param name="orderbudget">order budget form data</param>
        /// <param name="ordertype">order type form data</param>
        public void AddData(DateTime pickuptime, decimal ordertotal, decimal orderbudget, int ordertype)
        {
            OrderCompleted = true;
            PickupTime = pickuptime;
            OrderTotal = ordertotal;
            OrderBudget = orderbudget;
            OrderType = ordertype;
        }
    }
}