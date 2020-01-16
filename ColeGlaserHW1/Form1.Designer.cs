namespace ColeGlaserHW1
{
	partial class Form1
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
            this.btnOrderNo = new System.Windows.Forms.TextBox();
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.lblOrderNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.tbZip = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.lblToppings = new System.Windows.Forms.Label();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbPepperoni = new System.Windows.Forms.CheckBox();
            this.cbSausage = new System.Windows.Forms.CheckBox();
            this.cbCheese = new System.Windows.Forms.CheckBox();
            this.cbOlives = new System.Windows.Forms.CheckBox();
            this.cbOnion = new System.Windows.Forms.CheckBox();
            this.gbPayment = new System.Windows.Forms.GroupBox();
            this.cbQuantity = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCoupon = new System.Windows.Forms.Label();
            this.tbMethod = new System.Windows.Forms.TextBox();
            this.lblMethod = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblCard = new System.Windows.Forms.Label();
            this.dtExpiry = new System.Windows.Forms.DateTimePicker();
            this.lblExpiry = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbCustomer.SuspendLayout();
            this.gbSize.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOrderNo
            // 
            this.btnOrderNo.Location = new System.Drawing.Point(535, 12);
            this.btnOrderNo.Name = "btnOrderNo";
            this.btnOrderNo.Size = new System.Drawing.Size(156, 20);
            this.btnOrderNo.TabIndex = 0;
            // 
            // gbCustomer
            // 
            this.gbCustomer.Controls.Add(this.cbState);
            this.gbCustomer.Controls.Add(this.lblState);
            this.gbCustomer.Controls.Add(this.tbPhone);
            this.gbCustomer.Controls.Add(this.lblPhone);
            this.gbCustomer.Controls.Add(this.tbZip);
            this.gbCustomer.Controls.Add(this.lblZip);
            this.gbCustomer.Controls.Add(this.tbCity);
            this.gbCustomer.Controls.Add(this.lblCity);
            this.gbCustomer.Controls.Add(this.tbAddress);
            this.gbCustomer.Controls.Add(this.lblAddress);
            this.gbCustomer.Controls.Add(this.tbName);
            this.gbCustomer.Controls.Add(this.lblName);
            this.gbCustomer.Location = new System.Drawing.Point(26, 46);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(269, 244);
            this.gbCustomer.TabIndex = 1;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "Customer Information";
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.AutoSize = true;
            this.lblOrderNo.Location = new System.Drawing.Point(429, 19);
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Size = new System.Drawing.Size(73, 13);
            this.lblOrderNo.TabIndex = 2;
            this.lblOrderNo.Text = "Order Number";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(125, 29);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 1;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(125, 60);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(100, 20);
            this.tbAddress.TabIndex = 3;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(7, 60);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address:";
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(125, 94);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(100, 20);
            this.tbCity.TabIndex = 5;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(7, 94);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City:";
            // 
            // tbZip
            // 
            this.tbZip.Location = new System.Drawing.Point(124, 128);
            this.tbZip.Name = "tbZip";
            this.tbZip.Size = new System.Drawing.Size(100, 20);
            this.tbZip.TabIndex = 7;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(6, 128);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(53, 13);
            this.lblZip.TabIndex = 6;
            this.lblZip.Text = "Zip Code:";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(124, 186);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(101, 20);
            this.tbPhone.TabIndex = 9;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(7, 184);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "Phone:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(7, 159);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(35, 13);
            this.lblState.TabIndex = 10;
            this.lblState.Text = "State:";
            // 
            // cbState
            // 
            this.cbState.FormattingEnabled = true;
            this.cbState.Location = new System.Drawing.Point(124, 159);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(40, 21);
            this.cbState.TabIndex = 13;
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Location = new System.Drawing.Point(522, 46);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(51, 13);
            this.lblToppings.TabIndex = 3;
            this.lblToppings.Text = "Toppings";
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Location = new System.Drawing.Point(373, 75);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(381, 51);
            this.gbSize.TabIndex = 4;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Pizza Size";
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(7, 20);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(50, 17);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(150, 20);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(62, 17);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(310, 20);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(52, 17);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.TabStop = true;
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbOnion);
            this.groupBox1.Controls.Add(this.cbOlives);
            this.groupBox1.Controls.Add(this.cbCheese);
            this.groupBox1.Controls.Add(this.cbSausage);
            this.groupBox1.Controls.Add(this.cbPepperoni);
            this.groupBox1.Location = new System.Drawing.Point(373, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 75);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toppings (add $0.50 Each)";
            // 
            // cbPepperoni
            // 
            this.cbPepperoni.AutoSize = true;
            this.cbPepperoni.Location = new System.Drawing.Point(25, 18);
            this.cbPepperoni.Name = "cbPepperoni";
            this.cbPepperoni.Size = new System.Drawing.Size(74, 17);
            this.cbPepperoni.TabIndex = 0;
            this.cbPepperoni.Text = "Pepperoni";
            this.cbPepperoni.UseVisualStyleBackColor = true;
            // 
            // cbSausage
            // 
            this.cbSausage.AutoSize = true;
            this.cbSausage.Location = new System.Drawing.Point(126, 19);
            this.cbSausage.Name = "cbSausage";
            this.cbSausage.Size = new System.Drawing.Size(68, 17);
            this.cbSausage.TabIndex = 1;
            this.cbSausage.Text = "Sausage";
            this.cbSausage.UseVisualStyleBackColor = true;
            // 
            // cbCheese
            // 
            this.cbCheese.AutoSize = true;
            this.cbCheese.Location = new System.Drawing.Point(181, 41);
            this.cbCheese.Name = "cbCheese";
            this.cbCheese.Size = new System.Drawing.Size(89, 17);
            this.cbCheese.TabIndex = 2;
            this.cbCheese.Text = "Extra Cheese";
            this.cbCheese.UseVisualStyleBackColor = true;
            // 
            // cbOlives
            // 
            this.cbOlives.AutoSize = true;
            this.cbOlives.Location = new System.Drawing.Point(234, 18);
            this.cbOlives.Name = "cbOlives";
            this.cbOlives.Size = new System.Drawing.Size(55, 17);
            this.cbOlives.TabIndex = 3;
            this.cbOlives.Text = "Olives";
            this.cbOlives.UseVisualStyleBackColor = true;
            // 
            // cbOnion
            // 
            this.cbOnion.AutoSize = true;
            this.cbOnion.Location = new System.Drawing.Point(70, 41);
            this.cbOnion.Name = "cbOnion";
            this.cbOnion.Size = new System.Drawing.Size(59, 17);
            this.cbOnion.TabIndex = 4;
            this.cbOnion.Text = "Onions";
            this.cbOnion.UseVisualStyleBackColor = true;
            // 
            // gbPayment
            // 
            this.gbPayment.Controls.Add(this.lblExpiry);
            this.gbPayment.Controls.Add(this.dtExpiry);
            this.gbPayment.Controls.Add(this.textBox3);
            this.gbPayment.Controls.Add(this.lblCard);
            this.gbPayment.Controls.Add(this.tbMethod);
            this.gbPayment.Controls.Add(this.lblMethod);
            this.gbPayment.Controls.Add(this.textBox1);
            this.gbPayment.Controls.Add(this.lblCoupon);
            this.gbPayment.Controls.Add(this.cbQuantity);
            this.gbPayment.Controls.Add(this.lblQuantity);
            this.gbPayment.Location = new System.Drawing.Point(373, 251);
            this.gbPayment.Name = "gbPayment";
            this.gbPayment.Size = new System.Drawing.Size(381, 167);
            this.gbPayment.TabIndex = 6;
            this.gbPayment.TabStop = false;
            this.gbPayment.Text = "Payment Information";
            // 
            // cbQuantity
            // 
            this.cbQuantity.FormattingEnabled = true;
            this.cbQuantity.Location = new System.Drawing.Point(98, 41);
            this.cbQuantity.Name = "cbQuantity";
            this.cbQuantity.Size = new System.Drawing.Size(40, 21);
            this.cbQuantity.TabIndex = 15;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(22, 44);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 14;
            this.lblQuantity.Text = "Quantity:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(253, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(101, 20);
            this.textBox1.TabIndex = 17;
            // 
            // lblCoupon
            // 
            this.lblCoupon.AutoSize = true;
            this.lblCoupon.Location = new System.Drawing.Point(178, 49);
            this.lblCoupon.Name = "lblCoupon";
            this.lblCoupon.Size = new System.Drawing.Size(61, 13);
            this.lblCoupon.TabIndex = 16;
            this.lblCoupon.Text = "Coupon ID:";
            // 
            // tbMethod
            // 
            this.tbMethod.Location = new System.Drawing.Point(139, 76);
            this.tbMethod.Name = "tbMethod";
            this.tbMethod.Size = new System.Drawing.Size(101, 20);
            this.tbMethod.TabIndex = 19;
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(22, 83);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(90, 13);
            this.lblMethod.TabIndex = 18;
            this.lblMethod.Text = "Payment Method:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(139, 108);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(101, 20);
            this.textBox3.TabIndex = 21;
            // 
            // lblCard
            // 
            this.lblCard.AutoSize = true;
            this.lblCard.Location = new System.Drawing.Point(10, 115);
            this.lblCard.Name = "lblCard";
            this.lblCard.Size = new System.Drawing.Size(102, 13);
            this.lblCard.TabIndex = 20;
            this.lblCard.Text = "Credit Card Number:";
            // 
            // dtExpiry
            // 
            this.dtExpiry.Location = new System.Drawing.Point(139, 141);
            this.dtExpiry.Name = "dtExpiry";
            this.dtExpiry.Size = new System.Drawing.Size(200, 20);
            this.dtExpiry.TabIndex = 22;
            // 
            // lblExpiry
            // 
            this.lblExpiry.AutoSize = true;
            this.lblExpiry.Location = new System.Drawing.Point(48, 147);
            this.lblExpiry.Name = "lblExpiry";
            this.lblExpiry.Size = new System.Drawing.Size(64, 13);
            this.lblExpiry.TabIndex = 23;
            this.lblExpiry.Text = "Expiry Date:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(26, 398);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(114, 23);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit Order";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(181, 398);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gbPayment);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.lblOrderNo);
            this.Controls.Add(this.gbCustomer);
            this.Controls.Add(this.btnOrderNo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbCustomer.ResumeLayout(false);
            this.gbCustomer.PerformLayout();
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbPayment.ResumeLayout(false);
            this.gbPayment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.TextBox btnOrderNo;
        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox tbZip;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblOrderNo;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbOnion;
        private System.Windows.Forms.CheckBox cbOlives;
        private System.Windows.Forms.CheckBox cbCheese;
        private System.Windows.Forms.CheckBox cbSausage;
        private System.Windows.Forms.CheckBox cbPepperoni;
        private System.Windows.Forms.GroupBox gbPayment;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCoupon;
        private System.Windows.Forms.ComboBox cbQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.TextBox tbMethod;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.DateTimePicker dtExpiry;
        private System.Windows.Forms.Label lblExpiry;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnExit;
    }
}

