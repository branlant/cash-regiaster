using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cash_regiaster
{
    public partial class Form1 : Form
    {
        //global variables
        double BurgerPrice = 1.89;
        double DrinkPrice = 2.49;
        double FriesPrice = 1.49;
        int numOfBurger = 0;
        int numOfDrink = 0;
        int numOfFries = 0;
        double taxRate = .13;
        double subtotal = 0;
        double taxAmount = 0;
        double totalPrice = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void calculateButton_Click_1(object sender, EventArgs e)
        {
            //get inputs
            numOfBurger = Convert.ToInt16(BurgerInput.Text);
            numOfDrink = Convert.ToInt16(DrinkInput.Text);
            numOfFries = Convert.ToInt16(FriesInput.Text);


            //do calculations
            subtotal = BurgerPrice * numOfBurger + DrinkPrice * numOfDrink + FriesPrice * numOfFries;
            taxAmount = subtotal * taxRate;
            totalPrice = subtotal - taxAmount;


            //show outputs
            subTotalOutput.Text = $"{subtotal.ToString("C")}";
            taxOutput.Text = $"{taxAmount.ToString("C")}";
            totalOutput.Text = $"{totalPrice.ToString("C")}";
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            receiptLabel.Text = "Thank You For Coming To FunBurger!";
            receiptLabel.Text += "\n-------------------------------------------------------------";
            receiptLabel.Text += $"\n Burgers  x{numOfBurger}";
            receiptLabel.Text += $"\n Drink  x{numOfDrink}";
            receiptLabel.Text += $"\n Fries  x{numOfFries}";
            receiptLabel.Text += $"\n-------------------------------------------------------------";
            receiptLabel.Text = $"\n{subtotal.ToString("C")}";
            receiptLabel.Text = $"\n{taxAmount.ToString("C")}";
            receiptLabel.Text = $"\n{totalPrice.ToString("C")}";

        }
    }
}
