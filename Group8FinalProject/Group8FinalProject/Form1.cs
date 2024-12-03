using System;
using System.Security.Cryptography.X509Certificates;
namespace Group8FinalProject
{
    /// <summary>
    /// This class holds the events and functions of the windows form
    /// </summary>
    public partial class frmOrder : Form
    {
        /// <summary>
        /// This code block initializes the customer list
        /// </summary>
        OrderList restaurantOrders = new OrderList();
        
        /// <summary>
        /// These variables hold the current index to control the indexing in the OrderList and ComboList classes
        /// </summary>
        public int MaxCustomerID = 0;
        public int MaxComboID = 0;

        /// <summary>
        /// This function initializes the form
        /// </summary>
        public frmOrder()
        {
            InitializeComponent();
        }

        // Event Handlers 

        /// <summary>
        /// This event handler handles changes that need to be made per course selecting options (The trigger of this event is when a main course radiobutton is changed)
        /// </summary>
        /// <param name="sender">event parameter</param>
        /// <param name="e">event parameter</param>
        private void OnChanged(object sender, EventArgs e)
        {
            cbxDrink.Enabled = true;
            gbxSides.Enabled = true;

            if (rbtnHamburger.Checked == true)
            {
                cbxCourseSize.Text = "French Fries";
                rbtnSmallCourseSize.Text = "Small";
                rbtnMediumCourseSize.Text = "Medium";
                rbtnLargeCourseSize.Text = "Large";
                cbxAddOn1.Text = "Lettuce";
                cbxAddOn2.Text = "Tomato";
                cbxAddOn3.Text = "Onion";
                cbxAddOn4.Text = "Ketchup";
                cbxAddOn5.Text = "Mustard";
                cbxAddOn6.Text = "Mayonaise";
                cbxAddOn7.Text = "Pickles";
                cbxAddOn8.Text = "Cheese";
            }
            else if (rbtnPizza.Checked == true)
            {
                cbxCourseSize.Text = "Sauce";
                rbtnSmallCourseSize.Text = "Tomato";
                rbtnMediumCourseSize.Text = "Creamy Garlic";
                rbtnLargeCourseSize.Text = "Sweet Chili";
                cbxAddOn1.Text = "Pepperoni";
                cbxAddOn2.Text = "Sausage";
                cbxAddOn3.Text = "Beef";
                cbxAddOn4.Text = "Ham";
                cbxAddOn5.Text = "Olives";
                cbxAddOn6.Text = "Mushrooms";
                cbxAddOn7.Text = "Onion";
                cbxAddOn8.Text = "Green Peppers";
            }
            else if (rbtnSalad.Checked == true)
            {
                cbxCourseSize.Text = "Dressing";
                rbtnSmallCourseSize.Text = "Ranch";
                rbtnMediumCourseSize.Text = "Italian";
                rbtnLargeCourseSize.Text = "Cesar";
                cbxAddOn1.Text = "Croutons";
                cbxAddOn2.Text = "Bacon Bits";
                cbxAddOn3.Text = "Bread Sticks";
                cbxAddOn4.Text = "Almonds";
                cbxAddOn5.Text = "Dried Cranberries";
                cbxAddOn6.Text = "Pita Chips";
                cbxAddOn7.Text = "Cheese";
                cbxAddOn8.Text = "Avocados";
            }
            else if (rbtnPasta.Checked == true)
            {
                cbxCourseSize.Text = "Sauce";
                rbtnSmallCourseSize.Text = "Marinara";
                rbtnMediumCourseSize.Text = "Alfredo";
                rbtnLargeCourseSize.Text = "Pesto";
                cbxAddOn1.Text = "Meatballs";
                cbxAddOn2.Text = "Cheese";
                cbxAddOn3.Text = "Basil";
                cbxAddOn4.Text = "Oregano";
                cbxAddOn5.Text = "Red Pepper Flakes";
                cbxAddOn6.Text = "Rosemary";
                cbxAddOn7.Text = "Spinach";
                cbxAddOn8.Text = "Tomato";
            }
            else if (rbtnTaco.Checked == true)
            {
                cbxCourseSize.Text = "Salsa";
                rbtnSmallCourseSize.Text = "Guacamole";
                rbtnMediumCourseSize.Text = "Tomato Salsa";
                rbtnLargeCourseSize.Text = "Cilantro-Lime Crema";
                cbxAddOn1.Text = "Jalepeno";
                cbxAddOn2.Text = "Lettuce";
                cbxAddOn3.Text = "Cheese";
                cbxAddOn4.Text = "Diced Onions";
                cbxAddOn5.Text = "Avacodo";
                cbxAddOn6.Text = "Parsley";
                cbxAddOn7.Text = "Chives";
                cbxAddOn8.Text = "Scallions";
            }
            else if (rbtnSoup.Checked == true)
            {
                cbxCourseSize.Text = "Soup Spice";
                rbtnSmallCourseSize.Text = "Parsley";
                rbtnMediumCourseSize.Text = "Cumin";
                rbtnLargeCourseSize.Text = "Chili Powder";
                cbxAddOn1.Text = "Croutons";
                cbxAddOn2.Text = "Cheese";
                cbxAddOn3.Text = "Mushrooms";
                cbxAddOn4.Text = "Sesame Seeds";
                cbxAddOn5.Text = "Fried Onions";
                cbxAddOn6.Text = "Nuts";
                cbxAddOn7.Text = "Bacon";
                cbxAddOn8.Text = "Sausage";
            }
            else if (rbtnSteak.Checked == true)
            {
                cbxCourseSize.Text = "French Fries";
                rbtnSmallCourseSize.Text = "Small";
                rbtnMediumCourseSize.Text = "Medium";
                rbtnLargeCourseSize.Text = "Large";
                cbxAddOn1.Text = "Cheese";
                cbxAddOn2.Text = "Mushrooms";
                cbxAddOn3.Text = "Butter";
                cbxAddOn4.Text = "Caviar";
                cbxAddOn5.Text = "Fried Egg";
                cbxAddOn6.Text = "Kimchi";
                cbxAddOn7.Text = "Guacamole";
                cbxAddOn8.Text = "Sauce";
            }
            else if (rbtnDessert.Checked == true)
            {
                cbxCourseSize.Text = "Flavor";
                rbtnSmallCourseSize.Text = "Chocolate";
                rbtnMediumCourseSize.Text = "Vanilla";
                rbtnLargeCourseSize.Text = "Strawberry";
                cbxAddOn1.Text = "Cream Cheese";
                cbxAddOn2.Text = "Whipped Cream";
                cbxAddOn3.Text = "Chocolate Syrup";
                cbxAddOn4.Text = "Caramel";
                cbxAddOn5.Text = "Ice Cream";
                cbxAddOn6.Text = "Cookie";
                cbxAddOn7.Text = "Cupcake";
                cbxAddOn8.Text = "Yogurt";

                cbxDrink.Enabled = false;

            }

            rbtnSmallDrink.Enabled = false;
            rbtnMediumDrink.Enabled = false;
            rbtnLargeDrink.Enabled = false;
            cbxDrink.Checked = false;
            rbtnSmallDrink.Checked = false;
            rbtnMediumDrink.Checked = false;
            rbtnLargeDrink.Checked = false;

            cbxCourseSize.Checked = false;
            rbtnSmallCourseSize.Enabled = false;
            rbtnMediumCourseSize.Enabled = false;
            rbtnLargeCourseSize.Enabled = false;
            rbtnSmallCourseSize.Checked = false;
            rbtnMediumCourseSize.Checked = false;
            rbtnLargeCourseSize.Checked = false;

            cbxAddOn1.Checked = false;
            cbxAddOn2.Checked = false;
            cbxAddOn3.Checked = false;
            cbxAddOn4.Checked = false;
            cbxAddOn5.Checked = false;
            cbxAddOn6.Checked = false;
            cbxAddOn7.Checked = false;
            cbxAddOn8.Checked = false;
        }
 
