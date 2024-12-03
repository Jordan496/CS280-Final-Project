namespace Group8FinalProject
{
    partial class frmOrder
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbxCourses = new GroupBox();
            lblDessertPrice = new Label();
            lblSteakPrice = new Label();
            lblSoupPrice = new Label();
            lblTacoPrice = new Label();
            lblPastaPrice = new Label();
            lblSaladPrice = new Label();
            lblPizzaPrice = new Label();
            lblHamburgerPrice = new Label();
            rbtnDessert = new RadioButton();
            rbtnSteak = new RadioButton();
            rbtnSoup = new RadioButton();
            rbtnTaco = new RadioButton();
            rbtnPasta = new RadioButton();
            rbtnSalad = new RadioButton();
            rbtnPizza = new RadioButton();
            rbtnHamburger = new RadioButton();
            gbxSides = new GroupBox();
            gbxCourseSize = new GroupBox();
            cbxCourseSize = new CheckBox();
            rbtnSmallCourseSize = new RadioButton();
            rbtnLargeCourseSize = new RadioButton();
            rbtnMediumCourseSize = new RadioButton();
            gbxDrinks = new GroupBox();
            cbxDrink = new CheckBox();
            rbtnSmallDrink = new RadioButton();
            rbtnMediumDrink = new RadioButton();
            rbtnLargeDrink = new RadioButton();
            gbxAddOns = new GroupBox();
            cbxAddOn8 = new CheckBox();
            cbxAddOn7 = new CheckBox();
            cbxAddOn6 = new CheckBox();
            cbxAddOn5 = new CheckBox();
            cbxAddOn4 = new CheckBox();
            cbxAddOn3 = new CheckBox();
            cbxAddOn2 = new CheckBox();
            cbxAddOn1 = new CheckBox();
            btnAdd = new Button();
            btnClear = new Button();
            lblName = new Label();
            txtName = new TextBox();
            lblBudget = new Label();
            txtBudget = new TextBox();
            lblCost = new Label();
            txtOrderTotal = new TextBox();
            gbxPickup = new GroupBox();
            lblPickupDate = new Label();
            dateTimePicker = new DateTimePicker();
            lblPickupTime = new Label();
            lblOrderType = new Label();
            rbtnOnline = new RadioButton();
            rbtnTakeout = new RadioButton();
            rbtnDineIn = new RadioButton();
            btnComplete = new Button();
            cmbobxOrderPicker = new ComboBox();
            btnCreate = new Button();
            btnPay = new Button();
            gbxPaymentInformation = new GroupBox();
            gbxCreateOrderButton = new GroupBox();
            lblChooseCustomer = new Label();
            lblComboNumber = new Label();
            cmbobxComboPicker = new ComboBox();
            lblFullOrder = new Label();
            rtxtFullOrder = new RichTextBox();
            gbxFoodSelectionButtons = new GroupBox();
            gbxViewOrderDetails = new GroupBox();
            gbxCourses.SuspendLayout();
            gbxSides.SuspendLayout();
            gbxCourseSize.SuspendLayout();
            gbxDrinks.SuspendLayout();
            gbxAddOns.SuspendLayout();
            gbxPickup.SuspendLayout();
            gbxPaymentInformation.SuspendLayout();
            gbxCreateOrderButton.SuspendLayout();
            gbxFoodSelectionButtons.SuspendLayout();
            gbxViewOrderDetails.SuspendLayout();
            SuspendLayout();
            // 
            // gbxCourses
            // 
            gbxCourses.Controls.Add(lblDessertPrice);
            gbxCourses.Controls.Add(lblSteakPrice);
            gbxCourses.Controls.Add(lblSoupPrice);
            gbxCourses.Controls.Add(lblTacoPrice);
            gbxCourses.Controls.Add(lblPastaPrice);
            gbxCourses.Controls.Add(lblSaladPrice);
            gbxCourses.Controls.Add(lblPizzaPrice);
            gbxCourses.Controls.Add(lblHamburgerPrice);
            gbxCourses.Controls.Add(rbtnDessert);
            gbxCourses.Controls.Add(rbtnSteak);
            gbxCourses.Controls.Add(rbtnSoup);
            gbxCourses.Controls.Add(rbtnTaco);
            gbxCourses.Controls.Add(rbtnPasta);
            gbxCourses.Controls.Add(rbtnSalad);
            gbxCourses.Controls.Add(rbtnPizza);
            gbxCourses.Controls.Add(rbtnHamburger);
            gbxCourses.Enabled = false;
            gbxCourses.Location = new Point(85, 70);
            gbxCourses.Name = "gbxCourses";
            gbxCourses.Size = new Size(410, 269);
            gbxCourses.TabIndex = 0;
            gbxCourses.TabStop = false;
            gbxCourses.Text = "Courses";
            // 
            // lblDessertPrice
            // 
            lblDessertPrice.AutoSize = true;
            lblDessertPrice.Location = new Point(237, 238);
            lblDessertPrice.Name = "lblDessertPrice";
            lblDessertPrice.Size = new Size(159, 15);
            lblDessertPrice.TabIndex = 25;
            lblDessertPrice.Text = "($7.95 : Add-Ons $0.25/each)";
            // 
            // lblSteakPrice
            // 
            lblSteakPrice.AutoSize = true;
            lblSteakPrice.Location = new Point(237, 177);
            lblSteakPrice.Name = "lblSteakPrice";
            lblSteakPrice.Size = new Size(159, 15);
            lblSteakPrice.TabIndex = 24;
            lblSteakPrice.Text = "($7.45 : Add-Ons $0.50/each)";
            // 
            // lblSoupPrice
            // 
            lblSoupPrice.AutoSize = true;
            lblSoupPrice.Location = new Point(237, 115);
            lblSoupPrice.Name = "lblSoupPrice";
            lblSoupPrice.Size = new Size(159, 15);
            lblSoupPrice.TabIndex = 23;
            lblSoupPrice.Text = "($4.45 : Add-Ons $0.75/each)";
            // 
            // lblTacoPrice
            // 
            lblTacoPrice.AutoSize = true;
            lblTacoPrice.Location = new Point(237, 58);
            lblTacoPrice.Name = "lblTacoPrice";
            lblTacoPrice.Size = new Size(159, 15);
            lblTacoPrice.TabIndex = 22;
            lblTacoPrice.Text = "($6.45 : Add-Ons $0.25/each)";
            // 
            // lblPastaPrice
            // 
            lblPastaPrice.AutoSize = true;
            lblPastaPrice.Location = new Point(43, 238);
            lblPastaPrice.Name = "lblPastaPrice";
            lblPastaPrice.Size = new Size(159, 15);
            lblPastaPrice.TabIndex = 21;
            lblPastaPrice.Text = "($5.45 : Add-Ons $0.50/each)";
            // 
            // lblSaladPrice
            // 
            lblSaladPrice.AutoSize = true;
            lblSaladPrice.Location = new Point(43, 177);
            lblSaladPrice.Name = "lblSaladPrice";
            lblSaladPrice.Size = new Size(159, 15);
            lblSaladPrice.TabIndex = 19;
            lblSaladPrice.Text = "($4.95 : Add-Ons $0.25/each)";
            // 
            // lblPizzaPrice
            // 
            lblPizzaPrice.AutoSize = true;
            lblPizzaPrice.Location = new Point(43, 115);
            lblPizzaPrice.Name = "lblPizzaPrice";
            lblPizzaPrice.Size = new Size(159, 15);
            lblPizzaPrice.TabIndex = 20;
            lblPizzaPrice.Text = "($5.95 : Add-Ons $0.50/each)";
            // 
            // lblHamburgerPrice
            // 
            lblHamburgerPrice.AutoSize = true;
            lblHamburgerPrice.Location = new Point(43, 58);
            lblHamburgerPrice.Name = "lblHamburgerPrice";
            lblHamburgerPrice.Size = new Size(159, 15);
            lblHamburgerPrice.TabIndex = 19;
            lblHamburgerPrice.Text = "($6.95 : Add-Ons $0.75/each)";
            // 
            // rbtnDessert
            // 
            rbtnDessert.AutoSize = true;
            rbtnDessert.Location = new Point(222, 216);
            rbtnDessert.Name = "rbtnDessert";
            rbtnDessert.Size = new Size(63, 19);
            rbtnDessert.TabIndex = 7;
            rbtnDessert.TabStop = true;
            rbtnDessert.Text = "Dessert";
            rbtnDessert.UseVisualStyleBackColor = true;
            rbtnDessert.CheckedChanged += OnChanged;
            // 
            // rbtnSteak
            // 
            rbtnSteak.AutoSize = true;
            rbtnSteak.Location = new Point(222, 155);
            rbtnSteak.Name = "rbtnSteak";
            rbtnSteak.Size = new Size(53, 19);
            rbtnSteak.TabIndex = 6;
            rbtnSteak.TabStop = true;
            rbtnSteak.Text = "Steak";
            rbtnSteak.UseVisualStyleBackColor = true;
            rbtnSteak.CheckedChanged += OnChanged;
            // 
            // rbtnSoup
            // 
            rbtnSoup.AutoSize = true;
            rbtnSoup.Location = new Point(222, 93);
            rbtnSoup.Name = "rbtnSoup";
            rbtnSoup.Size = new Size(52, 19);
            rbtnSoup.TabIndex = 5;
            rbtnSoup.TabStop = true;
            rbtnSoup.Text = "Soup";
            rbtnSoup.UseVisualStyleBackColor = true;
            rbtnSoup.CheckedChanged += OnChanged;
            // 
            // rbtnTaco
            // 
            rbtnTaco.AutoSize = true;
            rbtnTaco.Location = new Point(222, 39);
            rbtnTaco.Name = "rbtnTaco";
            rbtnTaco.Size = new Size(49, 19);
            rbtnTaco.TabIndex = 4;
            rbtnTaco.TabStop = true;
            rbtnTaco.Text = "Taco";
            rbtnTaco.UseVisualStyleBackColor = true;
            rbtnTaco.CheckedChanged += OnChanged;
            // 
            // rbtnPasta
            // 
            rbtnPasta.AutoSize = true;
            rbtnPasta.Location = new Point(27, 216);
            rbtnPasta.Name = "rbtnPasta";
            rbtnPasta.Size = new Size(53, 19);
            rbtnPasta.TabIndex = 3;
            rbtnPasta.TabStop = true;
            rbtnPasta.Text = "Pasta";
            rbtnPasta.UseVisualStyleBackColor = true;
            rbtnPasta.CheckedChanged += OnChanged;
            // 
            // rbtnSalad
            // 
            rbtnSalad.AutoSize = true;
            rbtnSalad.Location = new Point(27, 155);
            rbtnSalad.Name = "rbtnSalad";
            rbtnSalad.Size = new Size(53, 19);
            rbtnSalad.TabIndex = 2;
            rbtnSalad.TabStop = true;
            rbtnSalad.Text = "Salad";
            rbtnSalad.UseVisualStyleBackColor = true;
            rbtnSalad.CheckedChanged += OnChanged;
            // 
            // rbtnPizza
            // 
            rbtnPizza.AutoSize = true;
            rbtnPizza.Location = new Point(27, 93);
            rbtnPizza.Name = "rbtnPizza";
            rbtnPizza.Size = new Size(51, 19);
            rbtnPizza.TabIndex = 1;
            rbtnPizza.TabStop = true;
            rbtnPizza.Text = "Pizza";
            rbtnPizza.UseVisualStyleBackColor = true;
            rbtnPizza.CheckedChanged += OnChanged;
            // 
            // rbtnHamburger
            // 
            rbtnHamburger.AutoSize = true;
            rbtnHamburger.Checked = true;
            rbtnHamburger.Location = new Point(27, 39);
            rbtnHamburger.Name = "rbtnHamburger";
            rbtnHamburger.Size = new Size(86, 19);
            rbtnHamburger.TabIndex = 0;
            rbtnHamburger.TabStop = true;
            rbtnHamburger.Text = "Hamburger";
            rbtnHamburger.UseVisualStyleBackColor = true;
            rbtnHamburger.CheckedChanged += OnChanged;
            // 
            // gbxSides
            // 
            gbxSides.Controls.Add(gbxCourseSize);
            gbxSides.Controls.Add(gbxDrinks);
            gbxSides.Controls.Add(gbxAddOns);
            gbxSides.Enabled = false;
            gbxSides.Location = new Point(521, 70);
            gbxSides.Name = "gbxSides";
            gbxSides.Size = new Size(628, 209);
            gbxSides.TabIndex = 1;
            gbxSides.TabStop = false;
            gbxSides.Text = "Sides";
            // 
            // gbxCourseSize
            // 
            gbxCourseSize.Controls.Add(cbxCourseSize);
            gbxCourseSize.Controls.Add(rbtnSmallCourseSize);
            gbxCourseSize.Controls.Add(rbtnLargeCourseSize);
            gbxCourseSize.Controls.Add(rbtnMediumCourseSize);
            gbxCourseSize.Location = new Point(142, 22);
            gbxCourseSize.Name = "gbxCourseSize";
            gbxCourseSize.Size = new Size(163, 170);
            gbxCourseSize.TabIndex = 22;
            gbxCourseSize.TabStop = false;
            // 
            // cbxCourseSize
            // 
            cbxCourseSize.AutoSize = true;
            cbxCourseSize.Location = new Point(6, 22);
            cbxCourseSize.Name = "cbxCourseSize";
            cbxCourseSize.Size = new Size(89, 19);
            cbxCourseSize.TabIndex = 4;
            cbxCourseSize.Text = "French Fries";
            cbxCourseSize.UseVisualStyleBackColor = true;
            cbxCourseSize.CheckedChanged += onAddOnChanged;
            // 
            // rbtnSmallCourseSize
            // 
            rbtnSmallCourseSize.AutoSize = true;
            rbtnSmallCourseSize.Enabled = false;
            rbtnSmallCourseSize.Location = new Point(23, 46);
            rbtnSmallCourseSize.Name = "rbtnSmallCourseSize";
            rbtnSmallCourseSize.Size = new Size(54, 19);
            rbtnSmallCourseSize.TabIndex = 5;
            rbtnSmallCourseSize.TabStop = true;
            rbtnSmallCourseSize.Text = "Small";
            rbtnSmallCourseSize.UseVisualStyleBackColor = true;
            // 
            // rbtnLargeCourseSize
            // 
            rbtnLargeCourseSize.AutoSize = true;
            rbtnLargeCourseSize.Enabled = false;
            rbtnLargeCourseSize.Location = new Point(23, 132);
            rbtnLargeCourseSize.Name = "rbtnLargeCourseSize";
            rbtnLargeCourseSize.Size = new Size(54, 19);
            rbtnLargeCourseSize.TabIndex = 7;
            rbtnLargeCourseSize.TabStop = true;
            rbtnLargeCourseSize.Text = "Large";
            rbtnLargeCourseSize.UseVisualStyleBackColor = true;
            // 
            // rbtnMediumCourseSize
            // 
            rbtnMediumCourseSize.AutoSize = true;
            rbtnMediumCourseSize.Enabled = false;
            rbtnMediumCourseSize.Location = new Point(23, 89);
            rbtnMediumCourseSize.Name = "rbtnMediumCourseSize";
            rbtnMediumCourseSize.Size = new Size(70, 19);
            rbtnMediumCourseSize.TabIndex = 6;
            rbtnMediumCourseSize.TabStop = true;
            rbtnMediumCourseSize.Text = "Medium";
            rbtnMediumCourseSize.UseVisualStyleBackColor = true;
            // 
            // gbxDrinks
            // 
            gbxDrinks.Controls.Add(cbxDrink);
            gbxDrinks.Controls.Add(rbtnSmallDrink);
            gbxDrinks.Controls.Add(rbtnMediumDrink);
            gbxDrinks.Controls.Add(rbtnLargeDrink);
            gbxDrinks.Location = new Point(28, 22);
            gbxDrinks.Name = "gbxDrinks";
            gbxDrinks.Size = new Size(108, 170);
            gbxDrinks.TabIndex = 22;
            gbxDrinks.TabStop = false;
            // 
            // cbxDrink
            // 
            cbxDrink.AutoSize = true;
            cbxDrink.Location = new Point(6, 22);
            cbxDrink.Name = "cbxDrink";
            cbxDrink.Size = new Size(54, 19);
            cbxDrink.TabIndex = 0;
            cbxDrink.Text = "Drink";
            cbxDrink.UseVisualStyleBackColor = true;
            cbxDrink.CheckedChanged += OnDrinkChanged;
            // 
            // rbtnSmallDrink
            // 
            rbtnSmallDrink.AutoSize = true;
            rbtnSmallDrink.Enabled = false;
            rbtnSmallDrink.Location = new Point(19, 47);
            rbtnSmallDrink.Name = "rbtnSmallDrink";
            rbtnSmallDrink.Size = new Size(54, 19);
            rbtnSmallDrink.TabIndex = 1;
            rbtnSmallDrink.TabStop = true;
            rbtnSmallDrink.Text = "Small";
            rbtnSmallDrink.UseVisualStyleBackColor = true;
            // 
            // rbtnMediumDrink
            // 
            rbtnMediumDrink.AutoSize = true;
            rbtnMediumDrink.Enabled = false;
            rbtnMediumDrink.Location = new Point(19, 89);
            rbtnMediumDrink.Name = "rbtnMediumDrink";
            rbtnMediumDrink.Size = new Size(70, 19);
            rbtnMediumDrink.TabIndex = 2;
            rbtnMediumDrink.TabStop = true;
            rbtnMediumDrink.Text = "Medium";
            rbtnMediumDrink.UseVisualStyleBackColor = true;
            // 
            // rbtnLargeDrink
            // 
            rbtnLargeDrink.AutoSize = true;
            rbtnLargeDrink.Enabled = false;
            rbtnLargeDrink.Location = new Point(19, 132);
            rbtnLargeDrink.Name = "rbtnLargeDrink";
            rbtnLargeDrink.Size = new Size(54, 19);
            rbtnLargeDrink.TabIndex = 3;
            rbtnLargeDrink.TabStop = true;
            rbtnLargeDrink.Text = "Large";
            rbtnLargeDrink.UseVisualStyleBackColor = true;
            // 
            // gbxAddOns
            // 
            gbxAddOns.Controls.Add(cbxAddOn8);
            gbxAddOns.Controls.Add(cbxAddOn7);
            gbxAddOns.Controls.Add(cbxAddOn6);
            gbxAddOns.Controls.Add(cbxAddOn5);
            gbxAddOns.Controls.Add(cbxAddOn4);
            gbxAddOns.Controls.Add(cbxAddOn3);
            gbxAddOns.Controls.Add(cbxAddOn2);
            gbxAddOns.Controls.Add(cbxAddOn1);
            gbxAddOns.Location = new Point(313, 20);
            gbxAddOns.Name = "gbxAddOns";
            gbxAddOns.Size = new Size(294, 172);
            gbxAddOns.TabIndex = 8;
            gbxAddOns.TabStop = false;
            gbxAddOns.Text = "Add-Ons";
            // 
            // cbxAddOn8
            // 
            cbxAddOn8.AutoSize = true;
            cbxAddOn8.Location = new Point(177, 135);
            cbxAddOn8.Name = "cbxAddOn8";
            cbxAddOn8.Size = new Size(64, 19);
            cbxAddOn8.TabIndex = 7;
            cbxAddOn8.Text = "Cheese";
            cbxAddOn8.UseVisualStyleBackColor = true;
            // 
            // cbxAddOn7
            // 
            cbxAddOn7.AutoSize = true;
            cbxAddOn7.Location = new Point(177, 98);
            cbxAddOn7.Name = "cbxAddOn7";
            cbxAddOn7.Size = new Size(62, 19);
            cbxAddOn7.TabIndex = 6;
            cbxAddOn7.Text = "Pickles";
            cbxAddOn7.UseVisualStyleBackColor = true;
            // 
            // cbxAddOn6
            // 
            cbxAddOn6.AutoSize = true;
            cbxAddOn6.Location = new Point(177, 61);
            cbxAddOn6.Name = "cbxAddOn6";
            cbxAddOn6.Size = new Size(83, 19);
            cbxAddOn6.TabIndex = 5;
            cbxAddOn6.Text = "Mayonaise";
            cbxAddOn6.UseVisualStyleBackColor = true;
            // 
            // cbxAddOn5
            // 
            cbxAddOn5.AutoSize = true;
            cbxAddOn5.Location = new Point(177, 22);
            cbxAddOn5.Name = "cbxAddOn5";
            cbxAddOn5.Size = new Size(70, 19);
            cbxAddOn5.TabIndex = 4;
            cbxAddOn5.Text = "Mustard";
            cbxAddOn5.UseVisualStyleBackColor = true;
            // 
            // cbxAddOn4
            // 
            cbxAddOn4.AutoSize = true;
            cbxAddOn4.Location = new Point(33, 135);
            cbxAddOn4.Name = "cbxAddOn4";
            cbxAddOn4.Size = new Size(70, 19);
            cbxAddOn4.TabIndex = 3;
            cbxAddOn4.Text = "Ketchup";
            cbxAddOn4.UseVisualStyleBackColor = true;
            // 
            // cbxAddOn3
            // 
            cbxAddOn3.AutoSize = true;
            cbxAddOn3.Location = new Point(33, 98);
            cbxAddOn3.Name = "cbxAddOn3";
            cbxAddOn3.Size = new Size(59, 19);
            cbxAddOn3.TabIndex = 2;
            cbxAddOn3.Text = "Onion";
            cbxAddOn3.UseVisualStyleBackColor = true;
            // 
            // cbxAddOn2
            // 
            cbxAddOn2.AutoSize = true;
            cbxAddOn2.Location = new Point(33, 61);
            cbxAddOn2.Name = "cbxAddOn2";
            cbxAddOn2.Size = new Size(66, 19);
            cbxAddOn2.TabIndex = 1;
            cbxAddOn2.Text = "Tomato";
            cbxAddOn2.UseVisualStyleBackColor = true;
            // 
            // cbxAddOn1
            // 
            cbxAddOn1.AutoSize = true;
            cbxAddOn1.Location = new Point(33, 22);
            cbxAddOn1.Name = "cbxAddOn1";
            cbxAddOn1.Size = new Size(65, 19);
            cbxAddOn1.TabIndex = 0;
            cbxAddOn1.Text = "Lettuce";
            cbxAddOn1.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(271, 15);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(108, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add to Order";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btn_Add_To_Order;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(6, 15);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 23);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear Food Selection";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btn_Clear_Food_Selection;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(8, 44);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 6;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(56, 41);
            txtName.Name = "txtName";
            txtName.Size = new Size(139, 23);
            txtName.TabIndex = 7;
            // 
            // lblBudget
            // 
            lblBudget.AutoSize = true;
            lblBudget.Location = new Point(16, 32);
            lblBudget.Name = "lblBudget";
            lblBudget.Size = new Size(48, 15);
            lblBudget.TabIndex = 8;
            lblBudget.Text = "Budget:";
            // 
            // txtBudget
            // 
            txtBudget.Location = new Point(69, 29);
            txtBudget.Name = "txtBudget";
            txtBudget.Size = new Size(133, 23);
            txtBudget.TabIndex = 9;
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Location = new Point(27, 78);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(35, 15);
            lblCost.TabIndex = 10;
            lblCost.Text = "Total:";
            // 
            // txtOrderTotal
            // 
            txtOrderTotal.Location = new Point(68, 75);
            txtOrderTotal.Name = "txtOrderTotal";
            txtOrderTotal.ReadOnly = true;
            txtOrderTotal.Size = new Size(142, 23);
            txtOrderTotal.TabIndex = 11;
            // 
            // gbxPickup
            // 
            gbxPickup.Controls.Add(lblPickupDate);
            gbxPickup.Controls.Add(dateTimePicker);
            gbxPickup.Controls.Add(lblPickupTime);
            gbxPickup.Controls.Add(lblOrderType);
            gbxPickup.Controls.Add(rbtnOnline);
            gbxPickup.Controls.Add(rbtnTakeout);
            gbxPickup.Controls.Add(rbtnDineIn);
            gbxPickup.Location = new Point(27, 128);
            gbxPickup.Name = "gbxPickup";
            gbxPickup.Size = new Size(346, 149);
            gbxPickup.TabIndex = 12;
            gbxPickup.TabStop = false;
            // 
            // lblPickupDate
            // 
            lblPickupDate.AutoSize = true;
            lblPickupDate.Location = new Point(99, 66);
            lblPickupDate.Name = "lblPickupDate";
            lblPickupDate.Size = new Size(34, 15);
            lblPickupDate.TabIndex = 6;
            lblPickupDate.Text = "Date:";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Format = DateTimePickerFormat.Time;
            dateTimePicker.Location = new Point(139, 60);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.ShowUpDown = true;
            dateTimePicker.Size = new Size(200, 23);
            dateTimePicker.TabIndex = 5;
            dateTimePicker.Value = new DateTime(2024, 12, 2, 6, 47, 0, 0);
            // 
            // lblPickupTime
            // 
            lblPickupTime.AutoSize = true;
            lblPickupTime.Location = new Point(177, 31);
            lblPickupTime.Name = "lblPickupTime";
            lblPickupTime.Size = new Size(75, 15);
            lblPickupTime.TabIndex = 4;
            lblPickupTime.Text = "Pickup Time:";
            // 
            // lblOrderType
            // 
            lblOrderType.AutoSize = true;
            lblOrderType.Location = new Point(6, 31);
            lblOrderType.Name = "lblOrderType";
            lblOrderType.Size = new Size(67, 15);
            lblOrderType.TabIndex = 3;
            lblOrderType.Text = "Order Type:";
            // 
            // rbtnOnline
            // 
            rbtnOnline.AutoSize = true;
            rbtnOnline.Location = new Point(6, 110);
            rbtnOnline.Name = "rbtnOnline";
            rbtnOnline.Size = new Size(60, 19);
            rbtnOnline.TabIndex = 2;
            rbtnOnline.TabStop = true;
            rbtnOnline.Text = "Online";
            rbtnOnline.UseVisualStyleBackColor = true;
            // 
            // rbtnTakeout
            // 
            rbtnTakeout.AutoSize = true;
            rbtnTakeout.Location = new Point(6, 85);
            rbtnTakeout.Name = "rbtnTakeout";
            rbtnTakeout.Size = new Size(66, 19);
            rbtnTakeout.TabIndex = 1;
            rbtnTakeout.TabStop = true;
            rbtnTakeout.Text = "Takeout";
            rbtnTakeout.UseVisualStyleBackColor = true;
            // 
            // rbtnDineIn
            // 
            rbtnDineIn.AutoSize = true;
            rbtnDineIn.Location = new Point(6, 60);
            rbtnDineIn.Name = "rbtnDineIn";
            rbtnDineIn.Size = new Size(62, 19);
            rbtnDineIn.TabIndex = 0;
            rbtnDineIn.TabStop = true;
            rbtnDineIn.Text = "Dine In";
            rbtnDineIn.UseVisualStyleBackColor = true;
            // 
            // btnComplete
            // 
            btnComplete.Location = new Point(16, 292);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(171, 27);
            btnComplete.TabIndex = 13;
            btnComplete.Text = "Complete Order Payment";
            btnComplete.UseVisualStyleBackColor = true;
            btnComplete.Click += btn_Complete_Order_Payment;
            // 
            // cmbobxOrderPicker
            // 
            cmbobxOrderPicker.FormattingEnabled = true;
            cmbobxOrderPicker.Location = new Point(142, 54);
            cmbobxOrderPicker.Name = "cmbobxOrderPicker";
            cmbobxOrderPicker.Size = new Size(163, 23);
            cmbobxOrderPicker.TabIndex = 16;
            cmbobxOrderPicker.Text = "<Order>";
            cmbobxOrderPicker.SelectedValueChanged += OnCustomerComboBoxChange;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(8, 15);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(187, 23);
            btnCreate.TabIndex = 18;
            btnCreate.Text = "Create New Order";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btn_Create_Order;
            // 
            // btnPay
            // 
            btnPay.Location = new Point(252, 263);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(115, 21);
            btnPay.TabIndex = 19;
            btnPay.Text = "Pay For Order";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btn_Pay_For_Order;
            // 
            // gbxPaymentInformation
            // 
            gbxPaymentInformation.Controls.Add(lblBudget);
            gbxPaymentInformation.Controls.Add(txtBudget);
            gbxPaymentInformation.Controls.Add(lblCost);
            gbxPaymentInformation.Controls.Add(txtOrderTotal);
            gbxPaymentInformation.Controls.Add(btnComplete);
            gbxPaymentInformation.Controls.Add(gbxPickup);
            gbxPaymentInformation.Enabled = false;
            gbxPaymentInformation.Location = new Point(85, 345);
            gbxPaymentInformation.Name = "gbxPaymentInformation";
            gbxPaymentInformation.Size = new Size(410, 337);
            gbxPaymentInformation.TabIndex = 20;
            gbxPaymentInformation.TabStop = false;
            gbxPaymentInformation.Text = "Payment Information";
            // 
            // gbxCreateOrderButton
            // 
            gbxCreateOrderButton.Controls.Add(lblName);
            gbxCreateOrderButton.Controls.Add(btnCreate);
            gbxCreateOrderButton.Controls.Add(txtName);
            gbxCreateOrderButton.Location = new Point(521, 301);
            gbxCreateOrderButton.Name = "gbxCreateOrderButton";
            gbxCreateOrderButton.Size = new Size(209, 67);
            gbxCreateOrderButton.TabIndex = 21;
            gbxCreateOrderButton.TabStop = false;
            // 
            // lblChooseCustomer
            // 
            lblChooseCustomer.AutoSize = true;
            lblChooseCustomer.Location = new Point(61, 57);
            lblChooseCustomer.Name = "lblChooseCustomer";
            lblChooseCustomer.Size = new Size(75, 15);
            lblChooseCustomer.TabIndex = 22;
            lblChooseCustomer.Text = "Order Name:";
            // 
            // lblComboNumber
            // 
            lblComboNumber.AutoSize = true;
            lblComboNumber.Location = new Point(328, 57);
            lblComboNumber.Name = "lblComboNumber";
            lblComboNumber.Size = new Size(97, 15);
            lblComboNumber.TabIndex = 23;
            lblComboNumber.Text = "Combo Number:";
            // 
            // cmbobxComboPicker
            // 
            cmbobxComboPicker.FormattingEnabled = true;
            cmbobxComboPicker.Location = new Point(431, 54);
            cmbobxComboPicker.Name = "cmbobxComboPicker";
            cmbobxComboPicker.Size = new Size(163, 23);
            cmbobxComboPicker.TabIndex = 24;
            cmbobxComboPicker.Text = "<Combo>";
            cmbobxComboPicker.SelectedIndexChanged += OnComboNumberComboBoxChanged;
            // 
            // lblFullOrder
            // 
            lblFullOrder.AutoSize = true;
            lblFullOrder.Location = new Point(271, 130);
            lblFullOrder.Name = "lblFullOrder";
            lblFullOrder.Size = new Size(62, 15);
            lblFullOrder.TabIndex = 25;
            lblFullOrder.Text = "Full Order:";
            // 
            // rtxtFullOrder
            // 
            rtxtFullOrder.Location = new Point(87, 158);
            rtxtFullOrder.Name = "rtxtFullOrder";
            rtxtFullOrder.Size = new Size(465, 86);
            rtxtFullOrder.TabIndex = 26;
            rtxtFullOrder.Text = "";
            // 
            // gbxFoodSelectionButtons
            // 
            gbxFoodSelectionButtons.Controls.Add(btnClear);
            gbxFoodSelectionButtons.Controls.Add(btnAdd);
            gbxFoodSelectionButtons.Enabled = false;
            gbxFoodSelectionButtons.Location = new Point(736, 301);
            gbxFoodSelectionButtons.Name = "gbxFoodSelectionButtons";
            gbxFoodSelectionButtons.Size = new Size(392, 49);
            gbxFoodSelectionButtons.TabIndex = 28;
            gbxFoodSelectionButtons.TabStop = false;
            // 
            // gbxViewOrderDetails
            // 
            gbxViewOrderDetails.Controls.Add(rtxtFullOrder);
            gbxViewOrderDetails.Controls.Add(btnPay);
            gbxViewOrderDetails.Controls.Add(cmbobxComboPicker);
            gbxViewOrderDetails.Controls.Add(lblFullOrder);
            gbxViewOrderDetails.Controls.Add(lblComboNumber);
            gbxViewOrderDetails.Controls.Add(lblChooseCustomer);
            gbxViewOrderDetails.Controls.Add(cmbobxOrderPicker);
            gbxViewOrderDetails.Enabled = false;
            gbxViewOrderDetails.Location = new Point(521, 374);
            gbxViewOrderDetails.Name = "gbxViewOrderDetails";
            gbxViewOrderDetails.Size = new Size(628, 308);
            gbxViewOrderDetails.TabIndex = 29;
            gbxViewOrderDetails.TabStop = false;
            gbxViewOrderDetails.Text = "Vew Order Details";
            // 
            // frmOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 690);
            Controls.Add(gbxViewOrderDetails);
            Controls.Add(gbxFoodSelectionButtons);
            Controls.Add(gbxCreateOrderButton);
            Controls.Add(gbxPaymentInformation);
            Controls.Add(gbxSides);
            Controls.Add(gbxCourses);
            Name = "frmOrder";
            Text = "Restaurant Order Application";
            gbxCourses.ResumeLayout(false);
            gbxCourses.PerformLayout();
            gbxSides.ResumeLayout(false);
            gbxCourseSize.ResumeLayout(false);
            gbxCourseSize.PerformLayout();
            gbxDrinks.ResumeLayout(false);
            gbxDrinks.PerformLayout();
            gbxAddOns.ResumeLayout(false);
            gbxAddOns.PerformLayout();
            gbxPickup.ResumeLayout(false);
            gbxPickup.PerformLayout();
            gbxPaymentInformation.ResumeLayout(false);
            gbxPaymentInformation.PerformLayout();
            gbxCreateOrderButton.ResumeLayout(false);
            gbxCreateOrderButton.PerformLayout();
            gbxFoodSelectionButtons.ResumeLayout(false);
            gbxViewOrderDetails.ResumeLayout(false);
            gbxViewOrderDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxCourses;
        private GroupBox gbxSides;
        private Button btnAdd;
        private Button btnClear;
        private Label lblName;
        private TextBox txtName;
        private Label lblBudget;
        private TextBox txtBudget;
        private Label lblCost;
        private TextBox txtOrderTotal;
        private GroupBox gbxPickup;
        private RadioButton rbtnDineIn;
        private RadioButton rbtnTakeout;
        private Label lblOrderType;
        private RadioButton rbtnOnline;
        private Label lblPickupDate;
        private DateTimePicker dateTimePicker;
        private Label lblPickupTime;
        private Button btnComplete;
        private ComboBox cmbobxOrderPicker;
        private RadioButton rbtnDessert;
        private RadioButton rbtnSteak;
        private RadioButton rbtnSoup;
        private RadioButton rbtnTaco;
        private RadioButton rbtnPasta;
        private RadioButton rbtnSalad;
        private RadioButton rbtnPizza;
        private RadioButton rbtnHamburger;
        private RadioButton rbtnSmallDrink;
        private CheckBox cbxDrink;
        private Button btnCreate;
        private GroupBox gbxAddOns;
        private CheckBox cbxAddOn8;
        private CheckBox cbxAddOn7;
        private CheckBox cbxAddOn6;
        private CheckBox cbxAddOn5;
        private CheckBox cbxAddOn4;
        private CheckBox cbxAddOn3;
        private CheckBox cbxAddOn2;
        private CheckBox cbxAddOn1;
        private RadioButton rbtnLargeCourseSize;
        private RadioButton rbtnMediumCourseSize;
        private RadioButton rbtnSmallCourseSize;
        private CheckBox cbxCourseSize;
        private RadioButton rbtnLargeDrink;
        private RadioButton rbtnMediumDrink;
        private Label lblPizzaPrice;
        private Label lblHamburgerPrice;
        private Label lblSaladPrice;
        private Button btnPay;
        private GroupBox gbxPaymentInformation;
        private GroupBox gbxCreateOrderButton;
        private Label lblDessertPrice;
        private Label lblSteakPrice;
        private Label lblSoupPrice;
        private Label lblTacoPrice;
        private Label lblPastaPrice;
        private GroupBox gbxDrinks;
        private GroupBox gbxCourseSize;
        private Label lblChooseCustomer;
        private Label lblComboNumber;
        private ComboBox cmbobxComboPicker;
        private Label lblFullOrder;
        private RichTextBox rtxtFullOrder;
        private GroupBox gbxFoodSelectionButtons;
        private GroupBox gbxViewOrderDetails;
    }
}