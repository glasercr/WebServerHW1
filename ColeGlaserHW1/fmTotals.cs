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
    public partial class fmTotals : Form
    {
        public fmTotals(FormInfo formInfo)
        {
            InitializeComponent();
            setValues(formInfo);

            this.Show();
        }

        private void setValues(FormInfo formInfo)
        {
            this.lblName.Text = formInfo.customerInfo.Name;
            this.lblAddress.Text = formInfo.customerInfo.Address;
            this.lblCityState.Text = 
                formInfo.customerInfo.City + " " +
                formInfo.customerInfo.State + ", " + 
                formInfo.customerInfo.ZipCode;
            this.lblPhone.Text = formInfo.customerInfo.PhoneNumber.ToString();

            this.lblNumSize.Text =
                formInfo.paymentInfo.Quantity.ToString() + " " +
                formInfo.pizzaInfo.pizzaSize + " Pizza(s)";

            StringBuilder stringBuilder = new StringBuilder();
            foreach(string topping in formInfo.pizzaInfo.toppingsList)
            {
                stringBuilder.AppendLine(topping);
            }
            this.lblToppings.Text = stringBuilder.ToString();

            this.lblCoupon.Text = "CouponID: " + formInfo.paymentInfo.CouponID;
            this.lblMethod.Text = "Payment Method: " + formInfo.paymentInfo.PaymentMethod;
            this.lblCCNumber.Text = "Card Number: " + formInfo.paymentInfo.CCNumber.ToString();
            this.lblExpiry.Text = "Expires on: " + formInfo.paymentInfo.ExpiryDate.ToString();
            this.lblCost.Text = "$" + formInfo.totalCost;
        }
    }
}