        /// <summary>
        /// this is the logic to add a combo order to the ComboList
        /// </summary>
        /// <param name="sender">event parameter</param>
        /// <param name="e">event parameter</param>
        private void btn_Add_To_Order(object sender, EventArgs e)
        {
            int drinkSize = 0;
            int courseSideSize = 0;
            int comboChoice = 0;

            if (cbxDrink.Checked == true)
            {
                if (rbtnSmallDrink.Checked == true)
                {
                    drinkSize = 1;
                }
                else if (rbtnMediumDrink.Checked == true)
                {
                    drinkSize = 2;
                }
                else if (rbtnLargeDrink.Checked == true)
                {
                    drinkSize = 3;
                }
                else
                {
                    drinkSize = 0;
                }
            }

            if (cbxCourseSize.Checked == true)
            {
                if (rbtnSmallCourseSize.Checked == true)
                {
                    courseSideSize = 1;
                }
                else if (rbtnMediumCourseSize.Checked == true)
                {
                    courseSideSize = 2;
                }
                else if (rbtnLargeCourseSize.Checked == true)
                {
                    courseSideSize = 3;
                }
                else
                {
                    courseSideSize = 0;
                }
            }

            if (rbtnHamburger.Checked == true)
            {
                comboChoice = 1;
            }
            else if (rbtnPizza.Checked == true)
            {
                comboChoice = 2;
            }
            else if (rbtnSalad.Checked == true)
            {
                comboChoice = 3;
            }
            else if (rbtnPasta.Checked == true)
            {
                comboChoice = 4;
            }
            else if (rbtnTaco.Checked == true)
            {
                comboChoice = 5;
            }
            else if (rbtnSoup.Checked == true)
            {
                comboChoice = 6;
            }
            else if (rbtnSteak.Checked == true)
            {
                comboChoice = 7;
            }
            else
            {
                comboChoice = 8;
            }

            // add the Combo to the order ticket and reset the default values

            restaurantOrders.GetOrderByIndex(MaxCustomerID).customerOrder.Add(cbxAddOn1.Checked, cbxAddOn2.Checked, cbxAddOn3.Checked, cbxAddOn4.Checked, cbxAddOn5.Checked, cbxAddOn6.Checked, cbxAddOn7.Checked, cbxAddOn8.Checked, cbxDrink.Checked, drinkSize, cbxCourseSize.Checked, courseSideSize, comboChoice);
            ResetDefaults();

            // run a function to calculate and display the current cost total for the current customer ticket

            txtOrderTotal.Text = Convert.ToString(restaurantOrders.GetOrderByIndex(MaxCustomerID).customerOrder.CalculateOrderPrice());

            // run a function to populate and update the Combo Viewer Combobox

            cmbobxComboPicker.Items.Add(Convert.ToString(MaxComboID));
            MaxComboID = MaxComboID + 1;
        }

