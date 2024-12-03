using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group8FinalProject
{
    /// <summary>
    /// OrderList Class acts as a list of Order Class Instances (Indexers CH13)
    /// </summary>
    internal class OrderList
    {
        /// <summary>
        /// this code block declares the list of Order class objects
        /// </summary>
        public List<Order> orders;
        public OrderList() => orders = new();
        public int Count => orders.Count;

        /// <summary>
        /// this function creates a new Order and adds it to the list of order instances
        /// </summary>
        /// <param name="order">The Order instance to be added</param>
        public void Add(Order order)
        {
            orders.Add(order);
        }

        /// <summary>
        /// this function creates a new Order from form data and adds it to the list of order instances
        /// </summary>
        /// <param name="customerName">Customer Name form data</param>
        public void Add(string customerName)
        {
            Order o = new Order(customerName);
            orders.Add(o);
        }

        /// <summary>
        /// This function grabs a requested Order from the OrderList depending on its index
        /// </summary>
        /// <param name="i">the index of the OrderList requested</param>
        /// <returns></returns>
        public Order GetOrderByIndex(int i) => orders[i];

        /// <summary>
        /// This function removes a Order instance from the OrderList
        /// </summary>
        /// <param name="order">The Order instance to be deleted</param>
        public void Remove(Order order)
        {
            orders.Remove(order);
        }
    }
}
