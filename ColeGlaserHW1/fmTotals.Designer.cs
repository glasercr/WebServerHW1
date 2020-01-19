namespace ColeGlaserHW1
{
    partial class fmTotals
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblOrder = new System.Windows.Forms.Label();
            this.gbCustomerInfo = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCityState = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblNumSize = new System.Windows.Forms.Label();
            this.gbPaymentInfo = new System.Windows.Forms.GroupBox();
            this.lblExpiry = new System.Windows.Forms.Label();
            this.lblCCNumber = new System.Windows.Forms.Label();
            this.lblMethod = new System.Windows.Forms.Label();
            this.lblCoupon = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.gbCustomerInfo.SuspendLayout();
            this.gbDetails.SuspendLayout();
            this.gbPaymentInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(334, 9);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(111, 13);
            this.lblOrder.TabIndex = 0;
            this.lblOrder.Text = "Order {number} Totals";
            // 
            // gbCustomerInfo
            // 
            this.gbCustomerInfo.Controls.Add(this.lblPhone);
            this.gbCustomerInfo.Controls.Add(this.lblCityState);
            this.gbCustomerInfo.Controls.Add(this.lblAddress);
            this.gbCustomerInfo.Controls.Add(this.lblName);
            this.gbCustomerInfo.Location = new System.Drawing.Point(127, 62);
            this.gbCustomerInfo.Name = "gbCustomerInfo";
            this.gbCustomerInfo.Size = new System.Drawing.Size(200, 149);
            this.gbCustomerInfo.TabIndex = 1;
            this.gbCustomerInfo.TabStop = false;
            this.gbCustomerInfo.Text = "Customer Information";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(15, 56);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address";
            // 
            // lblCityState
            // 
            this.lblCityState.AutoSize = true;
            this.lblCityState.Location = new System.Drawing.Point(15, 86);
            this.lblCityState.Name = "lblCityState";
            this.lblCityState.Size = new System.Drawing.Size(49, 13);
            this.lblCityState.TabIndex = 2;
            this.lblCityState.Text = "CityState";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(18, 113);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "Phone";
            // 
            // gbDetails
            // 
            this.gbDetails.Controls.Add(this.lblToppings);
            this.gbDetails.Controls.Add(this.lblNumSize);
            this.gbDetails.Location = new System.Drawing.Point(393, 62);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(200, 149);
            this.gbDetails.TabIndex = 4;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Order Details";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Location = new System.Drawing.Point(15, 56);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(46, 13);
            this.lblToppings.TabIndex = 1;
            this.lblToppings.Text = "Topping";
            // 
            // lblNumSize
            // 
            this.lblNumSize.AutoSize = true;
            this.lblNumSize.Location = new System.Drawing.Point(15, 26);
            this.lblNumSize.Name = "lblNumSize";
            this.lblNumSize.Size = new System.Drawing.Size(49, 13);
            this.lblNumSize.TabIndex = 0;
            this.lblNumSize.Text = "NumSize";
            // 
            // gbPaymentInfo
            // 
            this.gbPaymentInfo.Controls.Add(this.lblCost);
            this.gbPaymentInfo.Controls.Add(this.lblTotal);
            this.gbPaymentInfo.Controls.Add(this.lblExpiry);
            this.gbPaymentInfo.Controls.Add(this.lblCCNumber);
            this.gbPaymentInfo.Controls.Add(this.lblMethod);
            this.gbPaymentInfo.Controls.Add(this.lblCoupon);
            this.gbPaymentInfo.Location = new System.Drawing.Point(127, 245);
            this.gbPaymentInfo.Name = "gbPaymentInfo";
            this.gbPaymentInfo.Size = new System.Drawing.Size(466, 149);
            this.gbPaymentInfo.TabIndex = 5;
            this.gbPaymentInfo.TabStop = false;
            this.gbPaymentInfo.Text = "Payment Information";
            // 
            // lblExpiry
            // 
            this.lblExpiry.AutoSize = true;
            this.lblExpiry.Location = new System.Drawing.Point(18, 113);
            this.lblExpiry.Name = "lblExpiry";
            this.lblExpiry.Size = new System.Drawing.Size(61, 13);
            this.lblExpiry.TabIndex = 3;
            this.lblExpiry.Text = "Expiry Date";
            // 
            // lblCCNumber
            // 
            this.lblCCNumber.AutoSize = true;
            this.lblCCNumber.Location = new System.Drawing.Point(15, 86);
            this.lblCCNumber.Name = "lblCCNumber";
            this.lblCCNumber.Size = new System.Drawing.Size(61, 13);
            this.lblCCNumber.TabIndex = 2;
            this.lblCCNumber.Text = "CC Number";
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(15, 56);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(87, 13);
            this.lblMethod.TabIndex = 1;
            this.lblMethod.Text = "Payment Method";
            // 
            // lblCoupon
            // 
            this.lblCoupon.AutoSize = true;
            this.lblCoupon.Location = new System.Drawing.Point(15, 26);
            this.lblCoupon.Name = "lblCoupon";
            this.lblCoupon.Size = new System.Drawing.Size(55, 13);
            this.lblCoupon.TabIndex = 0;
            this.lblCoupon.Text = "CouponID";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(331, 56);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total:";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(334, 86);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(28, 13);
            this.lblCost.TabIndex = 5;
            this.lblCost.Text = "Cost";
            // 
            // fmTotals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbPaymentInfo);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.gbCustomerInfo);
            this.Controls.Add(this.lblOrder);
            this.Name = "fmTotals";
            this.Text = "fmTotals";
            this.gbCustomerInfo.ResumeLayout(false);
            this.gbCustomerInfo.PerformLayout();
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.gbPaymentInfo.ResumeLayout(false);
            this.gbPaymentInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.GroupBox gbCustomerInfo;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCityState;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblNumSize;
        private System.Windows.Forms.GroupBox gbPaymentInfo;
        private System.Windows.Forms.Label lblExpiry;
        private System.Windows.Forms.Label lblCCNumber;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.Label lblCoupon;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblTotal;
    }
}