        /// <summary>
        /// This function clears the selections in the Windows form
        /// </summary>
        /// <param name="sender">event parameter</param>
        /// <param name="e">event parameter</param>
        private void btn_Clear_Food_Selection(object sender, EventArgs e)
        {
            ResetDefaults();
        }

        /// <summary>
        /// This functioinchanges the form to allow the customer to insert payment and pickup information
        /// </summary>
        /// <param name="sender">event parameter</param>
        /// <param name="e">event parmeter</param>
        private void btn_Pay_For_Order(object sender, EventArgs e)
        {
            ResetDefaults();
            gbxCourses.Enabled = false;
            gbxSides.Enabled = false;
            gbxCreateOrderButton.Enabled = false;
            gbxFoodSelectionButtons.Enabled = false;
            gbxViewOrderDetails.Enabled = false;
            gbxPaymentInformation.Enabled = true;
        }
 
        /// <summary>
        /// this function creates a new customer order instance for the customer to make an order
        /// </summary>
        /// <param name="sender">event parameter</param>
        /// <param name="e">event parameter</param>
        private void btn_Create_Order(object sender, EventArgs e)
        {
            // this code enables the relevant data fields for placing an order

            gbxCourses.Enabled = true;
            gbxSides.Enabled = true;
            gbxFoodSelectionButtons.Enabled = true;
            gbxViewOrderDetails.Enabled = true;

            // this function goes into the OrderList Class and calls the add function to add a new order to the list

            restaurantOrders.Add(txtName.Text);

            // this function adds the customer into the Combo Box that displays customer names

            cmbobxOrderPicker.Items.Add(restaurantOrders.GetOrderByIndex(MaxCustomerID).CustomerName);
            gbxCreateOrderButton.Enabled = false;
        }

        /// <summary>
        /// This function enables and disables drink sizes when requested
        /// </summary>
        /// <param name="sender">event parameter</param>
        /// <param name="e">event parameter</param>
        private void OnDrinkChanged(object sender, EventArgs e)
        {
            if (cbxDrink.Checked == true)
            {
                rbtnSmallDrink.Enabled = true;
                rbtnMediumDrink.Enabled = true;
                rbtnLargeDrink.Enabled = true;
            }
            else
            {
                rbtnSmallDrink.Enabled = false;
                rbtnMediumDrink.Enabled = false;
                rbtnLargeDrink.Enabled = false;
                rbtnSmallDrink.Checked = false;
                rbtnMediumDrink.Checked = false;
                rbtnLargeDrink.Checked = false;
            }
        }

