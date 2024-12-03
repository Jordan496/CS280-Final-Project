using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group8FinalProject
{
    /// <summary>
    /// Combo class is the structure of a Combo instance 
    /// </summary>
    internal class Combo
    {
        
        /// <summary>
        /// these are the automatic properties that contain the AddOn state for each combo
        /// </summary>
        public bool AddOn1 { get; set; } = false;
        public bool AddOn2 { get; set; } = false;
        public bool AddOn3 { get; set; } = false;
        public bool AddOn4 { get; set; } = false;
        public bool AddOn5 { get; set; } = false;
        public bool AddOn6 { get; set; } = false;
        public bool AddOn7 { get; set; } = false;
        public bool AddOn8 { get; set; } = false;

        /// <summary>
        ///  these are the class properties that will hold the data for the drink and Course Side data
        /// </summary>
        public bool Drink { get; set; } = false;
        public int DrinkSize { get; set; } = 0;
        public bool CourseSide { get; set; } = false;
        public int CourseSideSize { get; set; } = 0;

        /// <summary>
        /// this is the class property that will hold the text details of each combo a specific order includes
        /// </summary>
        public string ComboText { get; set; } = "";
 
        /// <summary>
        /// this is the class property that will hold the price of the individual combo ordered
        /// </summary>
        public decimal ComboPrice { get; set; } = 0.0m;

        /// <summary>
        /// this is the property variable that will hold the ID for the combo selcted
        /// </summary>
        public int ComboChoice { get; set; } = 0;

         
        /// <summary>
        /// main constructor for the Combo Class
        /// </summary>
        /// <param name="addon1">addon form data</param>
        /// <param name="addon2">addon form data</param>
        /// <param name="addon3">addon form data</param>
        /// <param name="addon4">addon form data</param>
        /// <param name="addon5">addon form data</param>
        /// <param name="addon6">addon form data</param>
        /// <param name="addon7">addon form data</param>
        /// <param name="addon8">addon form data</param>
        /// <param name="drink">drink form data</param>
        /// <param name="drinksize">drink form data</param>
        /// <param name="courseside">course side form data</param>
        /// <param name="coursesidesize">course side form data</param>
        /// <param name="combochoice">combo form data</param>
        public Combo(bool addon1, bool addon2, bool addon3, bool addon4, bool addon5, bool addon6, bool addon7, bool addon8, bool drink, int drinksize, bool courseside, int coursesidesize, int combochoice)
        {
            AddOn1 = addon1;
            AddOn2 = addon2;
            AddOn3 = addon3;
            AddOn4 = addon4;
            AddOn5 = addon5;
            AddOn6 = addon6;
            AddOn7 = addon7;
            AddOn8 = addon8;
            Drink = drink;
            DrinkSize = drinksize;
            CourseSide = courseside;
            CourseSideSize = coursesidesize;
            ComboChoice = combochoice;

            CalculateComboPrice();
            CalculateComboText();   
        }
 
        /// <summary>
        /// default constructor of the combo class
        /// </summary>
        public Combo()
        {

        }

        /// <summary>
        /// this function takes the Combo data and calculates the price
        /// </summary>
        public void CalculateComboPrice()
        {
            if (ComboChoice == 1)
            {
                ComboPrice = 6.95m;

                if (AddOn1 == true) ComboPrice = ComboPrice + 0.75m;
                if (AddOn2 == true) ComboPrice = ComboPrice + 0.75m;
                if (AddOn3 == true) ComboPrice = ComboPrice + 0.75m;
                if (AddOn4 == true) ComboPrice = ComboPrice + 0.75m;
                if (AddOn5 == true) ComboPrice = ComboPrice + 0.75m;
                if (AddOn6 == true) ComboPrice = ComboPrice + 0.75m;
                if (AddOn7 == true) ComboPrice = ComboPrice + 0.75m;
                if (AddOn8 == true) ComboPrice = ComboPrice + 0.75m;
            }
            else if (ComboChoice == 2)
            {
                ComboPrice = 5.95m;

                if (AddOn1 == true) ComboPrice = ComboPrice + 0.50m;
                if (AddOn2 == true) ComboPrice = ComboPrice + 0.50m;
                if (AddOn3 == true) ComboPrice = ComboPrice + 0.50m;
                if (AddOn4 == true) ComboPrice = ComboPrice + 0.50m;
                if (AddOn5 == true) ComboPrice = ComboPrice + 0.50m;
                if (AddOn6 == true) ComboPrice = ComboPrice + 0.50m;
                if (AddOn7 == true) ComboPrice = ComboPrice + 0.50m;
                if (AddOn8 == true) ComboPrice = ComboPrice + 0.50m;
            }
            else if (ComboChoice == 3)
            {
                ComboPrice = 4.95m;

                if (AddOn1 == true) ComboPrice = ComboPrice + 0.25m;
                if (AddOn2 == true) ComboPrice = ComboPrice + 0.25m;
                if (AddOn3 == true) ComboPrice = ComboPrice + 0.25m;
                if (AddOn4 == true) ComboPrice = ComboPrice + 0.25m;
                if (AddOn5 == true) ComboPrice = ComboPrice + 0.25m;
                if (AddOn6 == true) ComboPrice = ComboPrice + 0.25m;
                if (AddOn7 == true) ComboPrice = ComboPrice + 0.25m;
                if (AddOn8 == true) ComboPrice = ComboPrice + 0.25m;
            }
            else if (ComboChoice == 4)
            {
                ComboPrice = 5.45m;

                if (AddOn1 == true) ComboPrice = ComboPrice + 0.50m;
                if (AddOn2 == true) ComboPrice = ComboPrice + 0.50m;
                if (AddOn3 == true) ComboPrice = ComboPrice + 0.50m;
                if (AddOn4 == true) ComboPrice = ComboPrice + 0.50m;
                if (AddOn5 == true) ComboPrice = ComboPrice + 0.50m;
                if (AddOn6 == true) ComboPrice = ComboPrice + 0.50m;
                if (AddOn7 == true) ComboPrice = ComboPrice + 0.50m;
                if (AddOn8 == true) ComboPrice = ComboPrice + 0.50m;
            }
            else if (ComboChoice == 5)
            {
                ComboPrice = 6.45m;

                if (AddOn1 == true) ComboPrice = ComboPrice + 0.25m;
                if (AddOn2 == true) ComboPrice = ComboPrice + 0.25m;
                if (AddOn3 == true) ComboPrice = ComboPrice + 0.25m;
                if (AddOn4 == true) ComboPrice = ComboPrice + 0.25m;
                if (AddOn5 == true) ComboPrice = ComboPrice + 0.25m;
                if (AddOn6 == true) ComboPrice = ComboPrice + 0.25m;
                if (AddOn7 == true) ComboPrice = ComboPrice + 0.25m;
                if (AddOn8 == true) ComboPrice = ComboPrice + 0.25m;
            }
            else if (ComboChoice == 6)
            {
                ComboPrice = 4.45m;

                if (AddOn1 == true) ComboPrice = ComboPrice + 0.75m;
                if (AddOn2 == true) ComboPrice = ComboPrice + 0.75m;
                if (AddOn3 == true) ComboPrice = ComboPrice + 0.75m;
                if (AddOn4 == true) ComboPrice = ComboPrice + 0.75m;
                if (AddOn5 == true) ComboPrice = ComboPrice + 0.75m;
                if (AddOn6 == true) ComboPrice = ComboPrice + 0.75m;
                if (AddOn7 == true) ComboPrice = ComboPrice + 0.75m;
                if (AddOn8 == true) ComboPrice = ComboPrice + 0.75m;
            }
            else if (ComboChoice == 7)
            {
                ComboPrice = 7.45m;

                if (AddOn1 == true) ComboPrice = ComboPrice + 0.50m;
                if (AddOn2 == true) ComboPrice = ComboPrice + 0.50m;
                if (AddOn3 == true) ComboPrice = ComboPrice + 0.50m;
                if (AddOn4 == true) ComboPrice = ComboPrice + 0.50m;
                if (AddOn5 == true) ComboPrice = ComboPrice + 0.50m;
                if (AddOn6 == true) ComboPrice = ComboPrice + 0.50m;
                if (AddOn7 == true) ComboPrice = ComboPrice + 0.50m;
                if (AddOn8 == true) ComboPrice = ComboPrice + 0.50m;
            }
            else
            {
                ComboPrice = 7.95m;

                if (AddOn1 == true) ComboPrice = ComboPrice + 0.25m;
                if (AddOn2 == true) ComboPrice = ComboPrice + 0.25m;
                if (AddOn3 == true) ComboPrice = ComboPrice + 0.25m;
                if (AddOn4 == true) ComboPrice = ComboPrice + 0.25m;
                if (AddOn5 == true) ComboPrice = ComboPrice + 0.25m;
                if (AddOn6 == true) ComboPrice = ComboPrice + 0.25m;
                if (AddOn7 == true) ComboPrice = ComboPrice + 0.25m;
                if (AddOn8 == true) ComboPrice = ComboPrice + 0.25m;
            }
        }
 
        /// <summary>
        /// this function takes the combo data and creates the output string for this instance's combo
        /// </summary>
        public void CalculateComboText()
        {
            if (ComboChoice == 1)
            {
                ComboText = "Hamburger";

                if (AddOn1 == true || AddOn2 == true || AddOn3 == true || AddOn4 == true || AddOn5 == true || AddOn6 == true || AddOn7 == true || AddOn8 == true)
                {
                    ComboText = ComboText + " w/ ";

                    if (AddOn1 == true) ComboText = ComboText + "Lettuce ";
                    if (AddOn2 == true) ComboText = ComboText + "Tomato ";
                    if (AddOn3 == true) ComboText = ComboText + "Onion ";
                    if (AddOn4 == true) ComboText = ComboText + "Ketchup ";
                    if (AddOn5 == true) ComboText = ComboText + "Mustard ";
                    if (AddOn6 == true) ComboText = ComboText + "Maynaise ";
                    if (AddOn7 == true) ComboText = ComboText + "Pickles ";
                    if (AddOn8 == true) ComboText = ComboText + "Cheese ";

                    ComboText = ComboText + ": ";

                    if (CourseSide == true)
                    {
                        if (CourseSideSize == 1) ComboText = ComboText + "Small French Fries ";
                        if (CourseSideSize == 2) ComboText = ComboText + "Medium French Fries ";
                        if (CourseSideSize == 3) ComboText = ComboText + "Large French Fries ";
                        ComboText = ComboText + ": ";
                    }

                    if (Drink == true)
                    {
                        if (DrinkSize == 1) ComboText = ComboText + "Small Drink ";
                        if (DrinkSize == 2) ComboText = ComboText + "Medium Drink ";
                        if (DrinkSize == 3) ComboText = ComboText + "Large Drink ";
                    }
                } 
            }
            else if (ComboChoice == 2)
            {
                ComboText = "Pizza";

                if (AddOn1 == true || AddOn2 == true || AddOn3 == true || AddOn4 == true || AddOn5 == true || AddOn6 == true || AddOn7 == true || AddOn8 == true)
                {
                    ComboText = ComboText + " w/ ";

                    if (AddOn1 == true) ComboText = ComboText + "Pepperoni ";
                    if (AddOn2 == true) ComboText = ComboText + "Sausage ";
                    if (AddOn3 == true) ComboText = ComboText + "Beef ";
                    if (AddOn4 == true) ComboText = ComboText + "Ham ";
                    if (AddOn5 == true) ComboText = ComboText + "Olives ";
                    if (AddOn6 == true) ComboText = ComboText + "Mushrooms ";
                    if (AddOn7 == true) ComboText = ComboText + "Onions ";
                    if (AddOn8 == true) ComboText = ComboText + "Green Peppers ";

                    ComboText = ComboText + ": ";

                    if (CourseSide == true)
                    {
                        if (CourseSideSize == 1) ComboText = ComboText + "Tomato Sauce ";
                        if (CourseSideSize == 2) ComboText = ComboText + "Creamy Garlic Sauce ";
                        if (CourseSideSize == 3) ComboText = ComboText + "Sweet Chili Sauce ";
                        ComboText = ComboText + ": ";
                    }

                    if (Drink == true)
                    {
                        if (DrinkSize == 1) ComboText = ComboText + "Small Drink ";
                        if (DrinkSize == 2) ComboText = ComboText + "Medium Drink ";
                        if (DrinkSize == 3) ComboText = ComboText + "Large Drink ";
                    }
                }
            }
            else if (ComboChoice == 3)
            {
                ComboText = "Salad";

                if (AddOn1 == true || AddOn2 == true || AddOn3 == true || AddOn4 == true || AddOn5 == true || AddOn6 == true || AddOn7 == true || AddOn8 == true)
                {
                    ComboText = ComboText + " w/ ";

                    if (AddOn1 == true) ComboText = ComboText + "Croutons ";
                    if (AddOn2 == true) ComboText = ComboText + "Bacon Bits ";
                    if (AddOn3 == true) ComboText = ComboText + "Bread Sticks ";
                    if (AddOn4 == true) ComboText = ComboText + "Almonds ";
                    if (AddOn5 == true) ComboText = ComboText + "Dried Cranberries ";
                    if (AddOn6 == true) ComboText = ComboText + "Pita Chips ";
                    if (AddOn7 == true) ComboText = ComboText + "Cheese ";
                    if (AddOn8 == true) ComboText = ComboText + "Avocados ";

                    ComboText = ComboText + ": ";

                    if (CourseSide == true)
                    {
                        if (CourseSideSize == 1) ComboText = ComboText + "Ramch Dressing ";
                        if (CourseSideSize == 2) ComboText = ComboText + "Italian Dressing ";
                        if (CourseSideSize == 3) ComboText = ComboText + "Cesar Dressing ";
                        ComboText = ComboText + ": ";
                    }

                    if (Drink == true)
                    {
                        if (DrinkSize == 1) ComboText = ComboText + "Small Drink ";
                        if (DrinkSize == 2) ComboText = ComboText + "Medium Drink ";
                        if (DrinkSize == 3) ComboText = ComboText + "Large Drink ";
                    }
                }
            }
            else if (ComboChoice == 4)
            {
                ComboText = "Pasta";

                if (AddOn1 == true || AddOn2 == true || AddOn3 == true || AddOn4 == true || AddOn5 == true || AddOn6 == true || AddOn7 == true || AddOn8 == true)
                {
                    ComboText = ComboText + " w/ ";

                    if (AddOn1 == true) ComboText = ComboText + "Meatballs ";
                    if (AddOn2 == true) ComboText = ComboText + "Cheese ";
                    if (AddOn3 == true) ComboText = ComboText + "Basil ";
                    if (AddOn4 == true) ComboText = ComboText + "Oregano ";
                    if (AddOn5 == true) ComboText = ComboText + "Red Pepper Flakes ";
                    if (AddOn6 == true) ComboText = ComboText + "Rosemary ";
                    if (AddOn7 == true) ComboText = ComboText + "Spinach ";
                    if (AddOn8 == true) ComboText = ComboText + "Tomato ";

                    ComboText = ComboText + ": ";

                    if (CourseSide == true)
                    {
                        if (CourseSideSize == 1) ComboText = ComboText + "Marinara Sauce ";
                        if (CourseSideSize == 2) ComboText = ComboText + "Alfredo Sauce ";
                        if (CourseSideSize == 3) ComboText = ComboText + "Pesto Sauce ";
                        ComboText = ComboText + ": ";
                    }

                    if (Drink == true)
                    {
                        if (DrinkSize == 1) ComboText = ComboText + "Small Drink ";
                        if (DrinkSize == 2) ComboText = ComboText + "Medium Drink ";
                        if (DrinkSize == 3) ComboText = ComboText + "Large Drink ";
                    }
                }
            }
            else if (ComboChoice == 5)
            {
                ComboText = "Taco";

                if (AddOn1 == true || AddOn2 == true || AddOn3 == true || AddOn4 == true || AddOn5 == true || AddOn6 == true || AddOn7 == true || AddOn8 == true)
                {
                    ComboText = ComboText + " w/ ";

                    if (AddOn1 == true) ComboText = ComboText + "Jalepeno ";
                    if (AddOn2 == true) ComboText = ComboText + "Lettuce ";
                    if (AddOn3 == true) ComboText = ComboText + "Cheese ";
                    if (AddOn4 == true) ComboText = ComboText + "Diced Onions ";
                    if (AddOn5 == true) ComboText = ComboText + "Avocado ";
                    if (AddOn6 == true) ComboText = ComboText + "Parsley ";
                    if (AddOn7 == true) ComboText = ComboText + "Chives ";
                    if (AddOn8 == true) ComboText = ComboText + "Scallions ";

                    ComboText = ComboText + ": ";

                    if (CourseSide == true)
                    {
                        if (CourseSideSize == 1) ComboText = ComboText + "Guacamole Salsa ";
                        if (CourseSideSize == 2) ComboText = ComboText + "Tomato Salsa ";
                        if (CourseSideSize == 3) ComboText = ComboText + "Cilantro-Lime Crema Salsa ";
                        ComboText = ComboText + ": ";
                    }

                    if (Drink == true)
                    {
                        if (DrinkSize == 1) ComboText = ComboText + "Small Drink ";
                        if (DrinkSize == 2) ComboText = ComboText + "Medium Drink ";
                        if (DrinkSize == 3) ComboText = ComboText + "Large Drink ";
                    }
                }
            }
            else if (ComboChoice == 6)
            {
                ComboText = "Soup";

                if (AddOn1 == true || AddOn2 == true || AddOn3 == true || AddOn4 == true || AddOn5 == true || AddOn6 == true || AddOn7 == true || AddOn8 == true)
                {
                    ComboText = ComboText + " w/ ";

                    if (AddOn1 == true) ComboText = ComboText + "Croutons ";
                    if (AddOn2 == true) ComboText = ComboText + "Cheese ";
                    if (AddOn3 == true) ComboText = ComboText + "Mushrooms ";
                    if (AddOn4 == true) ComboText = ComboText + "Sesame Seeds ";
                    if (AddOn5 == true) ComboText = ComboText + "Fried Onions ";
                    if (AddOn6 == true) ComboText = ComboText + "Nuts ";
                    if (AddOn7 == true) ComboText = ComboText + "Bacon ";
                    if (AddOn8 == true) ComboText = ComboText + "Sausage ";

                    ComboText = ComboText + ": ";

                    if (CourseSide == true)
                    {
                        if (CourseSideSize == 1) ComboText = ComboText + "Parsley Spice ";
                        if (CourseSideSize == 2) ComboText = ComboText + "Cumin Spice ";
                        if (CourseSideSize == 3) ComboText = ComboText + "Chili Powder Spice ";
                        ComboText = ComboText + ": ";
                    }

                    if (Drink == true)
                    {
                        if (DrinkSize == 1) ComboText = ComboText + "Small Drink ";
                        if (DrinkSize == 2) ComboText = ComboText + "Medium Drink ";
                        if (DrinkSize == 3) ComboText = ComboText + "Large Drink ";
                    }
                }
            }
            else if (ComboChoice == 7)
            {
                ComboText = "Steak";

                if (AddOn1 == true || AddOn2 == true || AddOn3 == true || AddOn4 == true || AddOn5 == true || AddOn6 == true || AddOn7 == true || AddOn8 == true)
                {
                    ComboText = ComboText + " w/ ";

                    if (AddOn1 == true) ComboText = ComboText + "Cheese ";
                    if (AddOn2 == true) ComboText = ComboText + "Mushrooms ";
                    if (AddOn3 == true) ComboText = ComboText + "Butter ";
                    if (AddOn4 == true) ComboText = ComboText + "Caviar ";
                    if (AddOn5 == true) ComboText = ComboText + "Fried Egg ";
                    if (AddOn6 == true) ComboText = ComboText + "Kimchi ";
                    if (AddOn7 == true) ComboText = ComboText + "Guacamole ";
                    if (AddOn8 == true) ComboText = ComboText + "Sauce ";

                    ComboText = ComboText + ": ";

                    if (CourseSide == true)
                    {
                        if (CourseSideSize == 1) ComboText = ComboText + "Small French Fries ";
                        if (CourseSideSize == 2) ComboText = ComboText + "Medium French Fries ";
                        if (CourseSideSize == 3) ComboText = ComboText + "Large French Fries ";
                        ComboText = ComboText + ": ";
                    }

                    if (Drink == true)
                    {
                        if (DrinkSize == 1) ComboText = ComboText + "Small Drink ";
                        if (DrinkSize == 2) ComboText = ComboText + "Medium Drink ";
                        if (DrinkSize == 3) ComboText = ComboText + "Large Drink ";
                    }
                }
            }
            else if (ComboChoice == 8)
            {
                ComboText = "Dessert";

                if (AddOn1 == true || AddOn2 == true || AddOn3 == true || AddOn4 == true || AddOn5 == true || AddOn6 == true || AddOn7 == true || AddOn8 == true)
                {
                    ComboText = ComboText + " w/ ";

                    if (AddOn1 == true) ComboText = ComboText + "Cream Cheese ";
                    if (AddOn2 == true) ComboText = ComboText + "Whipped Cream ";
                    if (AddOn3 == true) ComboText = ComboText + "Chocolate Syrup ";
                    if (AddOn4 == true) ComboText = ComboText + "Caramel ";
                    if (AddOn5 == true) ComboText = ComboText + "Ice Cream ";
                    if (AddOn6 == true) ComboText = ComboText + "Cookie ";
                    if (AddOn7 == true) ComboText = ComboText + "Cupcake ";
                    if (AddOn8 == true) ComboText = ComboText + "Yogurt ";

                    ComboText = ComboText + ": ";

                    if (CourseSide == true)
                    {
                        if (CourseSideSize == 1) ComboText = ComboText + "Chocolate Flavor ";
                        if (CourseSideSize == 2) ComboText = ComboText + "Vanilla Flavor ";
                        if (CourseSideSize == 3) ComboText = ComboText + "Strawberry Flavor ";
                        ComboText = ComboText + ": ";
                    }

                    if (Drink == true)
                    {
                        if (DrinkSize == 1) ComboText = ComboText + "Small Drink ";
                        if (DrinkSize == 2) ComboText = ComboText + "Medium Drink ";
                        if (DrinkSize == 3) ComboText = ComboText + "Large Drink ";
                    }
                }
            }
        }
    }
}
