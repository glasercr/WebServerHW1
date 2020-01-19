using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColeGlaserHW1
{
	public partial class fmOrder : Form
	{
		public fmOrder()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

        private void frmOrder_Close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.formSubmission(sender, e);
        }

        private FormInfo formSubmission(object sender, EventArgs e)
        {
            CustomerInfo customerInfo = getCustomerInfo();

            PaymentInfo paymentInfo = getPaymentInfo();

            PizzaInfo pizzaInfo = getPizzaInfo();

            double cost = calculateCost(paymentInfo.Quantity, pizzaInfo.numberOfToppings, pizzaInfo.pizzaBaseCost);

            FormInfo formInfo = new FormInfo
            {
                customerInfo = customerInfo,
                paymentInfo = paymentInfo,
                pizzaInfo = pizzaInfo,
                totalCost = cost,
                orderNumber = Convert.ToInt32(this.tbOrderNo.Text)
            };

            return formInfo;
        }

        #region Getting Data

        private CustomerInfo getCustomerInfo()
        {
            CustomerInfo customerInfo = new CustomerInfo
            {
                Name = this.tbName.Text,
                Address = this.tbAddress.Text,
                City = this.tbCity.Text,
                ZipCode = Convert.ToInt32(this.tbZip.Text),
                State = this.cbState.SelectedItem.ToString(),
                PhoneNumber = Convert.ToInt64(this.tbPhone.Text)
            };

            return customerInfo;
        }

        private PaymentInfo getPaymentInfo()
        {
            PaymentInfo paymentInfo = new PaymentInfo
            {
                Quantity = Convert.ToInt32(this.cbQuantity.SelectedItem),
                CouponID = Convert.ToInt32(this.tbCoupon.Text),
                PaymentMethod = this.cbMethod.SelectedItem.ToString(),
                CCNumber = Convert.ToInt32(this.tbCCNumber.Text),
                ExpiryDate = Convert.ToDateTime(this.dtExpiry.Value)
            };

            return paymentInfo;
        }

        private PizzaInfo getPizzaInfo()
        {
            PizzaInfo pizzaInfo = new PizzaInfo();
            pizzaInfo.toppingsList = new List<string>();

            if (this.rbSmall.Checked)
            {
                pizzaInfo.pizzaSize= "Small";
                pizzaInfo.pizzaBaseCost = 10;
            }
            else if (this.rbMedium.Checked)
            {
                pizzaInfo.pizzaSize = "Medium";
                pizzaInfo.pizzaBaseCost = 15;
            }
            else if (this.rbLarge.Checked)
            {
                pizzaInfo.pizzaSize = "Large";
                pizzaInfo.pizzaBaseCost = 15;
            }

            if (cbPepperoni.Checked)
            {
                pizzaInfo.toppingsList.Add("Pepperoni");
                pizzaInfo.numberOfToppings++;
            }
            if (cbSausage.Checked)
            {
                pizzaInfo.toppingsList.Add("Sausage");
                pizzaInfo.numberOfToppings++;
            }
            if (cbOlives.Checked)
            {
                pizzaInfo.toppingsList.Add("Olives");
                pizzaInfo.numberOfToppings++;
            }
            if (cbOnion.Checked)
            {
                pizzaInfo.toppingsList.Add("Onions");
                pizzaInfo.numberOfToppings++;
            }
            if (cbCheese.Checked)
            {
                pizzaInfo.toppingsList.Add("Extra Cheese");
                pizzaInfo.numberOfToppings++;
            }

            return pizzaInfo;
        }

        private double calculateCost(int quantity, int numberOfToppings, int baseCost)
        {
            double taxRate = 0.06;

            double costPerPizza = baseCost + (numberOfToppings * 0.5);
            double totalCost = costPerPizza * quantity;
            totalCost = totalCost + (totalCost * taxRate);

            return totalCost;
        }

        #endregion
    }
}