        /// <summary>
        /// This function enables and disables the course side buttons when requested
        /// </summary>
        /// <param name="sender">event parameter</param>
        /// <param name="e">event parameter</param>
        private void onAddOnChanged(object sender, EventArgs e)
        {
            if (cbxCourseSize.Checked == true)
            {
                rbtnSmallCourseSize.Enabled = true;
                rbtnMediumCourseSize.Enabled = true;
                rbtnLargeCourseSize.Enabled = true;
            }
            else
            {
                rbtnSmallCourseSize.Enabled = false;
                rbtnMediumCourseSize.Enabled = false;
                rbtnLargeCourseSize.Enabled = false;
                rbtnSmallCourseSize.Checked = false;
                rbtnMediumCourseSize.Checked = false;
                rbtnLargeCourseSize.Checked = false;
            }
        }

        /// <summary>
        /// This function resets UI elements to their default state
        /// </summary>
        public void ResetDefaults()
        {
            cbxDrink.Checked = false;
            rbtnSmallDrink.Checked = false;
            rbtnMediumDrink.Checked = false;
            rbtnLargeDrink.Checked = false;
            cbxCourseSize.Checked = false;
            rbtnSmallCourseSize.Checked = false;
            rbtnMediumCourseSize.Checked = false;
            rbtnLargeCourseSize.Checked = false;
            cbxAddOn1.Checked = false;
            cbxAddOn2.Checked = false;
            cbxAddOn3.Checked = false;
            cbxAddOn4.Checked = false;
            cbxAddOn5.Checked = false;
            cbxAddOn6.Checked = false;
            cbxAddOn7.Checked = false;
            cbxAddOn8.Checked = false;
            rbtnHamburger.Checked = false;
            rbtnPizza.Checked = false;
            rbtnSalad.Checked = false;
            rbtnPasta.Checked = false;
            rbtnTaco.Checked = false;
            rbtnSoup.Checked = false;
            rbtnSteak.Checked = false;
            rbtnDessert.Checked = false;
            gbxSides.Enabled = false;
            rbtnSmallDrink.Enabled = false;
            rbtnMediumDrink.Enabled = false;
            rbtnLargeDrink.Enabled = false;
            rbtnSmallCourseSize.Enabled = false;
            rbtnMediumCourseSize.Enabled = false;
            rbtnLargeCourseSize.Enabled = false;
        }

        /// <summary>
        /// This function handles the event for if the Customer Combobox is changed
        /// </summary>
        /// <param name="sender">event parameter</param>
        /// <param name="e">event parameter</param>
        private void OnCustomerComboBoxChange(object sender, EventArgs e)
        {
            cmbobxComboPicker.Items.Clear();
            int index = 0;

            foreach (Combo i in restaurantOrders.GetOrderByIndex(cmbobxOrderPicker.SelectedIndex).customerOrder.combos)
            {
                cmbobxComboPicker.Items.Add(index);
                index++;
            }
        }

        /// <summary>
        /// This function handles the event for if the Combo Combobox is changed
        /// </summary>
        /// <param name="sender">event parameter</param>
        /// <param name="e">event parameter</param>
        private void OnComboNumberComboBoxChanged(object sender, EventArgs e)
        {
            rtxtFullOrder.Text = restaurantOrders.GetOrderByIndex(cmbobxOrderPicker.SelectedIndex).customerOrder.GetComboByIndex(cmbobxComboPicker.SelectedIndex).ComboText;
        }

        /// <summary>
        /// This function processes an order when payment is received
        /// </summary>
        /// <param name="sender">event parameter</param>
        /// <param name="e">event parameter</param>
        private void btn_Complete_Order_Payment(object sender, EventArgs e)
        {
            int ordertype = 0;

            if (rbtnDineIn.Checked == true)
            {
                ordertype = 1;
            }
            else if (rbtnTakeout.Checked == true)
            {
                ordertype = 2;
            }
            else
            {
                ordertype = 3;
            }

            restaurantOrders.GetOrderByIndex(MaxCustomerID).AddData(dateTimePicker.Value, Convert.ToDecimal(txtOrderTotal.Text), Convert.ToDecimal(txtBudget.Text), ordertype);

            gbxPaymentInformation.Enabled = false;
            gbxViewOrderDetails.Enabled = false;
            gbxFoodSelectionButtons.Enabled = false;
            gbxSides.Enabled = false;
            gbxCourses.Enabled = false;
            gbxCreateOrderButton.Enabled = true;

            MaxCustomerID = MaxCustomerID + 1;
            MaxComboID = 0;

            ResetDefaults();
            txtBudget.Text = "";
            txtOrderTotal.Text = "";
            rbtnDineIn.Checked = false;
            rbtnTakeout.Checked = false;
            rbtnOnline.Checked = false;
        }
    }
}