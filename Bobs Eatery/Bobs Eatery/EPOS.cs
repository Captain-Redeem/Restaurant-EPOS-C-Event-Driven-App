using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bobs_Eatery
{
    public partial class EPOS : Form


    {//Create a open variable which will keep the live total value of the items.
        decimal total = 0;

        //Create a dictionary to store the names and prices of items.

        IDictionary<string, decimal> dict = new Dictionary<string, decimal>();

        public EPOS()
        {
            InitializeComponent();
            
            //Dictionary for Pizzas
            dict.Add("Pepperoni", 7.00m);
            dict.Add("Ham & Pineapple", 8.00m);
            dict.Add("Just Cheese", 3.60m);
            dict.Add("Meat Feast", 8.00m);
            dict.Add("Veggie Deluxe", 6.60m);
            dict.Add("Hot Hot Hot", 8.80m);
            dict.Add("Chicken and Sweetcorn", 8.90m);
            dict.Add("Just Chicken", 7.00m);
            dict.Add("Mushroom Pizza", 6.60m);
            dict.Add("Donner Pizza", 8.00m);
            dict.Add("BBQ Chicken Pizza", 6.00m);

            //Dictionary for Sides
            dict.Add("Green Salad", 2.00m);
                dict.Add("Coleslaw", 2.00m);
                dict.Add("Cheesy Chips", 3.00m);
                dict.Add("Dirty Fries", 4.00m);
            dict.Add("Mozzarella", 5.00m);
            dict.Add("Fries", 2.00m);


            //dictionary for desserts
            dict.Add("Chocolate Icecream", 3.00m);
            dict.Add("Strawberry Icecream", 3.00m);
            dict.Add("Cheesecake", 4.00m);
            dict.Add("Cookies", 3.00m);
            dict.Add("Chocolate Cake", 3.00m);


            //dictionary for burgers
            dict.Add("Plain Burger", 4.10m);
            dict.Add("Garlic Burger", 4.30m);
            dict.Add("Cheese Burger", 4.20m);
            dict.Add("American Deluxe Burger", 4.50m);
            dict.Add("Supreme Burger", 4.30m);
            dict.Add("Bob's Special", 4.90m);
            dict.Add("Veggie Burger", 3.80m);
            dict.Add("Italiano Burger", 4.10m);
            dict.Add("Halloumi Burger", 3.00m);


            //Dictionary for deals
            dict.Add("Pizza deal for 1", 9.00m);
            dict.Add("Family Deal", 25.00m);
            dict.Add("Burger Deal", 12.00m);
            dict.Add("Bob's Mystery", 27.00m);

            //Dictionary for drinks
            dict.Add("Diet Coke", 1.75m);
            dict.Add("Tango", 1.75m);
            dict.Add("Pepsi Max", 1.75m);
            dict.Add("Fruit Shoot", 1.50m);
            dict.Add("Orange Juice", 2.00m);
            dict.Add("Apple Juice", 2.00m);





        }

        private void btnPepperoni_Click(object sender, EventArgs e)
        {
            //Show the selected item in the listbox.
            lstOrder.Items.Add("Pepperoni Pizza");

            //Add the price of the item to the relevant variable.
            total = total + dict["Pepperoni"];

            //The contents of the total variable will be shown on the label. 
            lblSubtotal.Text = total.ToString();
        }

        private void btnHamandPineapple_Click(object sender, EventArgs e)
        {
            //Show the selected item in the listbox.
            lstOrder.Items.Add("Ham and Pineapple Pizza");

            //Add the price of the item to the relevant variable.
            total = total + dict["Ham & Pineapple"];

            //The contents of the total variable will be shown on the label. 
            lblSubtotal.Text = total.ToString();
        }

        private void btnJustCheese_Click(object sender, EventArgs e)
        {
            //Show the selected item in the listbox.
            lstOrder.Items.Add("Just Cheese Pizza");

            //Add the price of the item to the relevant variable.
            total = total + dict["Just Cheese"];

            //The contents of the total variable will be shown on the label. 
            lblSubtotal.Text = total.ToString();
        }

        private void btnMeatFeast_Click(object sender, EventArgs e)
        {
            //Show the selected item in the listbox.
            lstOrder.Items.Add("Meat Feast Pizza");

            //Add the price of the item to the relevant variable.
            total = total + dict["Meat Feast"];

            //The contents of the total variable will be shown on the label. 
            lblSubtotal.Text = total.ToString();
        }

        private void btnVeggieDeluxe_Click(object sender, EventArgs e)
        {
            //Show the selected item in the listbox.
            lstOrder.Items.Add("Veggie Deluxe Pizza");

            //Add the price of the item to the relevant variable.
            total = total + dict["Veggie Deluxe"];

            //The contents of the total variable will be shown on the label. 
            lblSubtotal.Text = total.ToString();
        }

        private void btnHotHotHot_Click(object sender, EventArgs e)
        {
            //Show the selected item in the listbox.
            lstOrder.Items.Add("Hot Hot Hot Pizza");

            //Add the price of the item to the relevant variable.
            total = total + dict["Hot Hot Hot"];

            //The contents of the total variable will be shown on the label. 
            lblSubtotal.Text = total.ToString();
        }

        private void btnChickenandSweetcorn_Click(object sender, EventArgs e)
        {
            //Show the selected item in the listbox.
            lstOrder.Items.Add("Chicken and Sweetcorn Pizza");

            //Add the price of the item to the relevant variable.
            total = total + dict["Chicken and Sweetcorn"];

            //The contents of the total variable will be shown on the label. 
            lblSubtotal.Text = total.ToString();
        }

        private void btnJustChicken_Click(object sender, EventArgs e)
        {
            //Show the selected item in the listbox.
            lstOrder.Items.Add("Just Chicken Pizza");

            //Add the price of the item to the relevant variable.
            total = total + dict["Just Chicken"];

            //The contents of the total variable will be shown on the label. 
            lblSubtotal.Text = total.ToString();
        }

        private void btnMushroomPizza_Click(object sender, EventArgs e)
        {
            //Show the selected item in the listbox.
            lstOrder.Items.Add("Mushroom Pizza (V)");

            //Add the price of the item to the relevant variable.
            total = total + dict["Mushroom Pizza"];

            //The contents of the total variable will be shown on the label. 
            lblSubtotal.Text = total.ToString();
        }

        private void btnDonnerPizza_Click(object sender, EventArgs e)
        {
            //Show the selected item in the listbox.
            lstOrder.Items.Add("Donner Pizza");

            //Add the price of the item to the relevant variable.
            total = total + dict["Donner Pizza"];

            //The contents of the total variable will be shown on the label. 
            lblSubtotal.Text = total.ToString();
        }

        private void btnBBQChicken_Click(object sender, EventArgs e)
        {
            //Show the selected item in the listbox.
            lstOrder.Items.Add("BBQ Chicken Pizza");

            //Add the price of the item to the relevant variable.
            total = total + dict["BBQ Chicken Pizza"];

            //The contents of the total variable will be shown on the label. 
            lblSubtotal.Text = total.ToString();
        }

        private void btnGreensalad_Click(object sender, EventArgs e)
        {
            //Show the selected item in the listbox.
            lstOrder.Items.Add("Green Salad");

            //Add the price of the item to the relevant variable.
            total = total + dict["Green Salad"];

            //The contents of the total variable will be shown on the label. 
            lblSubtotal.Text = total.ToString();
        }

        private void btnColeslaw_Click(object sender, EventArgs e)
        {
            //Show the selected item in the listbox.
            lstOrder.Items.Add("Coleslaw");

            //Add the price of the item to the relevant variable.
            total = total + dict["Coleslaw"];

            //The contents of the total variable will be shown on the label. 
            lblSubtotal.Text = total.ToString();
        }

        private void btnCheesychips_Click(object sender, EventArgs e)
        {
            //Show the selected item in the listbox.
            lstOrder.Items.Add("Cheesy Chips");

            //Add the price of the item to the relevant variable.
            total = total + dict["Cheesy Chips"];

            //The contents of the total variable will be shown on the label. 
            lblSubtotal.Text = total.ToString();
        }

        private void btnDirtyfries_Click(object sender, EventArgs e)
        {
            //Show the selected item in the listbox.
            lstOrder.Items.Add("Dirty Fries");

            //Add the price of the item to the relevant variable.
            total = total + dict["Dirty Fries"];

            //The contents of the total variable will be shown on the label. 
            lblSubtotal.Text = total.ToString();
        }

        private void btnMozzerellasticks_Click(object sender, EventArgs e)
        {
            //Show the selected item in the listbox.
            lstOrder.Items.Add("Mozzarella stick(V)");

            //Add the price of the item to the relevant variable.
            total = total + dict["Mozzarella"];

            //The contents of the total variable will be shown on the label. 
            lblSubtotal.Text = total.ToString();
        }

        private void btnFries_Click(object sender, EventArgs e)
        {
            //Show the selected item in the listbox.
            lstOrder.Items.Add("Fries");

            //Add the price of the item to the relevant variable.
            total = total + dict["Fries"];

            //The contents of the total variable will be shown on the label. 
            lblSubtotal.Text = total.ToString();
        }

        private void btnPlainburger_Click(object sender, EventArgs e)
        {
            //Show the selected item in the listbox.
            lstOrder.Items.Add("Plain Burger");

            //Add the price of the item to the relevant variable.
            total = total + dict["Plain Burger"];

            //The contents of the total variable will be shown on the label. 
            lblSubtotal.Text = total.ToString();
        }

        private void btnGarlicburger_Click(object sender, EventArgs e)
        {
            //Show the selected item in the listbox.
            lstOrder.Items.Add("Garlic Burger");

            //Add the price of the item to the relevant variable.
            total = total + dict["Garlic Burger"];

            //The contents of the total variable will be shown on the label. 
            lblSubtotal.Text = total.ToString();
        }

        private void btnCheeseburger_Click(object sender, EventArgs e)
        {
            //Show the selected item in the listbox.
            lstOrder.Items.Add("Cheese Burger");

            //Add the price of the item to the relevant variable.
            total = total + dict["Cheese Burger"];

            //The contents of the total variable will be shown on the label. 
            lblSubtotal.Text = total.ToString();
        }

        private void btnAmericancheeseburger_Click(object sender, EventArgs e)
        {
            //Show the selected item in the listbox.
            lstOrder.Items.Add("American Deluxe Burger");

            //Add the price of the item to the relevant variable.
            total = total + dict["American Deluxe Burger"];

            //The contents of the total variable will be shown on the label. 
            lblSubtotal.Text = total.ToString();
        }

        private void btnSupremeburger_Click(object sender, EventArgs e)
        {
            //Show the selected item in the listbox.
            lstOrder.Items.Add("Supreme Burger");

            //Add the price of the item to the relevant variable.
            total = total + dict["Supreme Burger"];

            //The contents of the total variable will be shown on the label. 
            lblSubtotal.Text = total.ToString();
        }

        private void btnBobsspecial_Click(object sender, EventArgs e)
        {
            //Show the selected item in the listbox.
            lstOrder.Items.Add("Bob's Special");

            //Add the price of the item to the relevant variable.
            total = total + dict["Bob's Special"];

            //The contents of the total variable will be shown on the label. 
            lblSubtotal.Text = total.ToString();
        }

        private void btnVeggieburger_Click(object sender, EventArgs e)
        {
            //Show the selected item in the listbox.
            lstOrder.Items.Add("Veggie Burger");

            //Add the price of the item to the relevant variable.
            total = total + dict["Veggie Burger"];

            //The contents of the total variable will be shown on the label. 
            lblSubtotal.Text = total.ToString();
        }

        private void btnItalianoburger_Click(object sender, EventArgs e)
        {
            //Show the selected item in the listbox.
            lstOrder.Items.Add("Italiano Burger");

            //Add the price of the item to the relevant variable.
            total = total + dict["Italiano Burger"];

            //The contents of the total variable will be shown on the label. 
            lblSubtotal.Text = total.ToString();
        }

        private void btnHalloumiburger_Click(object sender, EventArgs e)
        {
            //Show the selected item in the listbox.
            lstOrder.Items.Add("Halloumi Burger");

            //Add the price of the item to the relevant variable.
            total = total + dict["Halloumi Burger"];

            //The contents of the total variable will be shown on the label. 
            lblSubtotal.Text = total.ToString();
        }

        private void btnDietcoke_Click(object sender, EventArgs e)
        {
            //Show the selected item in the listbox.
            lstOrder.Items.Add("Diet Coke");

            //Add the price of the item to the relevant variable.
            total = total + dict["Diet Coke"];

            //The contents of the total variable will be shown on the label. 
            lblSubtotal.Text = total.ToString();
        }

        private void btnTango_Click(object sender, EventArgs e)
        {
            //Show the selected item in the listbox.
            lstOrder.Items.Add("Tango");

            //Add the price of the item to the relevant variable.
            total = total + dict["Tango"];

            //The contents of the total variable will be shown on the label. 
            lblSubtotal.Text = total.ToString();
        }

        private void btnPepsimax_Click(object sender, EventArgs e)
        {
            //Show the selected item in the listbox.
            lstOrder.Items.Add("Pepsi Max");

            //Add the price of the item to the relevant variable.
            total = total + dict["Pepsi Max"];

            //The contents of the total variable will be shown on the label. 
            lblSubtotal.Text = total.ToString();
        }

        private void btnFruitshoot_Click(object sender, EventArgs e)
        {
            //Show the selected item in the listbox.
            lstOrder.Items.Add("Fruit Shoot");

            //Add the price of the item to the relevant variable.
            total = total + dict["Fruit Shoot"];

            //The contents of the total variable will be shown on the label. 
            lblSubtotal.Text = total.ToString();
        }

        private void btnOrangejuice_Click(object sender, EventArgs e)
        {
            //Show the selected item in the listbox.
            lstOrder.Items.Add("Orange Juice (Fresh)");

            //Add the price of the item to the relevant variable.
            total = total + dict["Orange Juice"];

            //The contents of the total variable will be shown on the label. 
            lblSubtotal.Text = total.ToString();
        }

        private void btnApplejuice_Click(object sender, EventArgs e)
        {
            //Show the selected item in the listbox.
            lstOrder.Items.Add("Apple Juice (fresh)");

            //Add the price of the item to the relevant variable.
            total = total + dict["Apple Juice"];

            //The contents of the total variable will be shown on the label. 
            lblSubtotal.Text = total.ToString();
        }

        private void btnPizzadeal_Click(object sender, EventArgs e)
        {
            //Show the selected item in the listbox.
            lstOrder.Items.Add("Pizza deal for 1");

            //Add the price of the item to the relevant variable.
            total = total + dict["Pizza deal for 1"];

            //The contents of the total variable will be shown on the label. 
            lblSubtotal.Text = total.ToString();
        }

        private void btnFamilydeal_Click(object sender, EventArgs e)
        {
            //Show the selected item in the listbox.
            lstOrder.Items.Add("Family Deal");

            //Add the price of the item to the relevant variable.
            total = total + dict["Family Deal"];

            //The contents of the total variable will be shown on the label. 
            lblSubtotal.Text = total.ToString();
        }

        private void btnBurgerdeal_Click(object sender, EventArgs e)
        {
            //Show the selected item in the listbox.
            lstOrder.Items.Add("Burger Deal");

            //Add the price of the item to the relevant variable.
            total = total + dict["Burger Deal"];

            //The contents of the total variable will be shown on the label. 
            lblSubtotal.Text = total.ToString();
        }

        private void btnBobsmystery_Click(object sender, EventArgs e)
        {
            //Show the selected item in the listbox.
            lstOrder.Items.Add("Bob's Mystery");

            //Add the price of the item to the relevant variable.
            total = total + dict["Bob's Mystery"];

            //The contents of the total variable will be shown on the label. 
            lblSubtotal.Text = total.ToString();
        }

        private void EPOS_Load(object sender, EventArgs e)
        {

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            CalculateDiscount();
        }

        //Make a new object to calculate the total cost.
        private void CalculateDiscount()
        {
            //Make a variable to store the total cost.
            decimal newTotal;

            //Make an IF statement for the Discount (radio buttons).
            //Adding the calculations for the no discount radio button.
            if (radNodiscount.Checked)
            {
                //There will be no price cut if there is no discounts added to the order.
                newTotal = total;
                lblDiscount.Text = "No discount";
            }

                //Make an else if statement for the employee discount to add to the total price.
            else if (radEmployeediscount.Checked)
                    {
                lblDiscount.Text = (total * 0.25m).ToString();
                newTotal = total - (total * 0.25m);
                    }

            //Else statement for the student discount to reduce 10% from the total price.
            else
            {
                lblDiscount.Text = (total * 0.1m).ToString();
                newTotal = total - (total * 0.1m);
            }


            decimal VAT = 0;

            //calculate the VAT by dividing the (subtotal) total variable by the value of the VAT (which is 20%).
            VAT = total * 0.2m;

            lblVAT.Text = VAT.ToString();

            lblTotal.Text = (newTotal + VAT).ToString();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //make the data disappear upon clicking "log out".
            this.Hide();

            frmLogin f2 = new frmLogin();

            //to show a new log in form.
            f2.ShowDialog();
        }

        private void btnClearitem_Click(object sender, EventArgs e)
        {
            Object Selected = lstOrder.SelectedItem;
            lstOrder.Items.Remove(Selected);

            //change the price.
            total -= dict[Selected.ToString()];
            lblTotal.Text = total.ToString();

            CalculateDiscount();
        }

        private void btnClearall_Click(object sender, EventArgs e)
        {
            //clear all data from the subtotal, total, discount, VAT labels and the order listbox.
            lstOrder.Items.Clear();
            total = 0;
            lblDiscount.Text = "";
            lblTotal.Text = "";
            lblSubtotal.Text = "";
            lblVAT.Text = "";
        }

        private void btnChocolateicecream_Click(object sender, EventArgs e)
        {
            //Show the selected item in the listbox.
            lstOrder.Items.Add("Chocolate Icecream");

            //Add the price of the item to the relevant variable.
            total = total + dict["Chocolate Icecream"];

            //The contents of the total variable will be shown on the label. 
            lblSubtotal.Text = total.ToString();
        }

        private void btnStrawberryicecream_Click(object sender, EventArgs e)
        {
            //Show the selected item in the listbox.
            lstOrder.Items.Add("Strawberry icecream");

            //Add the price of the item to the relevant variable.
            total = total + dict["Strawberry Icecream"];

            //The contents of the total variable will be shown on the label. 
            lblSubtotal.Text = total.ToString();
        }

        private void btnCheesecake_Click(object sender, EventArgs e)
        {
            //Show the selected item in the listbox.
            lstOrder.Items.Add("Cheesecake");

            //Add the price of the item to the relevant variable.
            total = total + dict["Cheesecake"];

            //The contents of the total variable will be shown on the label. 
            lblSubtotal.Text = total.ToString();
        }

        private void btnCookies_Click(object sender, EventArgs e)
        {
            //Show the selected item in the listbox.
            lstOrder.Items.Add("Cookies");

            //Add the price of the item to the relevant variable.
            total = total + dict["Cookies"];

            //The contents of the total variable will be shown on the label. 
            lblSubtotal.Text = total.ToString();
        }

        private void btnChocolatecake_Click(object sender, EventArgs e)
        {
            //Show the selected item in the listbox.
            lstOrder.Items.Add("Chocolate cake");

            //Add the price of the item to the relevant variable.
            total = total + dict["Chocolate Cake"];

            //The contents of the total variable will be shown on the label. 
            lblSubtotal.Text = total.ToString();
        }

        private void btnHowtodelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please click on an item you would like to remove, then click on the Clear item button to remove that item. You can also remove all items at once by clicking the clear all items button.", "How to delete an item");
        }

        private void btnHowtoadd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please click on an item to add it to the order list.", "How to add an item");
        }

        private void btnHowtochangequantity_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you would like to increase the quantity of an item, please select that item again. If you would like to reduce the quantity of an item, please remove the item from the order list by clicking on it and then clicking on clear item button.", "How to change quantity");
        }

        private void btmHowtodiscount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please click on a Discount radio button to apply any customer prefered discount. NOTE: Only one discount can be applied per order.", "How to add discount");
        }

        private void btnSystemrequirements_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OS: Windows 7 or later - 32-bit, RAM: 2GB, Storage: 30GB, Video memory: 1GB, Processor: 1.00GHz.", "Minimum specs requirements");
        }
    }
}
