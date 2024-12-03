using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group8FinalProject
{
    /// <summary>
    /// ComboList Class acts as a list of Combo Class Instances (Indexers CH13)
    /// </summary>
    internal class ComboList
    {
        /// <summary>
        /// this code block declares the list of Combo class objects
        /// </summary>
        public List<Combo> combos;
        public ComboList() => combos = new();
        public int Count => combos.Count;

        /// <summary>
        /// this function creates a new Combo and adds it to the list of combo instances
        /// </summary>
        /// <param name="combo">The Combo instance to be added</param>
        public void Add(Combo combo)
        {
            combos.Add(combo);
        }

        /// <summary>
        ///  this function creates a new Combo from form data and adds it to the list of combo instances
        /// </summary>
        /// <param name="addon1">addon form data</param>
        /// <param name="addon2">addon form data</param>
        /// <param name="addon3">addon form data</param>
        /// <param name="addon4">addon form data</param>
        /// <param name="addon5">addon form data</param>
        /// <param name="addon6">addon form data</param>
        /// <param name="addon7">addon form data</param>
        /// <param name="addon8">addon form data</param>
        /// <param name="drink">addon form data</param>
        /// <param name="drinksize">drink form data</param>
        /// <param name="courseside">drink form data</param>
        /// <param name="coursesidesize">courseside form data</param>
        /// <param name="combochoice">courseside form data</param>
        public void Add(bool addon1, bool addon2, bool addon3, bool addon4, bool addon5, bool addon6, bool addon7, bool addon8, bool drink, int drinksize, bool courseside, int coursesidesize, int combochoice)
        {
            Combo c = new Combo(addon1, addon2, addon3, addon4, addon5, addon6, addon7, addon8, drink, drinksize, courseside, coursesidesize, combochoice);
            combos.Add(c);
        }

        /// <summary>
        /// This function grabs a requested Combo from the ComboList depending on its index
        /// </summary>
        /// <param name="i">the index of the ComboList requested</param>
        /// <returns></returns>
        public Combo GetComboByIndex(int i) => combos[i];

        /// <summary>
        /// This function removes a Combo instance from the ComboList
        /// </summary>
        /// <param name="combo">The Combo instance to be deleted</param>
        public void Remove(Combo combo)
        {
            combos.Remove(combo);
        }

        /// <summary>
        /// This function gets the cost of every combo a customer ordered and adds them up.
        /// </summary>
        /// <returns>returns the total cost of the customer's order</returns>
        public decimal CalculateOrderPrice()
        {
            decimal price = 0.0m;
            foreach (Combo combo in combos)
            {
                price = price + combo.ComboPrice;
            }
            return price;
        }
    }
}
